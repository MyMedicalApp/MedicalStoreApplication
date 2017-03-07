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
using TextileApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TextileApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<TestData> items = new List<TestData>();
        public ObservableCollection<TestData> items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            items = new ObservableCollection<TestData>();
            //this.DataContext = new MainWindowViewModel();

            MainArea.Width = SystemParameters.MaximizedPrimaryScreenWidth - 28;
            MainArea.Height = SystemParameters.MaximizedPrimaryScreenHeight - 100;
            TestData td = new TestData();
            td.ProductName = "";
            td.ExpiryDate = "";
            td.Qty = 0;

            items.Add(td);
            //items.Add(new TestData() { ProductName = "Abbott", ExpiryDate = "03/18", Qty = 2 });
            //items.Add(new TestData() { ProductName = "Sys", ExpiryDate = "03/18", Qty = 3 });
            AcountsGridView.ItemsSource = items;

        }

        private void AccountMasterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow accountWindow = new AccountWindow();            
            accountWindow.ShowDialog();
            accountWindow.txtAccountCode.Focus();
        }

        public class TestData : INotifyPropertyChanged
        {
            private string productName;
            public string ProductName
            {
                get { return productName; }
                set
                {
                    productName = value;
                    OnPropertyChanged("ProductName");
                }
            }
            private string expiryDate;
            public string ExpiryDate
            {
                get { return expiryDate; }
                set
                {
                    expiryDate = value;
                    OnPropertyChanged("ExpiryDate");
                }
            }
            private int qty;
            public int Qty
            {
                get { return qty; }
                set
                {
                    qty = value;
                    OnPropertyChanged("Qty");
                }
            }

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

        #region "Masters"
            private void BrokerMenuItem_Click(object sender, RoutedEventArgs e)
            {
                BrokerDetail brokerDetail = new BrokerDetail();            
                brokerDetail.ShowDialog();
            }

            private void TransportMenuItem_Click(object sender, RoutedEventArgs e)
            {
                MstTransport objMstTransport = new MstTransport();
                objMstTransport.ShowDialog();
            }

            private void QuantityMenuItem_Click(object sender, RoutedEventArgs e)
            {
                MstQuality objMstQuality = new MstQuality();
                objMstQuality.ShowDialog();
            }

            private void ViewerMenuItem_Click(object sender, RoutedEventArgs e)
            {
                MstWeaver objMstWeaver = new MstWeaver();
                objMstWeaver.ShowDialog();
            }

            private void CheckerMenuItem_Click(object sender, RoutedEventArgs e)
            {
                MstChecker objMstChecker = new MstChecker();
                objMstChecker.ShowDialog();
            }

            private void CompanyMenuItem_Click(object sender, RoutedEventArgs e)
            {
                MstCompany MstCompanyDetail = new MstCompany();
                MstCompanyDetail.ShowDialog();
            }
        #endregion "Masters"

        #region "Transaction"
        private void SalesOrderMenuItem_Click(object sender, RoutedEventArgs e)
            {
                SalesOrder salesOrder = new SalesOrder();
                salesOrder.ShowDialog();
            }

            private void PurchaseOrderMenuItem_Click(object sender, RoutedEventArgs e)
            {
                PurchaseOrder purchaseOrder = new PurchaseOrder();
                purchaseOrder.ShowDialog();
            }

            private void CashMenuItem_Click(object sender, RoutedEventArgs e)
            {
                Cash cash = new Cash();
                cash.ShowDialog();
            }

            private void JournalMenuItem_Click(object sender, RoutedEventArgs e)
            {
                Journal journal = new Journal();
                journal.ShowDialog();
            }
        #endregion "Transaction"

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtGroup_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtQty_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TestData td = new TestData();
                td.ProductName = "";
                td.ExpiryDate = "";
                td.Qty = 0;

                items.Add(td);                
            }
        }
    }
}
