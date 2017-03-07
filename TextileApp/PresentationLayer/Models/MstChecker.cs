 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstCheckerM : T_MstChecker,IViewDetail
    {
        public MstCheckerM()
        {
            ListMstChecker      = new ObservableCollection<T_MstChecker>(BLL.BllClient.objBllClient.GetList<T_MstChecker>(Common.DataSourceTypes.T_MstCheckerList, new T_MstChecker()));            
            this.CheckerCode    = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Checker);
            this.CompanyId      = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_MstChecker> ListMstChecker { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchCheckerCode;
        public int          SearchCheckerCode
        {
            get { return nSearchCheckerCode; }
            set
            {
                nSearchCheckerCode = value;
                OnPropertyChanged("SearchCheckerCode");
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
            T_MstChecker data = getDataByCode(this.SearchCheckerCode);
            if (data != null){
                this.Clone<T_MstChecker>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstChecker objData = this.Copy<T_MstChecker>();
            objData.OperationFlag = DBAction;
            objData.CompanyId = (int)CommonModel.CurrentUser.CompanyId;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstChecker>(Common.DataSourceTypes.T_MstCheckerSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstChecker>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstChecker objData)
        {
            T_MstChecker data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstChecker.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.CheckerCode);
                    if (data != null){
                        ListMstChecker.Remove(data);
                        ListMstChecker.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.CheckerCode);
                    if (data != null){
                        ListMstChecker.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstChecker getDataByCode(int nCheckerCode)
        {
            var value = from data in this.ListMstChecker
                            where data.CheckerCode == this.SearchCheckerCode
                        select data;
        
            List<T_MstChecker> list = value.ToList<T_MstChecker>();
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
            this.SearchCheckerCode   = 0;
            this.CheckerCode        = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Checker);
        }
 
    }
}    
