 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using TextileAppModel;
 using System.Windows;
using System.Collections.ObjectModel;
    
namespace TextileApp.ViewModels
{    
    public class MstAccountMasterViewModels : MstAccountMasterM
    {
        #region Private Variables
            private readonly ICommand _addMstAccountMasterCmd;
            private readonly ICommand _deleteMstAccountMasterCmd;
            private readonly ICommand _resetMstAccountMasterCmd;
            private readonly ICommand _searchMstAccountMasterCmd;
            private readonly ObservableCollection<AutoCompleteTextBoxData> _autoCompleteTextBoxData = new ObservableCollection<AutoCompleteTextBoxData>();

        #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public MstAccountMasterViewModels()
            {
                objMstAccountMaster        = new MstAccountMasterM();
                _addMstAccountMasterCmd    = new RelayCommand(Add, CanAdd);
                _deleteMstAccountMasterCmd = new RelayCommand(Delete, CanDelete);
                _resetMstAccountMasterCmd = new RelayCommand(Reset, CanReset);
                _searchMstAccountMasterCmd = new RelayCommand(Search, CanSearch);

                T_MstGroup t_MstGroup = new T_MstGroup();

                List<T_MstGroup> listT_MstGroup = BLL.BllClient.objBllClient.GetList<T_MstGroup>(Common.DataSourceTypes.T_MstGroupList, t_MstGroup);
                t_MstGroup.GroupId = 1;
                t_MstGroup.GroupCode = "001";
                t_MstGroup.Description = "One";
                listT_MstGroup.Add(t_MstGroup);

                t_MstGroup.GroupId = 2;
                t_MstGroup.GroupCode = "002";
                t_MstGroup.Description = "Two";
                listT_MstGroup.Add(t_MstGroup);

                t_MstGroup.GroupId = 3;
                t_MstGroup.GroupCode = "003";
                t_MstGroup.Description = "Three";
                listT_MstGroup.Add(t_MstGroup);

                foreach (T_MstGroup item in listT_MstGroup)
                {
                    AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                    atd.Text = item.Description;
                    atd.Value = item.GroupCode;
                    _autoCompleteTextBoxData.Add(atd);
                }
            }
        #endregion
  
        #region Property
            public MstAccountMasterM objMstAccountMaster { get; set; }

            public ObservableCollection<AutoCompleteTextBoxData> listAutoCompleteTextBoxData { get { return _autoCompleteTextBoxData; } }
        #endregion Property
  
        #region Command
            /// <summary>
            /// Gets the AddMstAccountMasterCommand. Used for Add MstAccountMaster Button Operations
            /// </summary>
            public ICommand AddMstAccountMasterCmd { get { return _addMstAccountMasterCmd; } }
  
            /// <summary>
            /// Gets the DeleteMstAccountMasterCmd. Used for Delete MstAccountMaster Button Operations
            /// </summary>
            public ICommand DeleteMstAccountMasterCmd { get { return _deleteMstAccountMasterCmd; } }
  
            /// <summary>
            /// Gets the ResetMstAccountMasterCmd. Used for Reset MstAccountMaster Button Operations
            /// </summary>
            public ICommand ResetMstAccountMasterCmd { get { return _resetMstAccountMasterCmd; } }
  
            /// <summary>
            /// Gets the SearchMstAccountMasterCmd. Used for Search MstAccountMaster Button Operations
            /// </summary>
            public ICommand SearchMstAccountMasterCmd { get { return _searchMstAccountMasterCmd; } }
        #endregion
  
        #region Commands
            #region AddCommand
                public bool CanAdd(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objMstAccountMaster.AccountCode > 0)
                    //    return true;
                    //return false;
                    return true;
                }
  
                public void Add(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to save MstAccountMaster?",  "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes){
                        MessageBox.Show(objMstAccountMaster.SaveData());  
                    }
                }
            #endregion
  
            #region Reset Command
                public bool CanReset(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objMstAccountMaster.AccountCode > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Reset(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstAccountMaster.ResetData();
                    }
                }
            #endregion
  
            #region Search Command
                public bool CanSearch(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objMstAccountMaster.SearchAccountCode > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Search(object obj)
                {
                    objMstAccountMaster.SearchData();
                }
            #endregion
  
            #region Delete Command
                public bool CanDelete(object obj)
                {
                    //Enable the Button only if the mandatory fields are filled
                    //if (objMstAccountMaster.AccountCode > 0)
                    //    return true;
                    //return false;
                    return true;
                }
 
             public void Delete(object obj)
                {
                    if (MessageBox.Show("Are you sure, you want to delete MstAccountMaster data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        objMstAccountMaster.DeleteData();
                    }
                }
            #endregion
  
        #endregion
    }
}
