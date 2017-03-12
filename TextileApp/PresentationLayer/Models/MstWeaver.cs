 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstWeaverM : T_MstWeaver,IViewDetail
    {
        public MstWeaverM()
        {
            ListMstWeaver       = new ObservableCollection<T_MstWeaver>(BLL.BllClient.objBllClient.GetList<T_MstWeaver>(Common.DataSourceTypes.T_MstWeaverList, new T_MstWeaver()));            
            this.WeaverCode     = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Weaver);
            this.CompanyId      = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_MstWeaver> ListMstWeaver { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchWeaverCode;
        public int          SearchWeaverCode
        {
            get { return nSearchWeaverCode; }
            set
            {
                nSearchWeaverCode = value;
                OnPropertyChanged("SearchWeaverCode");
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
            T_MstWeaver data = getDataByCode(this.SearchWeaverCode);
            if (data != null){
                this.Clone<T_MstWeaver>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstWeaver objData = this.Copy<T_MstWeaver>();
            objData.OperationFlag = DBAction;
            objData.CompanyId = (int)CommonModel.CurrentUser.CompanyId;

            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstWeaver>(Common.DataSourceTypes.T_MstWeaverSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstWeaver>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstWeaver objData)
        {
            T_MstWeaver data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstWeaver.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.WeaverCode);
                    if (data != null){
                        ListMstWeaver.Remove(data);
                        ListMstWeaver.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.WeaverCode);
                    if (data != null){
                        ListMstWeaver.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstWeaver getDataByCode(int nWeaverCode)
        {
            var value = from data in this.ListMstWeaver
                            where data.WeaverCode == this.SearchWeaverCode
                        select data;
        
            List<T_MstWeaver> list = value.ToList<T_MstWeaver>();
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
            this.SearchWeaverCode   = 0;
            this.WeaverCode         = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Weaver);
        }
 
    }
}    
