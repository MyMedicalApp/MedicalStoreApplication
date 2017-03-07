 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
    
namespace TextileApp.ViewModels
{    
    public class MstTransportViewModels
    {
        #region Private Variables
            private readonly ICommand _addMstTransportCmd;
            private readonly ICommand _deleteMstTransportCmd;
            private readonly ICommand _resetMstTransportCmd;
            private readonly ICommand _searchMstTransportCmd;
        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstTransportViewModels()
            {
                objMstTransport        = new MstTransportM();
                _addMstTransportCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstTransportCmd = new RelayCommand(Delete, CanDelete);
                _resetMstTransportCmd = new RelayCommand(Reset, CanReset);
                _searchMstTransportCmd = new RelayCommand(Search, CanSearch);
            }
        #endregion
  
        #region Property
            public MstTransportM objMstTransport { get; set; }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstTransportCommand. Used for Add MstTransport Button Operations
            /// </summary>
            public ICommand AddMstTransportCmd { get { return _addMstTransportCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstTransportCmd. Used for Delete MstTransport Button Operations
            /// </summary>
            public ICommand DeleteMstTransportCmd { get { return _deleteMstTransportCmd; } }
  
            /// <summary>
            /// Gets the ResetMstTransportCmd. Used for Reset MstTransport Button Operations
            /// </summary>
            public ICommand ResetMstTransportCmd { get { return _resetMstTransportCmd; } }
  
            /// <summary>
            /// Gets the SearchMstTransportCmd. Used for Search MstTransport Button Operations
            /// </summary>
            public ICommand SearchMstTransportCmd { get { return _searchMstTransportCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled 
                    if (objMstTransport.TransportCode > 0 && !string.IsNullOrEmpty(objMstTransport.TransportName))
                        return true;
                    return false;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstTransport?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstTransport.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstTransport.TransportCode > 0 && !string.IsNullOrEmpty(objMstTransport.TransportName))
                        return true;
                    return false;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstTransport.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstTransport.SearchTransportCode > 0)
                        return true;
                    return false;
                }
 
             public void Search(object obj)
                {
                    objMstTransport.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    if (objMstTransport.TransportCode > 0 && !string.IsNullOrEmpty(objMstTransport.TransportName))
                        return true;
                    return false;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstTransport data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstTransport.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
