 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstFinancialYearViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstFinancialYearCmd;
            private readonly ICommand _deleteMstFinancialYearCmd;
            private readonly ICommand _resetMstFinancialYearCmd;
            private readonly ICommand _searchMstFinancialYearCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstFinancialYearViewModels()
            {
                objMstFinancialYear        = new MstFinancialYearM();
                _addMstFinancialYearCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstFinancialYearCmd = new RelayCommand(Delete, CanDelete);
                _resetMstFinancialYearCmd = new RelayCommand(Reset, CanReset);
                _searchMstFinancialYearCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstFinancialYearM objMstFinancialYear { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstFinancialYearCommand. Used for Add MstFinancialYear Button Operations
            /// </summary>
            public ICommand AddMstFinancialYearCmd { get { return _addMstFinancialYearCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstFinancialYearCmd. Used for Delete MstFinancialYear Button Operations
            /// </summary>
            public ICommand DeleteMstFinancialYearCmd { get { return _deleteMstFinancialYearCmd; } }
  
            /// <summary>
            /// Gets the ResetMstFinancialYearCmd. Used for Reset MstFinancialYear Button Operations
            /// </summary>
            public ICommand ResetMstFinancialYearCmd { get { return _resetMstFinancialYearCmd; } }
  
            /// <summary>
            /// Gets the SearchMstFinancialYearCmd. Used for Search MstFinancialYear Button Operations
            /// </summary>
            public ICommand SearchMstFinancialYearCmd { get { return _searchMstFinancialYearCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstFinancialYear.FinancialYearId > 0)
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstFinancialYear?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstFinancialYear.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstFinancialYear.FinancialYearId > 0)
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstFinancialYear.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstFinancialYear.SearchFinancialYearId > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstFinancialYear.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstFinancialYear.FinancialYearId > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstFinancialYear data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstFinancialYear.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
