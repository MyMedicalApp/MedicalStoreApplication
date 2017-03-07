 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class TranSalesBillViewModels
    {
        #region Private Variables
            private readonly ICommand _addTranSalesBillCmd;
            private readonly ICommand _deleteTranSalesBillCmd;
            private readonly ICommand _resetTranSalesBillCmd;
            private readonly ICommand _searchTranSalesBillCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public TranSalesBillViewModels()
            {
                objTranSalesBill        = new TranSalesBillM();
                _addTranSalesBillCmd    = new RelayCommand(Add, CanAdd);
                _deleteTranSalesBillCmd = new RelayCommand(Delete, CanDelete);
                _resetTranSalesBillCmd = new RelayCommand(Reset, CanReset);
                _searchTranSalesBillCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public TranSalesBillM objTranSalesBill { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddTranSalesBillCommand. Used for Add TranSalesBill Button Operations
            /// </summary>
            public ICommand AddTranSalesBillCmd { get { return _addTranSalesBillCmd; } }
  
            /// <summary>
            /// Gets the DeleteTranSalesBillCmd. Used for Delete TranSalesBill Button Operations
            /// </summary>
            public ICommand DeleteTranSalesBillCmd { get { return _deleteTranSalesBillCmd; } }
  
            /// <summary>
            /// Gets the ResetTranSalesBillCmd. Used for Reset TranSalesBill Button Operations
            /// </summary>
            public ICommand ResetTranSalesBillCmd { get { return _resetTranSalesBillCmd; } }
  
            /// <summary>
            /// Gets the SearchTranSalesBillCmd. Used for Search TranSalesBill Button Operations
            /// </summary>
            public ICommand SearchTranSalesBillCmd { get { return _searchTranSalesBillCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objTranSalesBill.TranSalesBillId > 0)
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save TranSalesBill?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objTranSalesBill.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objTranSalesBill.TranSalesBillId > 0)
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranSalesBill.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objTranSalesBill.SearchTranSalesBillId > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objTranSalesBill.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objTranSalesBill.TranSalesBillId > 0)
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete TranSalesBill data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objTranSalesBill.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
