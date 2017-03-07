 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstRoleM : T_MstRole,IViewDetail
    {
        public MstRoleM()
        {
            ListMstRole = new ObservableCollection<T_MstRole>(BLL.BllClient.objBllClient.GetList<T_MstRole>(Common.DataSourceTypes.T_MstRoleList, new T_MstRole()));  
        }
        public ObservableCollection<T_MstRole> ListMstRole { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchRoleId;
        public int          SearchRoleId
        {
            get { return nSearchRoleId; }
            set
            {
                nSearchRoleId = value;
                OnPropertyChanged("SearchRoleId");
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
            T_MstRole data = getDataByCode(this.SearchRoleId);
            if (data != null){
                this.Clone<T_MstRole>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstRole objData = this.Copy<T_MstRole>();
            objData.OperationFlag = DBAction;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstRole>(Common.DataSourceTypes.T_MstRoleSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstRole>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstRole objData)
        {
            T_MstRole data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstRole.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.RoleId);
                    if (data != null){
                        ListMstRole.Remove(data);
                        ListMstRole.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.RoleId);
                    if (data != null){
                        ListMstRole.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstRole getDataByCode(int nRoleId)
        {
            var value = from data in this.ListMstRole
                            where data.RoleId == this.SearchRoleId
                        select data;
        
            List<T_MstRole> list = value.ToList<T_MstRole>();
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
            this.SearchRoleId   = 0;
        }
 
    }
}    
