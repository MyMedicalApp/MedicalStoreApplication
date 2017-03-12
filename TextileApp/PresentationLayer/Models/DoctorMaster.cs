 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using MedicalApp.Model;
 using System.Collections.ObjectModel;
    
namespace MedicalApp
{    
    public class DoctorMasterM : DoctorMaster,IViewDetail
    {
        public DoctorMasterM()
        {
            ListDoctorMaster = new ObservableCollection<DoctorMaster>(BLL.BllClient.objBllClient.GetList<DoctorMaster>(Common.DataSourceTypes.DoctorMasterList, new DoctorMaster()));  
        }
        public ObservableCollection<DoctorMaster> ListDoctorMaster { get; set; }
        public bool IsModifyData    { get; set; }
        private  long    searchDoctorCode;
        public   long        SearchDoctorCode
        {
            get { return searchDoctorCode; }
            set
            {
                searchDoctorCode = value;
                OnPropertyChanged("SearchDoctorCode");
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
            DoctorMaster data = getDataByCode(this.SearchDoctorCode);
            if (data != null){
                this.Clone<DoctorMaster>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            DoctorMaster objData = this.Copy<DoctorMaster>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<DoctorMaster>(Common.DataSourceTypes.DoctorMasterSave, objData);
            sMsg = CommonModel.GetOperationMessage<DoctorMaster>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, DoctorMaster objData)
        {
            DoctorMaster data;
            switch ((int)DBAction)
            {
                case 0:
                    ListDoctorMaster.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.DoctorCode);
                    if (data != null){
                        ListDoctorMaster.Remove(data);
                        ListDoctorMaster.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.DoctorCode);
                    if (data != null){
                        ListDoctorMaster.Remove(data);
                    }
                    break;
            }
        }
 
        private DoctorMaster getDataByCode(long doctorCode)
        {
            var value = from data in this.ListDoctorMaster
                        where data.DoctorCode == this.SearchDoctorCode
                        select data;
        
            List<DoctorMaster> list = value.ToList<DoctorMaster>();
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
            this.SearchDoctorCode   = 0;
        }
 
    }
}    
