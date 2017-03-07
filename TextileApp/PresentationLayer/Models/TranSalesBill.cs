 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class TranSalesBillM : T_TranSalesBill,IViewDetail
    {
        public TranSalesBillM()
        {
            ListTranSalesBill = new ObservableCollection<T_TranSalesBill>(BLL.BllClient.objBllClient.GetList<T_TranSalesBill>(Common.DataSourceTypes.T_TranSalesBillList, new T_TranSalesBill()));  
        }
        public ObservableCollection<T_TranSalesBill> ListTranSalesBill { get; set; }
        public bool IsModifyData    { get; set; }
        private long     nSearchTranSalesBillId;
        public long          SearchTranSalesBillId
        {
            get { return nSearchTranSalesBillId; }
            set
            {
                nSearchTranSalesBillId = value;
                OnPropertyChanged("SearchTranSalesBillId");
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
            T_TranSalesBill data = getDataByCode(this.SearchTranSalesBillId);
            if (data != null){
                this.Clone<T_TranSalesBill>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_TranSalesBill objData = this.Copy<T_TranSalesBill>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_TranSalesBill>(Common.DataSourceTypes.T_TranSalesBillSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_TranSalesBill>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_TranSalesBill objData)
        {
            T_TranSalesBill data;
            switch ((int)DBAction)
            {
                case 0:
                    ListTranSalesBill.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.TranSalesBillId);
                    if (data != null){
                        ListTranSalesBill.Remove(data);
                        ListTranSalesBill.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.TranSalesBillId);
                    if (data != null){
                        ListTranSalesBill.Remove(data);
                    }
                    break;
            }
        }
 
        private T_TranSalesBill getDataByCode(long nTranSalesBillId)
        {
            var value = from data in this.ListTranSalesBill
                            where data.TranSalesBillId == this.SearchTranSalesBillId
                        select data;
        
            List<T_TranSalesBill> list = value.ToList<T_TranSalesBill>();
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
            this.SearchTranSalesBillId   = 0;
        }
 
    }
}    
