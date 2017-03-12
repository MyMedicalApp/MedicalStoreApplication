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
using System.Windows.Controls.Primitives;

namespace TextileApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<TestData> items = new List<TestData>();
        public int Col;
        public int Row;

        public ObservableCollection<TestData> items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            items = new ObservableCollection<TestData>();
            //this.DataContext = new MainWindowViewModel();

            MainArea.Width = SystemParameters.MaximizedPrimaryScreenWidth - 28;
            MainArea.Height = SystemParameters.MaximizedPrimaryScreenHeight - 100;
            TestData td = new TestData();
            td.ProductName = "Test";
            td.ExpiryDate = "12/15";
            td.Qty = 0;
            items.Add(td);
           
            TestData tdata = new TestData();
            tdata.ProductName = "Cipla";
            tdata.ExpiryDate = "12/21";
            tdata.Qty = 2;
            items.Add(tdata);
            SampleGrid.ItemsSource = items;
            
            SampleGrid.BeginEdit();
        }
        private void SampleGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {   
            if (e.EditAction == DataGridEditAction.Commit)
            {
                SampleGrid.BeginEdit();
            }
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
                AcountsGridView.SelectedItem = td;

                this.AcountsGridView.Focus();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((Control)e.Source).MoveFocus(request);
            }
        }

        private void TextBoxInputMaskBehavior_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((Control)e.Source).MoveFocus(request);
            }
        }

        private void maindg_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //just accept enter key
            if (e.Key != Key.Enter) return;

            DependencyObject dep = (DependencyObject)e.OriginalSource;
            //here we just find the cell got focused ...
            //then we can use the cell key down or key up
            // iteratively traverse the visual tree
            while ((dep != null) && !(dep is DataGridCell) && !(dep is DataGridColumnHeader))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return;

            if (dep is DataGridCell)
            {
                //cancel if datagrid in edit mode
                SampleGrid.CancelEdit();
                //get current cell
                DataGridCell cell = dep as DataGridCell;
                //deselect current cell
                cell.IsSelected = false;
                //find next right cell
                var nextCell = cell.PredictFocus(FocusNavigationDirection.Right);
                //if next right cell null go for find next ro first cell
                if (nextCell == null)
                {
                    DependencyObject nextRowCell;
                    nextRowCell = cell.PredictFocus(FocusNavigationDirection.Down);
                    //if next row is null so we have no more row Return;
                    if (nextRowCell == null) return;
                    //we do this because we cant use FocusNavigationDirection.Next for function PredictFocus
                    //so we have to find it this way
                    while ((nextRowCell as DataGridCell).PredictFocus(FocusNavigationDirection.Left) != null)
                        nextRowCell = (nextRowCell as DataGridCell).PredictFocus(FocusNavigationDirection.Left);
                    //set new cell as next cell
                    nextCell = nextRowCell;
                }
                //change current cell
                SampleGrid.CurrentCell = new DataGridCellInfo(nextCell as DataGridCell);
                //change selected cell
                (nextCell as DataGridCell).IsSelected = true;
                // start edit mode
                SampleGrid.BeginEdit();
            }
            //handl the default action of keydown
            e.Handled = true;
        }

    }
}
