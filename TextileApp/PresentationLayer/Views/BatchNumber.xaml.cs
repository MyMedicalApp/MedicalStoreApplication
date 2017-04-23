using MedicalApp.Model;
using MedicalApp.ViewModels;
using MedicalApp.Views;
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

namespace TextileApp.Views
{
    /// <summary>
    /// Interaction logic for BatchNumber.xaml
    /// </summary>
    public partial class BatchNumber : Window
    {
        System.Windows.Input.KeyEventArgs row;
        public BatchNumber(System.Windows.Input.KeyEventArgs e)
        {
            InitializeComponent();
            BatchMasterViewModel batchMasterViewModel = new BatchMasterViewModel();
            this.DataContext = batchMasterViewModel;
            this.BatchNumberGridView.Focus();
            row = e;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void BatchNumberGridView_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
            //BatchMaster batchMaster = (BatchMaster)BatchNumberGridView.SelectedItem;
            //SalesBill sb = new SalesBill();
            //sb.txtPacking.Text = "1 G";
            //sb.lbl.Content = "tt";
            //sb.txtCompany.Text = batchMaster.AccountCode.ToString();
            //sb.txtMRP.Text = batchMaster.MRP.ToString();
            //sb.txtBatchNo.Text = batchMaster.BatchNo;
            //sb.txtExpiryDate.Text = batchMaster.Expiry.ToString();
        }
    }
}
