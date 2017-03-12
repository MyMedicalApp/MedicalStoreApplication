 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstTransportM : T_MstTransport,IViewDetail
    {
        public MstTransportM()
        {
            ListMstTransport    = new ObservableCollection<T_MstTransport>(BLL.BllClient.objBllClient.GetList<T_MstTransport>(Common.DataSourceTypes.T_MstTransportList, new T_MstTransport()));            
            this.TransportCode  = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Transport);
            this.CompanyId      = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_MstTransport> ListMstTransport { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchTransportCode;
        public int          SearchTransportCode
        {
            get { return nSearchTransportCode; }
            set
            {
                nSearchTransportCode = value;
                OnPropertyChanged("SearchTransportCode");
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
            T_MstTransport data = getDataByCode(this.SearchTransportCode);
            if (data != null){
                this.Clone<T_MstTransport>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstTransport objData = this.Copy<T_MstTransport>();
            objData.OperationFlag = DBAction;
            objData.CompanyId = (int)CommonModel.CurrentUser.CompanyId;

            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstTransport>(Common.DataSourceTypes.T_MstTransportSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstTransport>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstTransport objData)
        {
            T_MstTransport data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstTransport.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.TransportCode);
                    if (data != null){
                        ListMstTransport.Remove(data);
                        ListMstTransport.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.TransportCode);
                    if (data != null){
                        ListMstTransport.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstTransport getDataByCode(int nTransportCode)
        {
            var value = from data in this.ListMstTransport
                            where data.TransportCode == this.SearchTransportCode
                        select data;
        
            List<T_MstTransport> list = value.ToList<T_MstTransport>();
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
            this.SearchTransportCode   = 0;
            this.TransportCode      = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Transport);
        }
 
    }
}    
