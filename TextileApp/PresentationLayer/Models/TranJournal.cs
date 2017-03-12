 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class TranJournalM : T_TranJournal,IViewDetail
    {
        public TranJournalM()
        {
            ListTranJournal = new ObservableCollection<T_TranJournal>(BLL.BllClient.objBllClient.GetList<T_TranJournal>(Common.DataSourceTypes.T_TranJournalList, new T_TranJournal() { CompanyId = (int)CommonModel.CurrentUser.CompanyId }));
            this.TranJournalId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.TranJouranl);
            this.CompanyId = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_TranJournal> ListTranJournal { get; set; }
        public bool IsModifyData    { get; set; }
        private long     nSearchTranJournalId;
        public long          SearchTranJournalId
        {
            get { return nSearchTranJournalId; }
            set
            {
                nSearchTranJournalId = value;
                OnPropertyChanged("SearchTranJournalId");
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
            T_TranJournal data = getDataByCode(this.SearchTranJournalId);
            if (data != null){
                this.Clone<T_TranJournal>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_TranJournal objData = this.Copy<T_TranJournal>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_TranJournal>(Common.DataSourceTypes.T_TranJournalSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_TranJournal>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_TranJournal objData)
        {
            T_TranJournal data;
            switch ((int)DBAction)
            {
                case 0:
                    ListTranJournal.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.TranJournalId);
                    if (data != null){
                        ListTranJournal.Remove(data);
                        ListTranJournal.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.TranJournalId);
                    if (data != null){
                        ListTranJournal.Remove(data);
                    }
                    break;
            }
        }
 
        private T_TranJournal getDataByCode(long nTranJournalId)
        {
            var value = from data in this.ListTranJournal
                            where data.TranJournalId == this.SearchTranJournalId
                        select data;
        
            List<T_TranJournal> list = value.ToList<T_TranJournal>();
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
            this.SearchTranJournalId   = 0;
            this.TranJournalId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.TranJouranl);
        }
 
    }
}    
