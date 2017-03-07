 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
using System.Collections.ObjectModel;
using TextileApp.UserControls;
    
namespace TextileApp.ViewModels
{    
    public class TranPurchaseOrderViewModels : TranPurchaseOrderM
    {
        #region Private Variables
            private readonly ICommand _addTranPurchaseOrderCmd;
            private readonly ICommand _deleteTranPurchaseOrderCmd;
            private readonly ICommand _resetTranPurchaseOrderCmd;
            private readonly ICommand _searchTranPurchaseOrderCmd;

            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataViewer = new ObservableCollection<AutoCompleteTextBoxData>();

            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataQuality = new ObservableCollection<AutoCompleteTextBoxData>();

            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataBroker = new ObservableCollection<AutoCompleteTextBoxData>();

        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public TranPurchaseOrderViewModels()
            {
                objTranPurchaseOrder        = new TranPurchaseOrderM();
                _addTranPurchaseOrderCmd    = new RelayCommand(Add, CanAdd);
                _deleteTranPurchaseOrderCmd = new RelayCommand(Delete, CanDelete);
                _resetTranPurchaseOrderCmd = new RelayCommand(Reset, CanReset);
                _searchTranPurchaseOrderCmd = new RelayCommand(Search, CanSearch);

                T_MstWeaver t_MstWeaver = new T_MstWeaver();
                List<T_MstWeaver> listT_MstWeaver = BLL.BllClient.objBllClient.GetList<T_MstWeaver>(Common.DataSourceTypes.T_MstWeaverList, t_MstWeaver);
                foreach (T_MstWeaver item in listT_MstWeaver)
                {
                    AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                    atd.Text = item.WeaverName;
                    atd.Value = Convert.ToString(item.WeaverCode);
                    _combBoxDataViewer.Add(atd);
                }

                T_MstQuality t_MstQuality = new T_MstQuality();
                List<T_MstQuality> listT_MstQuality = BLL.BllClient.objBllClient.GetList<T_MstQuality>(Common.DataSourceTypes.T_MstQualityList, t_MstQuality);
                foreach (T_MstQuality item in listT_MstQuality)
                {
                    AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                    atd.Text = item.QualityName;
                    atd.Value = Convert.ToString(item.QualityCode);
                    _combBoxDataQuality.Add(atd);
                }

                T_MstBroker t_MstBroker = new T_MstBroker();
                List<T_MstBroker> listT_MstBroker = BLL.BllClient.objBllClient.GetList<T_MstBroker>(Common.DataSourceTypes.T_MstBrokerList, t_MstBroker);
                foreach (T_MstBroker item in listT_MstBroker)
                {
                    AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                    atd.Text = item.BrokerName;
                    atd.Value = Convert.ToString(item.BrokerCode);
                    _combBoxDataBroker.Add(atd);
                }
            }
        #endregion
  
        #region Property
            public TranPurchaseOrderM objTranPurchaseOrder { get; set; }

            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataViewer { get { return _combBoxDataViewer; } }
            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataQuality { get { return _combBoxDataQuality; } }
            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataBroker { get { return _combBoxDataBroker; } }

        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddTranPurchaseOrderCommand. Used for Add TranPurchaseOrder Button Operations
            /// </summary>
            public ICommand AddTranPurchaseOrderCmd { get { return _addTranPurchaseOrderCmd; } }
  
            /// <summary>
            /// Gets the DeleteTranPurchaseOrderCmd. Used for Delete TranPurchaseOrder Button Operations
            /// </summary>
            public ICommand DeleteTranPurchaseOrderCmd { get { return _deleteTranPurchaseOrderCmd; } }
  
            /// <summary>
            /// Gets the ResetTranPurchaseOrderCmd. Used for Reset TranPurchaseOrder Button Operations
            /// </summary>
            public ICommand ResetTranPurchaseOrderCmd { get { return _resetTranPurchaseOrderCmd; } }
  
            /// <summary>
            /// Gets the SearchTranPurchaseOrderCmd. Used for Search TranPurchaseOrder Button Operations
            /// </summary>
            public ICommand SearchTranPurchaseOrderCmd { get { return _searchTranPurchaseOrderCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    ////Enable the Button only if the mandatory fields are filled
                    //if (objTranPurchaseOrder.TranPurchaseOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save TranPurchaseOrder?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        
                        AutoCompleteTextBox autoCompleteTextBoxV = App.Current.Windows[1].FindName("cmbViewer") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxQ = App.Current.Windows[1].FindName("cmbQuality") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxB = App.Current.Windows[1].FindName("cmbBroker") as AutoCompleteTextBox;

                        objTranPurchaseOrder.WeaverCode = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxV.SelectedItem)).Value);
                        objTranPurchaseOrder.QualityCode = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxQ.SelectedItem)).Value);
                        objTranPurchaseOrder.BrokerCode = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxB.SelectedItem)).Value);

                        objTranPurchaseOrder.WeaverName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxV.SelectedItem)).Text;
                        objTranPurchaseOrder.QualityName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxQ.SelectedItem)).Text;
                        objTranPurchaseOrder.BrokerName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxB.SelectedItem)).Text;
                        
                        MessageBox.Show(objTranPurchaseOrder.SaveData());

                        autoCompleteTextBoxV.Text = string.Empty;
                        autoCompleteTextBoxQ.Text = string.Empty;
                        autoCompleteTextBoxB.Text = string.Empty;
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    ////Enable the Button only if the mandatory fields are filled
                    //if (objTranPurchaseOrder.TranPurchaseOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranPurchaseOrder.ResetData();
                        
                        AutoCompleteTextBox autoCompleteTextBoxV = App.Current.Windows[1].FindName("cmbViewer") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxQ = App.Current.Windows[1].FindName("cmbQuality") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxB = App.Current.Windows[1].FindName("cmbBroker") as AutoCompleteTextBox;

                        autoCompleteTextBoxV.Text = string.Empty;
                        autoCompleteTextBoxQ.Text = string.Empty;
                        autoCompleteTextBoxB.Text = string.Empty;
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    ////Enable the Button only if the mandatory fields are filled
                    //if (objTranPurchaseOrder.TranPurchaseOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Search(object obj)
                {
                    objTranPurchaseOrder.SearchData();
                    AutoCompleteTextBox autoCompleteTextBoxV = App.Current.Windows[1].FindName("cmbViewer") as AutoCompleteTextBox;
                    AutoCompleteTextBox autoCompleteTextBoxQ = App.Current.Windows[1].FindName("cmbQuality") as AutoCompleteTextBox;
                    AutoCompleteTextBox autoCompleteTextBoxB = App.Current.Windows[1].FindName("cmbBroker") as AutoCompleteTextBox;

                    autoCompleteTextBoxV.Text = objTranPurchaseOrder.WeaverName;
                    autoCompleteTextBoxQ.Text = objTranPurchaseOrder.QualityName;
                    autoCompleteTextBoxB.Text = objTranPurchaseOrder.BrokerName;
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    ////Enable the Button only if the mandatory fields are filled
                    //if (objTranPurchaseOrder.TranPurchaseOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete TranPurchaseOrder data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranPurchaseOrder.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
