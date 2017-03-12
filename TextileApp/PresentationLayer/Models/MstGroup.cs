 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstGroupM : T_MstGroup,IViewDetail
    {
        public MstGroupM()
        {
            ListMstGroup = new ObservableCollection<T_MstGroup>(BLL.BllClient.objBllClient.GetList<T_MstGroup>(Common.DataSourceTypes.T_MstGroupList, new T_MstGroup()));  
        }
        public ObservableCollection<T_MstGroup> ListMstGroup { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchGroupId;
        public int          SearchGroupId
        {
            get { return nSearchGroupId; }
            set
            {
                nSearchGroupId = value;
                OnPropertyChanged("SearchGroupId");
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
            T_MstGroup data = getDataByCode(this.SearchGroupId);
            if (data != null){
                this.Clone<T_MstGroup>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstGroup objData = this.Copy<T_MstGroup>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstGroup>(Common.DataSourceTypes.T_MstGroupSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstGroup>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstGroup objData)
        {
            T_MstGroup data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstGroup.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.GroupId);
                    if (data != null){
                        ListMstGroup.Remove(data);
                        ListMstGroup.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.GroupId);
                    if (data != null){
                        ListMstGroup.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstGroup getDataByCode(int nGroupId)
        {
            var value = from data in this.ListMstGroup
                            where data.GroupId == this.SearchGroupId
                        select data;
        
            List<T_MstGroup> list = value.ToList<T_MstGroup>();
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
            this.SearchGroupId   = 0;
        }
 
    }
}    
