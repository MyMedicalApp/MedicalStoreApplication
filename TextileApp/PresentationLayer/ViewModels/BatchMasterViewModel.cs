 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using MedicalApp.Model;
 using System.Windows;
 using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MedicalApp.ViewModels
{
    public class BatchMasterViewModel
    {
       #region Private Variables
            private readonly ICommand _addBatchMasterCmd;
            private readonly ICommand _deleteBatchMasterCmd;
            private readonly ICommand _resetBatchMasterCmd;
            private readonly ICommand _searchBatchMasterCmd;
       #endregion
  
        #region Constructors
            /// <summary>
            /// Instatiates all the readonly variables
            /// </summary>
            public BatchMasterViewModel()
            {
                objBatchMaster        = new BatchMasterM();
                
   
            }
        #endregion
  
        #region Property
            public BatchMasterM objBatchMaster { get; set; }

            private BatchMaster nSelectedRow;
            public BatchMaster SelectedRow
            {
                get { return nSelectedRow; }
                set
                {
                    nSelectedRow = value;
                    OnPropertyChanged("SelectedRow");
                }
            }

            string nProductCode;
            public string ProductCode
            {
                get { return nProductCode; }
                set
                {
                    nProductCode = value;
                    OnPropertyChanged("ProductCode");
                }
            }
        #endregion Property

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
