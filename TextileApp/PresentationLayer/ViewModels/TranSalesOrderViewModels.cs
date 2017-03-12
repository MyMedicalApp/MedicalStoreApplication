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
    public class TranSalesOrderViewModels : TranSalesOrderM
    {
        #region Private Variables
            private readonly ICommand _addTranSalesOrderCmd;
            private readonly ICommand _deleteTranSalesOrderCmd;
            private readonly ICommand _resetTranSalesOrderCmd;
            private readonly ICommand _searchTranSalesOrderCmd;
            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataParty = new ObservableCollection<AutoCompleteTextBoxData>();

            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataViewer = new ObservableCollection<AutoCompleteTextBoxData>();

            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataQuality = new ObservableCollection<AutoCompleteTextBoxData>();

            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataBroker = new ObservableCollection<AutoCompleteTextBoxData>();

        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public TranSalesOrderViewModels()
            {
                objTranSalesOrder        = new TranSalesOrderM();
                _addTranSalesOrderCmd    = new RelayCommand(Add, CanAdd);
                _deleteTranSalesOrderCmd = new RelayCommand(Delete, CanDelete);
                _resetTranSalesOrderCmd = new RelayCommand(Reset, CanReset);
                _searchTranSalesOrderCmd = new RelayCommand(Search, CanSearch);

                T_MstAccountMaster t_MstAccountMaster = new T_MstAccountMaster();
                List<T_MstAccountMaster> listT_MstAccountMaster = BLL.BllClient.objBllClient.GetList<T_MstAccountMaster>(Common.DataSourceTypes.T_MstAccountMasterList, t_MstAccountMaster);
                foreach (T_MstAccountMaster item in listT_MstAccountMaster)
                {
                    AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                    atd.Text = item.AccountName;
                    atd.Value = Convert.ToString(item.AccountCode);
                    _combBoxDataParty.Add(atd);
                }

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
            public TranSalesOrderM objTranSalesOrder { get; set; }

            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataParty { get { return _combBoxDataParty; } }
            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataViewer { get { return _combBoxDataViewer; } }
            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataQuality { get { return _combBoxDataQuality; } }
            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataBroker { get { return _combBoxDataBroker; } }


        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddTranSalesOrderCommand. Used for Add TranSalesOrder Button Operations
            /// </summary>
            public ICommand AddTranSalesOrderCmd { get { return _addTranSalesOrderCmd; } }
  
            /// <summary>
            /// Gets the DeleteTranSalesOrderCmd. Used for Delete TranSalesOrder Button Operations
            /// </summary>
            public ICommand DeleteTranSalesOrderCmd { get { return _deleteTranSalesOrderCmd; } }
  
            /// <summary>
            /// Gets the ResetTranSalesOrderCmd. Used for Reset TranSalesOrder Button Operations
            /// </summary>
            public ICommand ResetTranSalesOrderCmd { get { return _resetTranSalesOrderCmd; } }
  
            /// <summary>
            /// Gets the SearchTranSalesOrderCmd. Used for Search TranSalesOrder Button Operations
            /// </summary>
            public ICommand SearchTranSalesOrderCmd { get { return _searchTranSalesOrderCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranSalesOrder.TranSalesOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save TranSalesOrder?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        AutoCompleteTextBox autoCompleteTextBoxA = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxV = App.Current.Windows[1].FindName("cmbViewer") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxQ = App.Current.Windows[1].FindName("cmbQuality") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxB = App.Current.Windows[1].FindName("cmbBroker") as AutoCompleteTextBox;

                        objTranSalesOrder.PartyId = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxA.SelectedItem)).Value);
                        objTranSalesOrder.WeaverCode = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxV.SelectedItem)).Value);
                        objTranSalesOrder.QualityCode = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxQ.SelectedItem)).Value);
                        objTranSalesOrder.BrokerCode = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxB.SelectedItem)).Value);

                        objTranSalesOrder.AccountName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxA.SelectedItem)).Text;
                        objTranSalesOrder.WeaverName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxV.SelectedItem)).Text;
                        objTranSalesOrder.QualityName =  ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxQ.SelectedItem)).Text;
                        objTranSalesOrder.BrokerName =   ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxB.SelectedItem)).Text;
                        
                        MessageBox.Show(objTranSalesOrder.SaveData());

                        autoCompleteTextBoxA.Text = string.Empty;
                        autoCompleteTextBoxV.Text = string.Empty;
                        autoCompleteTextBoxQ.Text = string.Empty;
                        autoCompleteTextBoxB.Text = string.Empty;
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranSalesOrder.TranSalesOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranSalesOrder.ResetData();

                        AutoCompleteTextBox autoCompleteTextBoxA = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxV = App.Current.Windows[1].FindName("cmbViewer") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxQ = App.Current.Windows[1].FindName("cmbQuality") as AutoCompleteTextBox;
                        AutoCompleteTextBox autoCompleteTextBoxB = App.Current.Windows[1].FindName("cmbBroker") as AutoCompleteTextBox;

                        autoCompleteTextBoxA.Text = string.Empty;
                        autoCompleteTextBoxV.Text = string.Empty;
                        autoCompleteTextBoxQ.Text = string.Empty;
                        autoCompleteTextBoxB.Text = string.Empty;
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranSalesOrder.SearchTranSalesOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Search(object obj)
                {
                    objTranSalesOrder.SearchData();

                    AutoCompleteTextBox autoCompleteTextBoxA = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;                        
                    AutoCompleteTextBox autoCompleteTextBoxV = App.Current.Windows[1].FindName("cmbViewer") as AutoCompleteTextBox;
                    AutoCompleteTextBox autoCompleteTextBoxQ = App.Current.Windows[1].FindName("cmbQuality") as AutoCompleteTextBox;
                    AutoCompleteTextBox autoCompleteTextBoxB = App.Current.Windows[1].FindName("cmbBroker") as AutoCompleteTextBox;

                    autoCompleteTextBoxA.Text = objTranSalesOrder.AccountName;                    
                    autoCompleteTextBoxV.Text = objTranSalesOrder.WeaverName;
                    autoCompleteTextBoxQ.Text = objTranSalesOrder.QualityName;
                    autoCompleteTextBoxB.Text = objTranSalesOrder.BrokerName;
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranSalesOrder.TranSalesOrderId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete TranSalesOrder data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranSalesOrder.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
