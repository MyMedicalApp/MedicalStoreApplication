using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Collections.ObjectModel;
using MedicalApp.Model;

namespace TextileApp.Models
{
    public class ProductMasterM : ProductMaster, IViewDetail
    {
        public ProductMasterM()
        {
            ListProductMaster = new ObservableCollection<ProductMaster>(BLL.BllClient.objBllClient.GetList<ProductMaster>(Common.DataSourceTypes.GetAllListProduct, new ProductMaster()));
        }

        public ObservableCollection<ProductMaster> ListProductMaster { get; set; }
    }
}
