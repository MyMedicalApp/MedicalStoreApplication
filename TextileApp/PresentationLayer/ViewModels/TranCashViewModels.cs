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
    public class TranCashViewModels : TranCashM
    {
        #region Private Variables
            private readonly ICommand _addTranCashCmd;
            private readonly ICommand _deleteTranCashCmd;
            private readonly ICommand _resetTranCashCmd;
            private readonly ICommand _searchTranCashCmd;
            private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataParty = new ObservableCollection<AutoCompleteTextBoxData>();

        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public TranCashViewModels()
            {
                objTranCash        = new TranCashM();
                _addTranCashCmd    = new RelayCommand(Add, CanAdd);
                _deleteTranCashCmd = new RelayCommand(Delete, CanDelete);
                _resetTranCashCmd = new RelayCommand(Reset, CanReset);
                _searchTranCashCmd = new RelayCommand(Search, CanSearch);

                T_MstAccountMaster t_MstAccountMaster = new T_MstAccountMaster();
                List<T_MstAccountMaster> listT_MstAccountMaster = BLL.BllClient.objBllClient.GetList<T_MstAccountMaster>(Common.DataSourceTypes.T_MstAccountMasterList, t_MstAccountMaster);
                foreach (T_MstAccountMaster item in listT_MstAccountMaster)
                {
                    AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                    atd.Text = item.AccountName;
                    atd.Value = Convert.ToString(item.AccountCode);
                    _combBoxDataParty.Add(atd);
                }

            }
        #endregion
  
        #region Property
            public TranCashM objTranCash { get; set; }
            public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataParty { get { return _combBoxDataParty; } }
           
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddTranCashCommand. Used for Add TranCash Button Operations
            /// </summary>
            public ICommand AddTranCashCmd { get { return _addTranCashCmd; } }
  
            /// <summary>
            /// Gets the DeleteTranCashCmd. Used for Delete TranCash Button Operations
            /// </summary>
            public ICommand DeleteTranCashCmd { get { return _deleteTranCashCmd; } }
  
            /// <summary>
            /// Gets the ResetTranCashCmd. Used for Reset TranCash Button Operations
            /// </summary>
            public ICommand ResetTranCashCmd { get { return _resetTranCashCmd; } }
  
            /// <summary>
            /// Gets the SearchTranCashCmd. Used for Search TranCash Button Operations
            /// </summary>
            public ICommand SearchTranCashCmd { get { return _searchTranCashCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranCash.TranBankId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save TranCash?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        AutoCompleteTextBox autoCompleteTextBoxA = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                        
                        objTranCash.PartyId = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxA.SelectedItem)).Value);
                        
                        MessageBox.Show(objTranCash.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranCash.TranBankId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranCash.ResetData();

                        AutoCompleteTextBox autoCompleteTextBoxA = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                        autoCompleteTextBoxA.Text = string.Empty;
                        
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranCash.SearchTranBankId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Search(object obj)
                {
                    objTranCash.SearchData();


                    AutoCompleteTextBox autoCompleteTextBoxA = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                    autoCompleteTextBoxA.Text = objTranCash.AccountName;                    
                    
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objTranCash.TranBankId > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete TranCash data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranCash.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
