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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Collections.ObjectModel;
using TextileApp.Views;
using MedicalApp.ViewModels;
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

namespace MedicalApp.Views
{
    /// <summary>
    /// Interaction logic for SalesBill.xaml
    /// </summary>
    public partial class SalesBill : Page
    {
        public ObservableCollection<TestData> items { get; set; }

        public SalesBill()
        {
            InitializeComponent();
            //SalesBillViewmodel m = new SalesBillViewmodel();
            SalesBillViewModel salesBillViewModel = new SalesBillViewModel();

            items = new ObservableCollection<TestData>();
            
             
            SalesBillGrid.ItemsSource = items;
            SalesBillGrid.BeginEdit();
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
            private string batchNo;
            public string BatchNo
            {
                get { return batchNo; }
                set
                {
                    batchNo = value;
                    OnPropertyChanged("BatchNo");
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

        private void SalesBillGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //just accept enter key
            if (e.Key != Key.Enter) return;
            if ((((System.Windows.Controls.DataGrid)(sender)).CurrentColumn).Header.ToString() == "Product")
            {                
                BatchNumber batchNumber = new BatchNumber();
                batchNumber.ShowDialog();
            }
           
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
                SalesBillGrid.CancelEdit();
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
                SalesBillGrid.CurrentCell = new DataGridCellInfo(nextCell as DataGridCell);
                //change selected cell
                (nextCell as DataGridCell).IsSelected = true;
                // start edit mode
                SalesBillGrid.BeginEdit();
                if ((((System.Windows.Controls.DataGrid)(sender)).CurrentColumn).Header.ToString() == "P Qty")
                {
                    SalesBillGrid.BeginEdit();
                    return;
                }
            }
            //handl the default action of keydown
            e.Handled = true;
        }

        private void SalesBillGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                 SalesBillGrid.BeginEdit();
            }
        }
    }
}
