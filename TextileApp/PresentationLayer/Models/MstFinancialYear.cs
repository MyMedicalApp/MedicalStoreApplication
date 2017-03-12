 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstFinancialYearM : T_MstFinancialYear,IViewDetail
    {
        public MstFinancialYearM()
        {
            ListMstFinancialYear = new ObservableCollection<T_MstFinancialYear>(BLL.BllClient.objBllClient.GetList<T_MstFinancialYear>(Common.DataSourceTypes.T_MstFinancialYearList, new T_MstFinancialYear()));  
        }
        public ObservableCollection<T_MstFinancialYear> ListMstFinancialYear { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchFinancialYearId;
        public int          SearchFinancialYearId
        {
            get { return nSearchFinancialYearId; }
            set
            {
                nSearchFinancialYearId = value;
                OnPropertyChanged("SearchFinancialYearId");
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
            T_MstFinancialYear data = getDataByCode(this.SearchFinancialYearId);
            if (data != null){
                this.Clone<T_MstFinancialYear>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstFinancialYear objData = this.Copy<T_MstFinancialYear>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstFinancialYear>(Common.DataSourceTypes.T_MstFinancialYearSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstFinancialYear>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstFinancialYear objData)
        {
            T_MstFinancialYear data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstFinancialYear.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.FinancialYearId);
                    if (data != null){
                        ListMstFinancialYear.Remove(data);
                        ListMstFinancialYear.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.FinancialYearId);
                    if (data != null){
                        ListMstFinancialYear.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstFinancialYear getDataByCode(int nFinancialYearId)
        {
            var value = from data in this.ListMstFinancialYear
                            where data.FinancialYearId == this.SearchFinancialYearId
                        select data;
        
            List<T_MstFinancialYear> list = value.ToList<T_MstFinancialYear>();
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
            this.SearchFinancialYearId   = 0;
        }
 
    }
}    
