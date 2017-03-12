 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstQualityViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstQualityCmd;
            private readonly ICommand _deleteMstQualityCmd;
            private readonly ICommand _resetMstQualityCmd;
            private readonly ICommand _searchMstQualityCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstQualityViewModels()
            {
                objMstQuality        = new MstQualityM();
                _addMstQualityCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstQualityCmd = new RelayCommand(Delete, CanDelete);
                _resetMstQualityCmd = new RelayCommand(Reset, CanReset);
                _searchMstQualityCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstQualityM objMstQuality { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstQualityCommand. Used for Add MstQuality Button Operations
            /// </summary>
            public ICommand AddMstQualityCmd { get { return _addMstQualityCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstQualityCmd. Used for Delete MstQuality Button Operations
            /// </summary>
            public ICommand DeleteMstQualityCmd { get { return _deleteMstQualityCmd; } }
  
            /// <summary>
            /// Gets the ResetMstQualityCmd. Used for Reset MstQuality Button Operations
            /// </summary>
            public ICommand ResetMstQualityCmd { get { return _resetMstQualityCmd; } }
  
            /// <summary>
            /// Gets the SearchMstQualityCmd. Used for Search MstQuality Button Operations
            /// </summary>
            public ICommand SearchMstQualityCmd { get { return _searchMstQualityCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstQuality.QualityCode > 0 && !string.IsNullOrEmpty(objMstQuality.QualityName))
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstQuality?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstQuality.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstQuality.QualityCode > 0 && !string.IsNullOrEmpty(objMstQuality.QualityName))
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstQuality.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstQuality.SearchQualityCode > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstQuality.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstQuality.QualityCode > 0 && !string.IsNullOrEmpty(objMstQuality.QualityName))
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstQuality data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstQuality.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
