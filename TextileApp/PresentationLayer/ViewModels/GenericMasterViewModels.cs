 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using MedicalApp.Model;
 using System.Windows;
 using System.Collections.ObjectModel;

namespace MedicalApp.ViewModels
{    
    public class GenericMasterViewModels
    {
        #region Private Variables
            private readonly ICommand _addGenericMasterCmd;
            private readonly ICommand _deleteGenericMasterCmd;
            private readonly ICommand _resetGenericMasterCmd;
            private readonly ICommand _searchGenericMasterCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public GenericMasterViewModels()
            {
                objGenericMaster        = new GenericMasterM();
                _addGenericMasterCmd    = new RelayCommand(Add, CanAdd);
                _deleteGenericMasterCmd = new RelayCommand(Delete, CanDelete);
                _resetGenericMasterCmd = new RelayCommand(Reset, CanReset);
                _searchGenericMasterCmd = new RelayCommand(Search, CanSearch);
   
            }
        #endregion
  
        #region Property
            public GenericMasterM objGenericMaster { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddGenericMasterCommand. Used for Add GenericMaster Button Operations
            /// </summary>
            public ICommand AddGenericMasterCmd { get { return _addGenericMasterCmd; } }
  
            /// <summary>
            /// Gets the DeleteGenericMasterCmd. Used for Delete GenericMaster Button Operations
            /// </summary>
            public ICommand DeleteGenericMasterCmd { get { return _deleteGenericMasterCmd; } }
  
            /// <summary>
            /// Gets the ResetGenericMasterCmd. Used for Reset GenericMaster Button Operations
            /// </summary>
            public ICommand ResetGenericMasterCmd { get { return _resetGenericMasterCmd; } }
  
            /// <summary>
            /// Gets the SearchGenericMasterCmd. Used for Search GenericMaster Button Operations
            /// </summary>
            public ICommand SearchGenericMasterCmd { get { return _searchGenericMasterCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objGenericMaster.GenericCode > 0)
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save GenericMaster?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objGenericMaster.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objGenericMaster.GenericCode > 0)
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objGenericMaster.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objGenericMaster.Search > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objGenericMaster.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objGenericMaster.GenericCode > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete GenericMaster data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objGenericMaster.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
