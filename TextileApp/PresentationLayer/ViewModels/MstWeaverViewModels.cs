 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstWeaverViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstWeaverCmd;
            private readonly ICommand _deleteMstWeaverCmd;
            private readonly ICommand _resetMstWeaverCmd;
            private readonly ICommand _searchMstWeaverCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstWeaverViewModels()
            {
                objMstWeaver        = new MstWeaverM();
                _addMstWeaverCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstWeaverCmd = new RelayCommand(Delete, CanDelete);
                _resetMstWeaverCmd = new RelayCommand(Reset, CanReset);
                _searchMstWeaverCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstWeaverM objMstWeaver { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstWeaverCommand. Used for Add MstWeaver Button Operations
            /// </summary>
            public ICommand AddMstWeaverCmd { get { return _addMstWeaverCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstWeaverCmd. Used for Delete MstWeaver Button Operations
            /// </summary>
            public ICommand DeleteMstWeaverCmd { get { return _deleteMstWeaverCmd; } }
  
            /// <summary>
            /// Gets the ResetMstWeaverCmd. Used for Reset MstWeaver Button Operations
            /// </summary>
            public ICommand ResetMstWeaverCmd { get { return _resetMstWeaverCmd; } }
  
            /// <summary>
            /// Gets the SearchMstWeaverCmd. Used for Search MstWeaver Button Operations
            /// </summary>
            public ICommand SearchMstWeaverCmd { get { return _searchMstWeaverCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstWeaver.WeaverCode > 0 && !string.IsNullOrEmpty(objMstWeaver.WeaverName))
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstWeaver?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstWeaver.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstWeaver.WeaverCode > 0 && !string.IsNullOrEmpty(objMstWeaver.WeaverName))
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstWeaver.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstWeaver.SearchWeaverCode > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstWeaver.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstWeaver.WeaverCode > 0 && !string.IsNullOrEmpty(objMstWeaver.WeaverName))
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstWeaver data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstWeaver.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
