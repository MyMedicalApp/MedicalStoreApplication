 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class TranCashM : T_TranCash,IViewDetail
    {
        public TranCashM()
        {
            ListTranCash = new ObservableCollection<T_TranCash>(BLL.BllClient.objBllClient.GetList<T_TranCash>(Common.DataSourceTypes.T_TranCashList, new T_TranCash() { CompanyId = (int)CommonModel.CurrentUser.CompanyId }));
            this.CompanyId = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_TranCash> ListTranCash { get; set; }
        public bool IsModifyData    { get; set; }
        private long     nSearchTranBankId;
        public long          SearchTranBankId
        {
            get { return nSearchTranBankId; }
            set
            {
                nSearchTranBankId = value;
                OnPropertyChanged("SearchTranBankId");
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
            T_TranCash data = getDataByCode(this.SearchTranBankId);
            if (data != null){
                this.Clone<T_TranCash>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_TranCash objData = this.Copy<T_TranCash>();
            objData.OperationFlag = DBAction;
            objData.LUT = DateTime.Now;
            objData.VoucherDate = DateTime.Now;
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_TranCash>(Common.DataSourceTypes.T_TranCashSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_TranCash>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_TranCash objData)
        {
            T_TranCash data;
            switch ((int)DBAction)
            {
                case 0:
                    ListTranCash.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.TranBankId);
                    if (data != null){
                        ListTranCash.Remove(data);
                        ListTranCash.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.TranBankId);
                    if (data != null){
                        ListTranCash.Remove(data);
                    }
                    break;
            }
        }
 
        private T_TranCash getDataByCode(long nTranBankId)
        {
            var value = from data in this.ListTranCash
                            where data.TranBankId == this.SearchTranBankId
                        select data;
        
            List<T_TranCash> list = value.ToList<T_TranCash>();
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
            this.SearchTranBankId   = 0;
        }
 
    }
}    
