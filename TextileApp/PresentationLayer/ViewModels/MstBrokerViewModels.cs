 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstBrokerViewModels : MstBrokerM
    {
        #region Private Variables
            private readonly ICommand _addMstBrokerCmd;
            private readonly ICommand _deleteMstBrokerCmd;
            private readonly ICommand _resetMstBrokerCmd;
            private readonly ICommand _searchMstBrokerCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstBrokerViewModels()
            {
                objMstBroker        = new MstBrokerM();
                _addMstBrokerCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstBrokerCmd = new RelayCommand(Delete, CanDelete);
                _resetMstBrokerCmd = new RelayCommand(Reset, CanReset);
                _searchMstBrokerCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstBrokerM objMstBroker { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstBrokerCommand. Used for Add MstBroker Button Operations
            /// </summary>
            public ICommand AddMstBrokerCmd { get { return _addMstBrokerCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstBrokerCmd. Used for Delete MstBroker Button Operations
            /// </summary>
            public ICommand DeleteMstBrokerCmd { get { return _deleteMstBrokerCmd; } }
  
            /// <summary>
            /// Gets the ResetMstBrokerCmd. Used for Reset MstBroker Button Operations
            /// </summary>
            public ICommand ResetMstBrokerCmd { get { return _resetMstBrokerCmd; } }
  
            /// <summary>
            /// Gets the SearchMstBrokerCmd. Used for Search MstBroker Button Operations
            /// </summary>
            public ICommand SearchMstBrokerCmd { get { return _searchMstBrokerCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstBroker.BrokerCode > 0 && !string.IsNullOrEmpty(objMstBroker.BrokerName))
                        return true;
                    return false;                    
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstBroker?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstBroker.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstBroker.BrokerCode > 0 && !string.IsNullOrEmpty(objMstBroker.BrokerName))
                        return true;
                    return false; 
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstBroker.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objMstBroker.SearchBrokerCode > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Search(object obj)
                {
                    objMstBroker.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstBroker.BrokerCode > 0 && !string.IsNullOrEmpty(objMstBroker.BrokerName))
                        return true;
                    return false; 
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstBroker data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstBroker.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
