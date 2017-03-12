using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TextileApp.ViewModels;

namespace TextileApp.Views
{
    /// <summary>
    /// Interaction logic for Journal.xaml
    /// </summary>
    public partial class Journal : Window
    {
        public Journal()
        {
            InitializeComponent();
            TranJournalViewModels tranJournalViewModels = new TranJournalViewModels();
            this.cmbAccountName.AutoSuggestionList = tranJournalViewModels.listCombBoxDataDebitParty;
            this.cmbAccountNameCr.AutoSuggestionList = tranJournalViewModels.listCombBoxDataCreditParty;
            txtVoucherDate.SelectedDate = DateTime.Now;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
