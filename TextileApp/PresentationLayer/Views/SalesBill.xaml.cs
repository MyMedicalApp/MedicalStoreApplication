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
using MedicalApp.Model;
using System.Windows.Threading;
using MedicalApp.UserControls;

namespace MedicalApp.Views
{
    /// <summary>
    /// Interaction logic for SalesBill.xaml
    /// </summary>
    public partial class SalesBill : Page
    {
        public ObservableCollection<TestData> items { get; set; }
        SalesBillViewModel salesBillViewModel = new SalesBillViewModel();
        BatchMasterViewModel batchMasterViewModel = new BatchMasterViewModel();
        public SalesBill(BatchMaster batchMaster)
        {
            //InitializeComponent();
            
            //txtPacking.Text = "1 G";
            //lbl.Content = "tt";
            //txtCompany.Text = batchMaster.AccountCode.ToString();
            //txtMRP.Text = batchMaster.MRP.ToString();
            //txtBatchNo.Text = batchMaster.BatchNo;
            //txtExpiryDate.Text = batchMaster.Expiry.ToString();
        }
        public SalesBill()
        {
            InitializeComponent();
            //SalesBillViewmodel m = new SalesBillViewmodel();
           
            //this.DataContext =  new SalesBillViewModel();
            //items = new ObservableCollection<TestData>();
            
             
            //SalesBillGrid.ItemsSource = items;
            //SalesBillGrid.BeginEdit();
            //SalesGridView.ItemsSource = items;

            //salesBillViewModel.objSalesBillM.ListSalesBillModel = new ObservableCollection<SalesBillModel>();
            //dtpBillDate.SelectedDate = DateTime.Today;
            txtProducts.AutoSuggestionList = salesBillViewModel.objProductMaster.AutoSuggestionList;
            txtCutomerName.Focus();
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

        //private void SalesBillGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    //just accept enter key
        //    if (e.Key != Key.Enter) return;
        //    if ((((System.Windows.Controls.DataGrid)(sender)).CurrentColumn).Header.ToString() == "Product")
        //    {                
        //        //BatchNumber batchNumber = new BatchNumber();
        //        //batchNumber.ShowDialog();
        //    }
           
        //    DependencyObject dep = (DependencyObject)e.OriginalSource;
        //    //here we just find the cell got focused ...
        //    //then we can use the cell key down or key up
        //    // iteratively traverse the visual tree
        //    while ((dep != null) && !(dep is DataGridCell) && !(dep is DataGridColumnHeader))
        //    {
        //        dep = VisualTreeHelper.GetParent(dep);
        //    }

        //    if (dep == null)
        //        return;

        //    if (dep is DataGridCell)
        //    {
        //        //cancel if datagrid in edit mode
        //        SalesBillGrid.CancelEdit();
        //        //get current cell
        //        DataGridCell cell = dep as DataGridCell;
        //        //deselect current cell
        //        cell.IsSelected = false;
        //        //find next right cell
        //        var nextCell = cell.PredictFocus(FocusNavigationDirection.Right);
        //        //if next right cell null go for find next ro first cell
        //        if (nextCell == null)
        //        {
        //            DependencyObject nextRowCell;
        //            nextRowCell = cell.PredictFocus(FocusNavigationDirection.Down);
        //            //if next row is null so we have no more row Return;
        //            if (nextRowCell == null) return;
        //            //we do this because we cant use FocusNavigationDirection.Next for function PredictFocus
        //            //so we have to find it this way
        //            while ((nextRowCell as DataGridCell).PredictFocus(FocusNavigationDirection.Left) != null)
        //                nextRowCell = (nextRowCell as DataGridCell).PredictFocus(FocusNavigationDirection.Left);
        //            //set new cell as next cell
        //            nextCell = nextRowCell;
        //        }
        //        //change current cell
        //        SalesBillGrid.CurrentCell = new DataGridCellInfo(nextCell as DataGridCell);
        //        //change selected cell
        //        (nextCell as DataGridCell).IsSelected = true;
        //        // start edit mode
        //        SalesBillGrid.BeginEdit();
        //        if ((((System.Windows.Controls.DataGrid)(sender)).CurrentColumn).Header.ToString() == "P Qty")
        //        {
        //            SalesBillGrid.BeginEdit();
        //            return;
        //        }
        //    }
        //    //handl the default action of keydown
        //    e.Handled = true;
        //}

        //private void SalesBillGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        //{
        //    if (e.EditAction == DataGridEditAction.Commit)
        //    {
        //         SalesBillGrid.BeginEdit();
        //    }
        //}

        private void txtGroup_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SalesBillViewModel.pName = ((MedicalApp.UserControls.AutoCompleteEntry)(txtProducts.SelectedValue)).Text;

                batchMasterViewModel.objBatchMaster.BatchMasterListByProductCode(((MedicalApp.UserControls.AutoCompleteEntry)(txtProducts.SelectedValue)).Value);

                BatchNumberGridView.ItemsSource = batchMasterViewModel.objBatchMaster.ListBatchMaster;
                BatchNumberGridView.SelectedIndex = 0;
                BatchNumberGridView.Focus();
                BatchNumberGridView.ScrollIntoView(BatchNumberGridView.SelectedIndex);
                
                //SalesBillModel sbm = new SalesBillModel();
                //salesBillViewModel.objSalesBillM.ListSalesBillModel[0].MRP = 120;
                //SalesGridView.ItemsSource = salesBillViewModel.objSalesBillM.ListSalesBillModel;
                //BatchNumber batchNumber = new BatchNumber(e);
                //batchNumber.Owner = Window.GetWindow(this);
                //batchNumber.ShowDialog();
            }
        }
        public void SetFocus(System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
            var uiElement = e.OriginalSource as UIElement;
            e.Handled = true;
            uiElement.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
            else if (e.Key == Key.Escape)
            {
                var uiElement = e.OriginalSource as UIElement;
                e.Handled = true;
                uiElement.MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
            }
        }

        private void txtDoctorAddress_KeyDown(object sender, KeyEventArgs e)
        {
            SetFocus(e);
        }

        private void txtCutomerName_KeyDown(object sender, KeyEventArgs e)
        {
            SetFocus(e);
        }

        private void txtCutomerAddress_KeyDown(object sender, KeyEventArgs e)
        {
            SetFocus(e);
        }

        private void txtDoctorName_KeyDown(object sender, KeyEventArgs e)
        {
            SetFocus(e);
        }

        private void SalesGridView_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SetFocus(e);
            }
            if (e.Key == Key.Delete && (Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
            {
                var messageBoxResult = TextileApp.PresentationLayer.UserControls.WpfMessageBox.Show("Confirmation", "Are you sure youwant to delete selected item ?",
                                        MessageBoxButton.YesNo,
                                       TextileApp.PresentationLayer.UserControls.WpfMessageBox.MessageBoxImage.Question);

                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    salesBillViewModel.RemoveRow((SalesBillModel)SalesGridView.SelectedItem);
                }
            }
        }

        private void BatchNumberGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {   
                //SetFocus(e);
                txtPQty.Focus();
                txtPQty.Text = "1";
                //txtPQty.SelectionStart = txtPQty.Text.Length;
                txtPQty.Select(0, txtPQty.Text.Length);
            }
        }

        private void txtPQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SalesBillModel sbm = new SalesBillModel();

                sbm.ProductName = txtProducts.Text;
                BatchMaster batchMaster = (BatchMaster)BatchNumberGridView.SelectedItem;
                sbm.BatchNo = batchMaster.BatchNo;
                sbm.Expiry = batchMaster.Expiry;
                sbm.MRP = batchMaster.MRP;
                sbm.Qty = Convert.ToDecimal(txtPQty.Text);
                salesBillViewModel.AddNewRow(sbm);
                SalesGridView.ItemsSource = salesBillViewModel.objSalesBillM.ListSalesBillModel;
                txtProducts.Text = "@";
                txtPQty.Text = "";
                txtTotalQty.Text = SalesBillViewModel.TotalQty.ToString();
                txtTotalAmount.Text = SalesBillViewModel.TotalAmount.ToString("0.00");
                batchMasterViewModel.objBatchMaster.BatchMasterListByProductCode("-1");
                BatchNumberGridView.ItemsSource = batchMasterViewModel.objBatchMaster.ListBatchMaster;
                BatchNumberGridView.SelectedIndex = 0;
                txtProducts.Focus();
                
                SalesGridView.SelectedIndex = salesBillViewModel.objSalesBillM.ListSalesBillModel.Count;
                //txtProducts.selections

                //salesBillViewModel.CurrentRow.BatchNo = batchMaster.BatchNo;
                //salesBillViewModel.CurrentRow.BatchNo = batchMaster.BatchNo;
                //salesBillViewModel.CurrentRow.BatchNo = batchMaster.BatchNo;
                //salesBillViewModel.CurrentRow.BatchNo = batchMaster.BatchNo;
            }
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                SalesGridView.Focus();
                SalesGridView.SelectedIndex = 0;
            }
            if (e.Key == Key.Escape)
            {
                SetFocus(e);
            }
        }

    }
}
