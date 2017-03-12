 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
  using System.Collections.ObjectModel;
using MedicalApp.Model;

namespace MedicalApp
{    
    public class GenericMasterM : GenericMaster,IViewDetail
    {
        public GenericMasterM()
        {
            ListGenericMaster = new ObservableCollection<GenericMaster>(BLL.BllClient.objBllClient.GetList<GenericMaster>(Common.DataSourceTypes.GenericMasterList, new GenericMaster()));  
        }
        public ObservableCollection<GenericMaster> ListGenericMaster { get; set; }
        public bool IsModifyData    { get; set; }

        private long search;
        public   long    Search
        {
            get { return search; }
            set
            {
                search = value;
                OnPropertyChanged("Search");
            }
        }
 
        public string SaveData()
        {
            Common.DataBaseOperation DBAction = (this.IsModifyData) ? Common.DataBaseOperation.Update : Common.DataBaseOperation.Save;
            return dataBaseAction(DBAction);
        }
 
        public string DeleteData()
        {
            return dataBaseAction(Common.DataBaseOperation.Delete);
        }
 
        public void SearchData()
        {
            GenericMaster data = getDataByCode(this.Search);
            if (data != null){
                this.Clone<GenericMaster>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            GenericMaster objData = this.Copy<GenericMaster>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<GenericMaster>(Common.DataSourceTypes.GenericMasterSave, objData);
            sMsg = CommonModel.GetOperationMessage<GenericMaster>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, GenericMaster objData)
        {
            GenericMaster data;
            switch ((int)DBAction)
            {
                case 0:
                    ListGenericMaster.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.GenericCode);
                    if (data != null){
                        ListGenericMaster.Remove(data);
                        ListGenericMaster.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.GenericCode);
                    if (data != null){
                        ListGenericMaster.Remove(data);
                    }
                    break;
            }
        }
 
        private GenericMaster getDataByCode(long nGenericCode)
        {
            var value = from data in this.ListGenericMaster
                        where data.GenericCode == this.Search
                        select data;
        
            List<GenericMaster> list = value.ToList<GenericMaster>();
            if (list.Count > 0){
                return list[0];
            }
            return null;
        }
 
        public new void ResetData()
        {
            base.ResetData();
            this.OperationFlag      = DataBaseOperation.Save;
            this.IsModifyData       = false;
            this.Search   = 0;
        }
 
    }
}    
