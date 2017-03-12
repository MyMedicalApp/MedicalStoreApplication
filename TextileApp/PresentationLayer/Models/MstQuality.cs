 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using TextileAppModel;
 using System.Collections.ObjectModel;
    
namespace TextileApp
{    
    public class MstQualityM : T_MstQuality,IViewDetail
    {
        public MstQualityM()
        {
            ListMstQuality      = new ObservableCollection<T_MstQuality>(BLL.BllClient.objBllClient.GetList<T_MstQuality>(Common.DataSourceTypes.T_MstQualityList, new T_MstQuality()));            
            this.QualityCode    = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Quality);
            this.CompanyId      = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_MstQuality> ListMstQuality { get; set; }
        public bool IsModifyData    { get; set; }
        private int     nSearchQualityCode;
        public int          SearchQualityCode
        {
            get { return nSearchQualityCode; }
            set
            {
                nSearchQualityCode = value;
                OnPropertyChanged("SearchQualityCode");
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
            T_MstQuality data = getDataByCode(this.SearchQualityCode);
            if (data != null){
                this.Clone<T_MstQuality>(data);
                this.IsModifyData = true;
            }
        }
 
        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstQuality objData = this.Copy<T_MstQuality>();
            objData.OperationFlag = DBAction;
            objData.CompanyId = (int)CommonModel.CurrentUser.CompanyId;
            
            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstQuality>(Common.DataSourceTypes.T_MstQualitySave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstQuality>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }
            
            return sMsg;
        }
 
        private void updateList(Common.DataBaseOperation DBAction, T_MstQuality objData)
        {
            T_MstQuality data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstQuality.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.QualityCode);
                    if (data != null){
                        ListMstQuality.Remove(data);
                        ListMstQuality.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.QualityCode);
                    if (data != null){
                        ListMstQuality.Remove(data);
                    }
                    break;
            }
        }
 
        private T_MstQuality getDataByCode(int nQualityCode)
        {
            var value = from data in this.ListMstQuality
                            where data.QualityCode == this.SearchQualityCode
                        select data;
        
            List<T_MstQuality> list = value.ToList<T_MstQuality>();
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
            this.SearchQualityCode   = 0;
            this.QualityCode        = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Quality);
        }
 
    }
}    
