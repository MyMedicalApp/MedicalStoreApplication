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
    public class DoctorMasterViewModels
    {
        #region Private Variables
            private readonly ICommand _addDoctorMasterCmd;
            private readonly ICommand _deleteDoctorMasterCmd;
            private readonly ICommand _resetDoctorMasterCmd;
            private readonly ICommand _searchDoctorMasterCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public DoctorMasterViewModels()
            {
                objDoctorMaster        = new DoctorMasterM();
                _addDoctorMasterCmd    = new RelayCommand(Add, CanAdd);
                _deleteDoctorMasterCmd = new RelayCommand(Delete, CanDelete);
                _resetDoctorMasterCmd = new RelayCommand(Reset, CanReset);
                _searchDoctorMasterCmd = new RelayCommand(Search, CanSearch);
   
            }
        #endregion
  
        #region Property
            public DoctorMasterM objDoctorMaster { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddDoctorMasterCommand. Used for Add DoctorMaster Button Operations
            /// </summary>
            public ICommand AddDoctorMasterCmd { get { return _addDoctorMasterCmd; } }
  
            /// <summary>
            /// Gets the DeleteDoctorMasterCmd. Used for Delete DoctorMaster Button Operations
            /// </summary>
            public ICommand DeleteDoctorMasterCmd { get { return _deleteDoctorMasterCmd; } }
  
            /// <summary>
            /// Gets the ResetDoctorMasterCmd. Used for Reset DoctorMaster Button Operations
            /// </summary>
            public ICommand ResetDoctorMasterCmd { get { return _resetDoctorMasterCmd; } }
  
            /// <summary>
            /// Gets the SearchDoctorMasterCmd. Used for Search DoctorMaster Button Operations
            /// </summary>
            public ICommand SearchDoctorMasterCmd { get { return _searchDoctorMasterCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objDoctorMaster.DoctorCode > 0)
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save DoctorMaster?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objDoctorMaster.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objDoctorMaster.DoctorCode > 0)
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objDoctorMaster.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objDoctorMaster.DoctorCode > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objDoctorMaster.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objDoctorMaster.DoctorCode > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete DoctorMaster data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objDoctorMaster.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
