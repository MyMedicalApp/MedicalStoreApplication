using MedicalApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TextileApp.Models;

namespace MedicalApp.ViewModels
{
    public class SalesBillViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private readonly ICommand _qtyKeyDwonCmd;
        decimal totalamt = 0;
        int totalqty = 0;

        #endregion

        public SalesBillViewModel()
        {
            objProductMaster = new ProductMasterM();
            objSalesBillM = new SalesBillM();
            _qtyKeyDwonCmd = new RelayCommand(AddNewRow, CanAddNewRow);
        }
        public SalesBillViewModel(string parameter)
        {
            objSalesBillM = new SalesBillM();
            objSalesBillM.ListSalesBillModel.Add(new Model.SalesBillModel());
        }

        #region Property
        public SalesBillM objSalesBillM { get; set; }
       
        public ProductMasterM objProductMaster { get; set; }
        
        public static string pName { get; set; }
        public static int TotalQty { get; set; }
        public static decimal TotalAmount { get; set; }
        
        #endregion Property

        #region Command 1
        public ICommand QtyKeyDwonCmd { get { return _qtyKeyDwonCmd; } }
        
        #endregion

        #region Command
        public bool CanAddNewRow(object obj)
        {
            return true;
        }

        public void AddNewRow(object obj)
        {
            SalesBillModel sbm = new SalesBillModel();
            sbm.ProductName = pName;
            
            sbm.BatchNo = selectedBatchNo.BatchNo;
            sbm.Expiry = selectedBatchNo.Expiry;
            sbm.MRP = selectedBatchNo.MRP;
            sbm.Qty = Convert.ToInt32(obj);
            sbm.SrNo = objSalesBillM.ListSalesBillModel.Count() + 1;
            objSalesBillM.ListSalesBillModel.Add(sbm);
            CurrentRow = sbm;
            objProductMaster.TotalQty = objProductMaster.TotalQty + Convert.ToInt32(obj);
            objProductMaster.TotalAmount = objProductMaster.TotalAmount + (sbm.MRP * sbm.Qty);
        }
        public void AddNewRow(SalesBillModel saledBillModel)
        {
            //CurrentRow = saledBillModel;
            //totalamt = totalamt + (saledBillModel.MRP * saledBillModel.Qty);
            //totalqty = totalqty + Convert.ToInt16(saledBillModel.Qty);

            //CurrentRow.TotalAmount = Math.Round(totalamt, 2);
            //CurrentRow.TotalQty = totalqty;

            TotalQty = TotalQty + Convert.ToInt16(saledBillModel.Qty);
            TotalAmount = TotalAmount + (saledBillModel.MRP * saledBillModel.Qty); ;

            saledBillModel.SrNo = objSalesBillM.ListSalesBillModel.Count() + 1;
            objSalesBillM.ListSalesBillModel.Add(saledBillModel);
        }

        #endregion

        ObservableCollection<BatchMaster> listBatchMaster;
        public ObservableCollection<BatchMaster> ListBatchMaster
        {
            get { return listBatchMaster; }
            set
            {
                listBatchMaster = value;
                OnPropertyChanged("ListBatchMaster");
            }
        }

        private BatchMaster selectedBatchNo;
        public BatchMaster SelectedBatchNo
        {
            get { return selectedBatchNo; }
            set
            {
                selectedBatchNo = value;
                OnPropertyChanged("SelectedBatchNo");
            }
        }

        private SalesBillModel currentRow;
        public SalesBillModel CurrentRow
        {
            get { return currentRow; }
            set
            {
                currentRow = value;
                OnPropertyChanged("CurrentRow");
            }
        }

        #region INotifyPropertyChanged Members
            
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            //Fire the PropertyChanged event in case somebody subscribed to it
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
