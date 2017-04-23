using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Collections.ObjectModel;
using MedicalApp.Model;
using MedicalApp;

namespace TextileApp.Models
{
    public class ProductMasterM : ProductMaster, IViewDetail
    {
        public ProductMasterM()
        {
            ListProductMaster = new ObservableCollection<ProductMaster>(BLL.BllClient.objBllClient.GetList<ProductMaster>(Common.DataSourceTypes.GetAllListProduct, new ProductMaster()));
            AutoSuggestionList = new ObservableCollection<AutoCompleteTextBoxData>();
            foreach (var item in ListProductMaster)
            {
                AutoCompleteTextBoxData autoCompleteTextBoxData = new AutoCompleteTextBoxData();
                autoCompleteTextBoxData.Text = item.ProductName + "-" + item.Packing;
                autoCompleteTextBoxData.Value = Convert.ToString(item.ProductCode);
                AutoSuggestionList.Add(autoCompleteTextBoxData);
            }
        }

        public ObservableCollection<ProductMaster> ListProductMaster { get; set; }
        public ObservableCollection<AutoCompleteTextBoxData> AutoSuggestionList { get; set; }
    }
}
