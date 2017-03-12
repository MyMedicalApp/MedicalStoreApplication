using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TextileAppModel;
using System.Windows;
using System.ComponentModel;

namespace TextileApp.ViewModels
{
    public class MstCompanyViewModels : INotifyPropertyChanged
    {
        #region Private Variables
        private readonly ICommand _addMstCompanyCmd;
        private readonly ICommand _deleteMstCompanyCmd;
        private readonly ICommand _resetMstCompanyCmd;
        private readonly ICommand _searchMstCompanyCmd;
        #endregion

        #region Constructors
        /// <summary>
        /// Instatiates all the readonly variables
        /// </summary>
        public MstCompanyViewModels()
        {
            objMstCompany = new MstCompanyM();
            _addMstCompanyCmd = new RelayCommand(Add, CanAdd);
            _deleteMstCompanyCmd = new RelayCommand(Delete, CanDelete);
            _resetMstCompanyCmd = new RelayCommand(Reset, CanReset);
            _searchMstCompanyCmd = new RelayCommand(Search, CanSearch);

            listFY = BLL.BllClient.objBllClient.GetList<T_MstFinancialYear>(Common.DataSourceTypes.T_MstFinancialYearList, new T_MstFinancialYear());                
        }
        #endregion

        #region Property
        public MstCompanyM objMstCompany { get; set; }
        public List<T_MstFinancialYear> listFY { get; set; }

        T_MstFinancialYear objSelectedFY;
        public T_MstFinancialYear SelectedFY
        {
            get { return objSelectedFY; }
            set
            {
                objSelectedFY = value;
                OnPropertyChanged("SelectedFY");
                objMstCompany.FinancialYearId = objSelectedFY.FinancialYearId;
            }
        }

        #endregion Property

        #region Command
        /// <summary>
        /// Gets the AddMstCompanyCommand. Used for Add MstCompany Button Operations
        /// </summary>
        public ICommand AddMstCompanyCmd { get { return _addMstCompanyCmd; } }

        /// <summary>
        /// Gets the DeleteMstCompanyCmd. Used for Delete MstCompany Button Operations
        /// </summary>
        public ICommand DeleteMstCompanyCmd { get { return _deleteMstCompanyCmd; } }

        /// <summary>
        /// Gets the ResetMstCompanyCmd. Used for Reset MstCompany Button Operations
        /// </summary>
        public ICommand ResetMstCompanyCmd { get { return _resetMstCompanyCmd; } }

        /// <summary>
        /// Gets the SearchMstCompanyCmd. Used for Search MstCompany Button Operations
        /// </summary>
        public ICommand SearchMstCompanyCmd { get { return _searchMstCompanyCmd; } }
        #endregion

        #region Commands
        #region AddCommand
        public bool CanAdd(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            if (objMstCompany.CompanyId > 0 && !string.IsNullOrEmpty(objMstCompany.CompanyName))
                return true;
            return false;
        }

        public void Add(object obj)
        {
            if (MessageBox.Show("Are you sure, you want to save MstCompany?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show(objMstCompany.SaveData());
            }
        }
        #endregion

        #region Reset Command
        public bool CanReset(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            if (objMstCompany.CompanyId > 0 && !string.IsNullOrEmpty(objMstCompany.CompanyName))
                return true;
            return false;
        }

        public void Reset(object obj)
        {
            if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                objMstCompany.ResetData();
            }
        }
        #endregion

        #region Search Command
        public bool CanSearch(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            if (objMstCompany.SearchCompanyId > 0)
                return true;
            return false;
        }

        public void Search(object obj)
        {
            objMstCompany.SearchData();
        }
        #endregion

        #region Delete Command
        public bool CanDelete(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            if (objMstCompany.CompanyId > 0 && !string.IsNullOrEmpty(objMstCompany.CompanyName))
                return true;
            return false;
        }

        public void Delete(object obj)
        {
            if (MessageBox.Show("Are you sure, you want to delete MstCompany data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                objMstCompany.DeleteData();
            }
        }
        #endregion

        #endregion

        #region INotifyPropertyChanged Members
            /// <summary>
            /// Event to which the view's controls will subscribe.
            /// This will enable them to refresh themselves when the binded property changes provided you fire this event.
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// When property is changed call this method to fire the PropertyChanged Event
            /// </summary>
            /// <param name="propertyName"></param>
            public void OnPropertyChanged(string propertyName)
            {
                //Fire the PropertyChanged event in case somebody subscribed to it
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        #endregion
    }
}
