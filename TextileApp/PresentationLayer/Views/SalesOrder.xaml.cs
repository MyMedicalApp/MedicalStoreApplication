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
    /// Interaction logic for SalesOrder.xaml
    /// </summary>
    public partial class SalesOrder : Window
    {
        public SalesOrder()
        {
            InitializeComponent();
            txtDate.SelectedDate = DateTime.Now;

            TranSalesOrderViewModels tranSalesOrderViewModels = new TranSalesOrderViewModels();
            this.cmbAccountName.AutoSuggestionList = tranSalesOrderViewModels.listCombBoxDataParty;
            this.cmbBroker.AutoSuggestionList = tranSalesOrderViewModels.listCombBoxDataBroker;
            this.cmbQuality.AutoSuggestionList = tranSalesOrderViewModels.listCombBoxDataQuality;
            this.cmbViewer.AutoSuggestionList = tranSalesOrderViewModels.listCombBoxDataViewer;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //ganti enter dengan tab
            if (e.Key == Key.Enter)
            {
                // System.Windows.Forms.MessageBox.Show(e.Source.GetType().ToString(),"Warning");
                if (Keyboard.FocusedElement is FrameworkElement)
                {
                    e.Handled = true;
                    (Keyboard.FocusedElement as FrameworkElement).MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                }
            }
        }
    }
}
