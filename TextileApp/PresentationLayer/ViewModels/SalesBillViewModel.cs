using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextileApp.Models;

namespace MedicalApp.ViewModels
{
    public class SalesBillViewModel
    {
        public SalesBillViewModel()
        {
            //objProductMaster = new ProductMasterM();
        }

        #region Property
        public ProductMasterM objProductMaster { get; set; }
        #endregion Property
    }
}
