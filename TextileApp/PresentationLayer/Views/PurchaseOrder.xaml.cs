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
    /// Interaction logic for PurchaseOrder.xaml
    /// </summary>
    public partial class PurchaseOrder : Window
    {
        public PurchaseOrder()
        {
            InitializeComponent();

            txtDate.SelectedDate = DateTime.Now;

            TranPurchaseOrderViewModels tranPurchaseOrderViewModels = new TranPurchaseOrderViewModels();

            this.cmbBroker.AutoSuggestionList = tranPurchaseOrderViewModels.listCombBoxDataBroker;
            this.cmbQuality.AutoSuggestionList = tranPurchaseOrderViewModels.listCombBoxDataQuality;
            this.cmbViewer.AutoSuggestionList = tranPurchaseOrderViewModels.listCombBoxDataViewer;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
