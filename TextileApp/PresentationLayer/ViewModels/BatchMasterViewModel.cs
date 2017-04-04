 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Windows.Input;
 using MedicalApp.Model;
 using System.Windows;
 using System.Collections.ObjectModel;

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
        #endregion Property
  
    }
}
