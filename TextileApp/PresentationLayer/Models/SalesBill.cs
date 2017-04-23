using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Collections.ObjectModel;
using MedicalApp.Model;

namespace TextileApp.Models
{
    public class SalesBillM : ProductMaster, IViewDetail
    {
        public SalesBillM()
        {
            //ListSalesBillModel = new ObservableCollection<SalesBillModel>(BLL.BllClient.objBllClient.GetList<ProductMaster>(Common.DataSourceTypes.GetAllListProduct, new ProductMaster()));
           
            ListSalesBillModel = new ObservableCollection<SalesBillModel>();
            //ListSalesBillModel.Add(new SalesBillModel());
        }

        public ObservableCollection<SalesBillModel> ListSalesBillModel { get; set; }
    }
}
