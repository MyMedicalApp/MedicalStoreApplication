using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TextileAppModel;
using System.Windows;
using System.Collections.ObjectModel;
using TextileApp.UserControls;

namespace TextileApp.ViewModels
{
    public class TranJournalViewModels : TranJournalM
    {
        #region Private Variables
        private readonly ICommand _addTranJournalCmd;
        private readonly ICommand _deleteTranJournalCmd;
        private readonly ICommand _resetTranJournalCmd;
        private readonly ICommand _searchTranJournalCmd;
        private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataCreditParty = new ObservableCollection<AutoCompleteTextBoxData>();

        private readonly ObservableCollection<AutoCompleteTextBoxData> _combBoxDataDebitParty = new ObservableCollection<AutoCompleteTextBoxData>();

        #endregion

        #region Constructors
        /// <summary>
        /// Instatiates all the readonly variables
        /// </summary>
        public TranJournalViewModels()
        {
            objTranJournal = new TranJournalM();
            _addTranJournalCmd = new RelayCommand(Add, CanAdd);
            _deleteTranJournalCmd = new RelayCommand(Delete, CanDelete);
            _resetTranJournalCmd = new RelayCommand(Reset, CanReset);
            _searchTranJournalCmd = new RelayCommand(Search, CanSearch);

            T_MstAccountMaster t_MstAccountMaster = new T_MstAccountMaster();
            List<T_MstAccountMaster> listT_MstAccountMaster = BLL.BllClient.objBllClient.GetList<T_MstAccountMaster>(Common.DataSourceTypes.T_MstAccountMasterList, t_MstAccountMaster);
            foreach (T_MstAccountMaster item in listT_MstAccountMaster)
            {
                AutoCompleteTextBoxData atd = new AutoCompleteTextBoxData();
                atd.Text = item.AccountName;
                atd.Value = Convert.ToString(item.AccountCode);
                _combBoxDataCreditParty.Add(atd);
                _combBoxDataDebitParty.Add(atd);
            }
        }
        #endregion

        #region Property
        public TranJournalM objTranJournal { get; set; }

        public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataCreditParty { get { return _combBoxDataCreditParty; } }
        public ObservableCollection<AutoCompleteTextBoxData> listCombBoxDataDebitParty { get { return _combBoxDataDebitParty; } }
            
        #endregion Property

        #region Command
        /// <summary>
        /// Gets the AddTranJournalCommand. Used for Add TranJournal Button Operations
        /// </summary>
        public ICommand AddTranJournalCmd { get { return _addTranJournalCmd; } }

        /// <summary>
        /// Gets the DeleteTranJournalCmd. Used for Delete TranJournal Button Operations
        /// </summary>
        public ICommand DeleteTranJournalCmd { get { return _deleteTranJournalCmd; } }

        /// <summary>
        /// Gets the ResetTranJournalCmd. Used for Reset TranJournal Button Operations
        /// </summary>
        public ICommand ResetTranJournalCmd { get { return _resetTranJournalCmd; } }

        /// <summary>
        /// Gets the SearchTranJournalCmd. Used for Search TranJournal Button Operations
        /// </summary>
        public ICommand SearchTranJournalCmd { get { return _searchTranJournalCmd; } }
        #endregion

        #region Commands
        #region AddCommand
        public bool CanAdd(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            //if (objTranJournal.TranJournalId > 0)
            //    return true;
            //return false;
            return true;
        }

        public void Add(object obj)
        {
            if (MessageBox.Show("Are you sure, you want to save TranJournal?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                AutoCompleteTextBox autoCompleteTextBoxC = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                AutoCompleteTextBox autoCompleteTextBoxD = App.Current.Windows[1].FindName("cmbAccountNameCr") as AutoCompleteTextBox;
                
                objTranJournal.CreditPartyId = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxC.SelectedItem)).Value);
                objTranJournal.DebitPartyId = Convert.ToInt32(((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxD.SelectedItem)).Value);

                objTranJournal.CreditAccountName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxC.SelectedItem)).Text;
                objTranJournal.DebitAccountName = ((TextileApp.UserControls.AutoCompleteEntry)(autoCompleteTextBoxD.SelectedItem)).Text;

                MessageBox.Show(objTranJournal.SaveData());

                autoCompleteTextBoxC.Text = string.Empty;
                autoCompleteTextBoxD.Text = string.Empty;                        
            }
        }
        #endregion

        #region Reset Command
        public bool CanReset(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            //if (objTranJournal.TranJournalId > 0)
            //    return true;
            //return false;
            return true;
        }

        public void Reset(object obj)
        {
            if (MessageBox.Show("Are you sure, you want to reset data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                objTranJournal.ResetData();

                AutoCompleteTextBox autoCompleteTextBoxC = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
                AutoCompleteTextBox autoCompleteTextBoxD = App.Current.Windows[1].FindName("cmbAccountNameCr") as AutoCompleteTextBox;

                autoCompleteTextBoxC.Text = string.Empty;
                autoCompleteTextBoxD.Text = string.Empty;
                        
            }
        }
        #endregion

        #region Search Command
        public bool CanSearch(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            //if (objTranJournal.SearchTranJournalId > 0)
            //    return true;
            //return false;
            return true;
        }

        public void Search(object obj)
        {
            objTranJournal.SearchData();

            AutoCompleteTextBox autoCompleteTextBoxC = App.Current.Windows[1].FindName("cmbAccountName") as AutoCompleteTextBox;
            AutoCompleteTextBox autoCompleteTextBoxD = App.Current.Windows[1].FindName("cmbAccountNameCr") as AutoCompleteTextBox;

            autoCompleteTextBoxC.Text = objTranJournal.CreditAccountName;
            autoCompleteTextBoxD.Text = objTranJournal.DebitAccountName;
        }
        #endregion

        #region Delete Command
        public bool CanDelete(object obj)
        {
            //Enable the Button only if the mandatory fields are filled
            //if (objTranJournal.TranJournalId > 0)
            //    return true;
            //return false;
            return true;
        }

        public void Delete(object obj)
        {
            if (MessageBox.Show("Are you sure, you want to delete TranJournal data?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                objTranJournal.DeleteData();
            }
        }
        #endregion

        #endregion
    }
}
