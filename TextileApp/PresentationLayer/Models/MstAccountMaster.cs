 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstAccountMasterM : T_MstAccountMaster,IViewDetail
    {
        public MstAccountMasterM()
        {
            ListMstAccountMaster = new ObservableCollection<T_MstAccountMaster>(BLL.BllClient.objBllClient.GetList<T_MstAccountMaster>(Common.DataSourceTypes.T_MstAccountMasterList, new T_MstAccountMaster()));
            this.TypeDrCr = "DR";
        }
        public ObservableCollection<T_MstAccountMaster> ListMstAccountMaster { get; set; }
        public bool IsModifyData    { get; set; }
        private long     nSearchAccountCode;
        public long          SearchAccountCode
        {
            get { return nSearchAccountCode; }
            set
            {
                nSearchAccountCode = value;
                OnPropertyChanged("SearchAccountCode");
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
            T_MstAccountMaster data = getDataByCode(this.SearchAccountCode);
            if (data != null){
                this.Clone<T_MstAccountMaster>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstAccountMaster objData = this.Copy<T_MstAccountMaster>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstAccountMaster>(Common.DataSourceTypes.T_MstAccountMasterSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstAccountMaster>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstAccountMaster objData)
        {
            T_MstAccountMaster data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstAccountMaster.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.AccountCode);
                    if (data != null){
                        ListMstAccountMaster.Remove(data);
                        ListMstAccountMaster.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.AccountCode);
                    if (data != null){
                        ListMstAccountMaster.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstAccountMaster getDataByCode(long nAccountCode)
        {
            var value = from data in this.ListMstAccountMaster
                            where data.AccountCode == this.SearchAccountCode
                        select data;
        
            List<T_MstAccountMaster> list = value.ToList<T_MstAccountMaster>();
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
            this.SearchAccountCode   = 0;
        }
 
    }
}    
