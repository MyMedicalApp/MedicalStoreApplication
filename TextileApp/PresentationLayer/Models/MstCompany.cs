using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using TextileAppModel;
using System.Collections.ObjectModel;

namespace TextileApp
{
    public class MstCompanyM : T_MstCompany, IViewDetail
    {
        public MstCompanyM()
        {
            ListMstCompany = new ObservableCollection<T_MstCompany>(BLL.BllClient.objBllClient.GetList<T_MstCompany>(Common.DataSourceTypes.T_MstCompanyList, new T_MstCompany()));
            this.CompanyId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Company);
        }
        public ObservableCollection<T_MstCompany> ListMstCompany { get; set; }
        public bool IsModifyData { get; set; }
        private long nSearchCompanyId;
        public long SearchCompanyId
        {
            get { return nSearchCompanyId; }
            set
            {
                nSearchCompanyId = value;
                OnPropertyChanged("SearchCompanyId");
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
            T_MstCompany data = getDataByCode(this.SearchCompanyId);
            if (data != null)
            {
                this.Clone<T_MstCompany>(data);
                this.IsModifyData = true;
            }
        }

        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_MstCompany objData = this.Copy<T_MstCompany>();
            objData.OperationFlag = DBAction;

            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_MstCompany>(Common.DataSourceTypes.T_MstCompanySave, objData);
            sMsg = CommonModel.GetOperationMessage<T_MstCompany>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }

            return sMsg;
        }

        private void updateList(Common.DataBaseOperation DBAction, T_MstCompany objData)
        {
            T_MstCompany data;
            switch ((int)DBAction)
            {
                case 0:
                    ListMstCompany.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.CompanyId);
                    if (data != null)
                    {
                        ListMstCompany.Remove(data);
                        ListMstCompany.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.CompanyId);
                    if (data != null)
                    {
                        ListMstCompany.Remove(data);
                    }
                    break;
            }
        }

        private T_MstCompany getDataByCode(long nCompanyId)
        {
            var value = from data in this.ListMstCompany
                        where data.CompanyId == this.SearchCompanyId
                        select data;

            List<T_MstCompany> list = value.ToList<T_MstCompany>();
            if (list.Count > 0)
            {
                return list[0];
            }
            return null;
        }

        public new void ResetData()
        {
            base.ResetData();
            this.OperationFlag = DataBaseOperation.Save;
            this.IsModifyData = false;
            this.SearchCompanyId = 0;
            this.CompanyId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.Company);
        }

    }
}
