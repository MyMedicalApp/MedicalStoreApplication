 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstGroupViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstGroupCmd;
            private readonly ICommand _deleteMstGroupCmd;
            private readonly ICommand _resetMstGroupCmd;
            private readonly ICommand _searchMstGroupCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstGroupViewModels()
            {
                objMstGroup        = new MstGroupM();
                _addMstGroupCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstGroupCmd = new RelayCommand(Delete, CanDelete);
                _resetMstGroupCmd = new RelayCommand(Reset, CanReset);
                _searchMstGroupCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstGroupM objMstGroup { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstGroupCommand. Used for Add MstGroup Button Operations
            /// </summary>
            public ICommand AddMstGroupCmd { get { return _addMstGroupCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstGroupCmd. Used for Delete MstGroup Button Operations
            /// </summary>
            public ICommand DeleteMstGroupCmd { get { return _deleteMstGroupCmd; } }
  
            /// <summary>
            /// Gets the ResetMstGroupCmd. Used for Reset MstGroup Button Operations
            /// </summary>
            public ICommand ResetMstGroupCmd { get { return _resetMstGroupCmd; } }
  
            /// <summary>
            /// Gets the SearchMstGroupCmd. Used for Search MstGroup Button Operations
            /// </summary>
            public ICommand SearchMstGroupCmd { get { return _searchMstGroupCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstGroup.GroupId > 0)
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstGroup?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstGroup.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstGroup.GroupId > 0)
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstGroup.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstGroup.SearchGroupId > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstGroup.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstGroup.GroupId > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstGroup data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstGroup.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
