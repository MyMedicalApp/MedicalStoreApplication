using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using TextileAppModel;
using System.Collections.ObjectModel;

namespace TextileApp
{
    public class TranSalesOrderM : T_TranSalesOrder, IViewDetail
    {
        public TranSalesOrderM()
        {
            ListTranSalesOrder = new ObservableCollection<T_TranSalesOrder>(BLL.BllClient.objBllClient.GetList<T_TranSalesOrder>(Common.DataSourceTypes.T_TranSalesOrderList, new T_TranSalesOrder() { CompanyId = (int)CommonModel.CurrentUser.CompanyId }));
            this.TranSalesOrderId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.TranSalesOrder);
            this.CompanyId = (int)CommonModel.CurrentUser.CompanyId;            
        }
        public ObservableCollection<T_TranSalesOrder> ListTranSalesOrder { get; set; }
        public bool IsModifyData { get; set; }
        private long nSearchTranSalesOrderId;
        public long SearchTranSalesOrderId
        {
            get { return nSearchTranSalesOrderId; }
            set
            {
                nSearchTranSalesOrderId = value;
                OnPropertyChanged("SearchTranSalesOrderId");
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
            T_TranSalesOrder data = getDataByCode(this.SearchTranSalesOrderId);
            if (data != null)
            {
                this.Clone<T_TranSalesOrder>(data);
                this.IsModifyData = true;
            }
        }

        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_TranSalesOrder objData = this.Copy<T_TranSalesOrder>();
            objData.OperationFlag = DBAction;

            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_TranSalesOrder>(Common.DataSourceTypes.T_TranSalesOrderSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_TranSalesOrder>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }

            return sMsg;
        }

        private void updateList(Common.DataBaseOperation DBAction, T_TranSalesOrder objData)
        {
            T_TranSalesOrder data;
            switch ((int)DBAction)
            {
                case 0:
                    ListTranSalesOrder.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(objData.TranSalesOrderId);
                    if (data != null)
                    {
                        ListTranSalesOrder.Remove(data);
                        ListTranSalesOrder.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(objData.TranSalesOrderId);
                    if (data != null)
                    {
                        ListTranSalesOrder.Remove(data);
                    }
                    break;
            }
        }

        private T_TranSalesOrder getDataByCode(long nTranSalesOrderId)
        {
            var value = from data in this.ListTranSalesOrder
                        where data.TranSalesOrderId == this.SearchTranSalesOrderId
                        select data;

            List<T_TranSalesOrder> list = value.ToList<T_TranSalesOrder>();
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
            this.SearchTranSalesOrderId = 0;
            this.TranSalesOrderId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.TranSalesOrder);
        }

    }
}
