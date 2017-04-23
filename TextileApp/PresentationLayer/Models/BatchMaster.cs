using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Collections.ObjectModel;
using MedicalApp.Model;


namespace MedicalApp
{
    public class BatchMasterM : BatchMaster, IViewDetail
    {
        public BatchMasterM()
        {
            //ListBatchMaster = new ObservableCollection<BatchMaster>(BLL.BllClient.objBllClient.GetList<BatchMaster>(Common.DataSourceTypes.BatchMasterListByProductCode, new BatchMaster()));
        }

        public void BatchMasterListByProductCode(string ProductCode)
        {
            BatchMaster bm = new BatchMaster();
            bm.ProductCode = Convert.ToInt64(ProductCode);

            ListBatchMaster = new ObservableCollection<BatchMaster>(BLL.BllClient.objBllClient.GetList<BatchMaster>(Common.DataSourceTypes.BatchMasterListByProductCode, bm));
        }
        public ObservableCollection<BatchMaster> ListBatchMaster { get; set; }
        
    }
}
