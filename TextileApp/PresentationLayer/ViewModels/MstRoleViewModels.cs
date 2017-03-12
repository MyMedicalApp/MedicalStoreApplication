 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstRoleViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstRoleCmd;
            private readonly ICommand _deleteMstRoleCmd;
            private readonly ICommand _resetMstRoleCmd;
            private readonly ICommand _searchMstRoleCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstRoleViewModels()
            {
                objMstRole        = new MstRoleM();
                _addMstRoleCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstRoleCmd = new RelayCommand(Delete, CanDelete);
                _resetMstRoleCmd = new RelayCommand(Reset, CanReset);
                _searchMstRoleCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstRoleM objMstRole { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstRoleCommand. Used for Add MstRole Button Operations
            /// </summary>
            public ICommand AddMstRoleCmd { get { return _addMstRoleCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstRoleCmd. Used for Delete MstRole Button Operations
            /// </summary>
            public ICommand DeleteMstRoleCmd { get { return _deleteMstRoleCmd; } }
  
            /// <summary>
            /// Gets the ResetMstRoleCmd. Used for Reset MstRole Button Operations
            /// </summary>
            public ICommand ResetMstRoleCmd { get { return _resetMstRoleCmd; } }
  
            /// <summary>
            /// Gets the SearchMstRoleCmd. Used for Search MstRole Button Operations
            /// </summary>
            public ICommand SearchMstRoleCmd { get { return _searchMstRoleCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstRole.RoleId > 0)
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstRole?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstRole.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstRole.RoleId > 0)
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstRole.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstRole.SearchRoleId > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstRole.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstRole.RoleId > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstRole data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstRole.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
