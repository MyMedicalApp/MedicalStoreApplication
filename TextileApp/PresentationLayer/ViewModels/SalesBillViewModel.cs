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
        #endregion

        public SalesBillViewModel()
        {
            objProductMaster = new ProductMasterM();
            objSalesBillM = new SalesBillM();
            _qtyKeyDwonCmd = new RelayCommand(AddNewRow, CanAddNewRow);
            
            //objBatchMaster = new BatchMasterM();

        }
        public SalesBillViewModel(string parameter)
        {
            objSalesBillM = new SalesBillM();
            objSalesBillM.ListSalesBillModel.Add(new Model.SalesBillModel());
        }

        #region Property
        public SalesBillM objSalesBillM { get; set; }
       // public SalesBillModel CurrentRow { get; set; }
        //public BatchMasterM objBatchMaster { get; set; }
        public ProductMasterM objProductMaster { get; set; }
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
                      
        }
        public void AddNewRow(SalesBillModel saledBillModel)
        {
            CurrentRow = saledBillModel;
            objSalesBillM.ListSalesBillModel.Add(saledBillModel);
        }
        #endregion

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
