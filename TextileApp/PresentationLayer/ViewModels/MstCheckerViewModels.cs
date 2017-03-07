 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstCheckerViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstCheckerCmd;
            private readonly ICommand _deleteMstCheckerCmd;
            private readonly ICommand _resetMstCheckerCmd;
            private readonly ICommand _searchMstCheckerCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstCheckerViewModels()
            {
                objMstChecker        = new MstCheckerM();
                _addMstCheckerCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstCheckerCmd = new RelayCommand(Delete, CanDelete);
                _resetMstCheckerCmd = new RelayCommand(Reset, CanReset);
                _searchMstCheckerCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstCheckerM objMstChecker { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstCheckerCommand. Used for Add MstChecker Button Operations
            /// </summary>
            public ICommand AddMstCheckerCmd { get { return _addMstCheckerCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstCheckerCmd. Used for Delete MstChecker Button Operations
            /// </summary>
            public ICommand DeleteMstCheckerCmd { get { return _deleteMstCheckerCmd; } }
  
            /// <summary>
            /// Gets the ResetMstCheckerCmd. Used for Reset MstChecker Button Operations
            /// </summary>
            public ICommand ResetMstCheckerCmd { get { return _resetMstCheckerCmd; } }
  
            /// <summary>
            /// Gets the SearchMstCheckerCmd. Used for Search MstChecker Button Operations
            /// </summary>
            public ICommand SearchMstCheckerCmd { get { return _searchMstCheckerCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstChecker.CheckerCode > 0 && !string.IsNullOrEmpty(objMstChecker.CheckerName))
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstChecker?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstChecker.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstChecker.CheckerCode > 0 && !string.IsNullOrEmpty(objMstChecker.CheckerName))
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstChecker.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstChecker.SearchCheckerCode > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstChecker.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstChecker.CheckerCode > 0 && !string.IsNullOrEmpty(objMstChecker.CheckerName))
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstChecker data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstChecker.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
