 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstBrokerM : T_MstBroker,IViewDetail
    {
        public MstBrokerM()
        {
            ListMstBroker = new ObservableCollection<T_MstBroker>(BLL.BllClient.objBllClient.GetList<T_MstBroker>(Common.DataSourceTypes.T_MstBrokerList
                                                    , new T_MstBroker() { CompanyId = (int)CommonModel.CurrentUser.CompanyId }));            
            this.BrokerCode     = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Broker);  
            this.CompanyId      = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_MstBroker> ListMstBroker { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchBrokerCode;
        public int          SearchBrokerCode
        {
            get { return nSearchBrokerCode; }
            set
            {
                nSearchBrokerCode = value;
                OnPropertyChanged("SearchBrokerCode");
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
            T_MstBroker data = getDataByCode(this.SearchBrokerCode);
            if (data != null){
                this.Clone<T_MstBroker>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstBroker objData     = this.Copy<T_MstBroker>();
            objData.OperationFlag   = DBAction;
            objData.CompanyId       = (int)CommonModel.CurrentUser.CompanyId;

            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstBroker>(Common.DataSourceTypes.T_MstBrokerSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstBroker>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstBroker objData)
        {
            T_MstBroker data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstBroker.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.BrokerCode);
                    if (data != null){
                        ListMstBroker.Remove(data);
                        ListMstBroker.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.BrokerCode);
                    if (data != null){
                        ListMstBroker.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstBroker getDataByCode(int nBrokerCode)
        {
            var value = from data in this.ListMstBroker
                            where data.BrokerCode == this.SearchBrokerCode
                        select data;
        
            List<T_MstBroker> list = value.ToList<T_MstBroker>();
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
            this.SearchBrokerCode   = 0;
            this.BrokerCode         = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Broker);
        }
 
    }
}    
