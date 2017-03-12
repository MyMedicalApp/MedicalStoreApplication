 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstAccountM : T_MstAccount,IViewDetail
    {
        public MstAccountM()
        {
            
        }
        public ObservableCollection<T_MstAccount> ListMstAccount { get; set; }
        public bool IsModifyData    { get; set; }
        private  long     nSearchAccountId    ;
        public long SearchAccountId
        {
            get { return nSearchAccountId; }
            set
            {
                nSearchAccountId = value;
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
            T_MstAccount data = getDataByCode(this.SearchAccountId);
            if (data != null){
                this.Clone<T_MstAccount>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstAccount objData = this.Copy<T_MstAccount>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstAccount>(Common.DataSourceTypes.T_MstAccountSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstAccount>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstAccount objData)
        {
            T_MstAccount data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstAccount.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.AccountId);
                    if (data != null){
                        ListMstAccount.Remove(data);
                        ListMstAccount.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.AccountId);
                    if (data != null){
                        ListMstAccount.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstAccount getDataByCode( long nSearchAccountId)
        {
            var value = from data in this.ListMstAccount
                        where data.AccountId == this.SearchAccountId
                        select data;
        
            List<T_MstAccount> list = value.ToList<T_MstAccount>();
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
            this.SearchAccountId   = 0;
        }
 
    }
}    
