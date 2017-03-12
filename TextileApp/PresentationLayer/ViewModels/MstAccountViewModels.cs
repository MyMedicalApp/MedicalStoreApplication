 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
    
namespace TextileApp.ViewModels
{    
    public class MstAccountViewModels : INotifyPropertyChanged
    {
        #region Private Variables
            private readonly ICommand _addMstAccountCmd;
            private readonly ICommand _deleteMstAccountCmd;
            private readonly ICommand _resetMstAccountCmd;
            private readonly ICommand _searchMstAccountCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstAccountViewModels()
            {
                objMstAccount        = new MstAccountM();
                _addMstAccountCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstAccountCmd = new RelayCommand(Delete, CanDelete);
                _resetMstAccountCmd = new RelayCommand(Reset, CanReset);
                _searchMstAccountCmd = new RelayCommand(Search, CanSearch);

                listCompany = new ObservableCollection<T_MstCompany>();
                listFY      = BLL.BllClient.objBllClient.GetList<T_MstFinancialYear>(Common.DataSourceTypes.T_MstFinancialYearList, new T_MstFinancialYear());                
            }
        #endregion
  
        #region Property
            public MstAccountM objMstAccount { get; set; }

            T_MstCompany objSelectedCompany;
            public T_MstCompany SelectedCompany
            {
                get { return objSelectedCompany; }
                set
                {
                    objSelectedCompany = value;
                    objMstAccount.CompanyId = objSelectedCompany.CompanyId;
                    OnPropertyChanged("objSelectedCompany");                                        
                }
            }

            T_MstFinancialYear objSelectedFY;
            public T_MstFinancialYear SelectedFY
            {
                get { return objSelectedFY; }
                set
                {
                    objSelectedFY = value;
                    OnPropertyChanged("SelectedFY");
                    objMstAccount.FinancialYearId = objSelectedFY.FinancialYearId;
                    listCompany.Clear();
                    listCompany = new ObservableCollection<T_MstCompany>(BLL.BllClient.objBllClient.GetList<T_MstCompany>(Common.DataSourceTypes.T_MstCompanyDropdownList
                                            , new T_MstCompany() { FinancialYearId = SelectedFY.FinancialYearId }));            
                }
            }

            ObservableCollection<T_MstCompany> objlistCompany;
            public ObservableCollection<T_MstCompany> listCompany
            {
                get { return objlistCompany; }
                set
                {
                    objlistCompany = value;
                    OnPropertyChanged("listCompany");                    
                }
            }
            
            public List<T_MstFinancialYear> listFY { get; set; }
           // public ObservableCollection<T_MstCompany> listCompany { get; set; }

        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstAccountCommand. Used for Add MstAccount Button Operations
            /// </summary>
            public ICommand AddMstAccountCmd { get { return _addMstAccountCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstAccountCmd. Used for Delete MstAccount Button Operations
            /// </summary>
            public ICommand DeleteMstAccountCmd { get { return _deleteMstAccountCmd; } }
  
            /// <summary>
            /// Gets the ResetMstAccountCmd. Used for Reset MstAccount Button Operations
            /// </summary>
            public ICommand ResetMstAccountCmd { get { return _resetMstAccountCmd; } }
  
            /// <summary>
            /// Gets the SearchMstAccountCmd. Used for Search MstAccount Button Operations
            /// </summary>
            public ICommand SearchMstAccountCmd { get { return _searchMstAccountCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    ////Enable the Button only if the mandatory fields are filled
                    //if (objMstAccount.AccountId > 0)
                    //    return true;
                    //return false;

                    return true;
                }
  
                public void Add(object obj)
                {
                    Window objLogin = Application.Current.MainWindow;                    

                    MainWindow mainWindow = new MainWindow();                  
                    mainWindow.Show();
                    CommonModel.CurrentUser = objMstAccount;

                    objLogin.Close();
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    ////Enable the Button only if the mandatory fields are filled
                    //if (objMstAccount.AccountId > 0)
                    //    return true;
                    //return false;

                    return true;
                }
 
                public void Reset(object obj)
                {
                    Window objLogin = Application.Current.MainWindow;
                    objLogin.Close();
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstAccount.SearchAccountId > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstAccount.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstAccount.AccountId > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstAccount data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstAccount.DeleteData();
                    }
                }
            #endregion
  
        #endregion

        #region INotifyPropertyChanged Members
             /// <summary>
             /// Event to which the view's controls will subscribe.
             /// This will enable them to refresh themselves when the binded property changes provided you fire this event.
             /// </summary>
             public event PropertyChangedEventHandler PropertyChanged;

             /// <summary>
             /// When property is changed call this method to fire the PropertyChanged Event
             /// </summary>
             /// <param name="propertyName"></param>
             public void OnPropertyChanged(string propertyName)
             {
                 //Fire the PropertyChanged event in case somebody subscribed to it
                 if (PropertyChanged != null)
                     PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
             }

        #endregion
    }
}
