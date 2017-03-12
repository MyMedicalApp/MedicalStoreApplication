using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using TextileAppModel;
using System.Collections.ObjectModel;

namespace TextileApp
{
    public class TranPurchaseOrderM : T_TranPurchaseOrder, IViewDetail
    {
        public TranPurchaseOrderM()
        {
            ListTranPurchaseOrder = new ObservableCollection<T_TranPurchaseOrder>(BLL.BllClient.objBllClient.GetList<T_TranPurchaseOrder>(Common.DataSourceTypes.T_TranPurchaseOrderList, new T_TranPurchaseOrder() { CompanyId = (int)CommonModel.CurrentUser.CompanyId }));
            this.TranPurchaseOrderId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.TranPurchaseOrder);
            this.CompanyId = (int)CommonModel.CurrentUser.CompanyId;
        }
        public ObservableCollection<T_TranPurchaseOrder> ListTranPurchaseOrder { get; set; }
        public bool IsModifyData { get; set; }
        private long sSearchTranPurchaseOrderId;
        public long SearchTranPurchaseOrderId
        {
            get { return sSearchTranPurchaseOrderId; }
            set
            {
                sSearchTranPurchaseOrderId = value;
                OnPropertyChanged("SearchTranPurchaseOrderId");
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
            T_TranPurchaseOrder data = getDataByCode(this.SearchTranPurchaseOrderId);
            if (data != null)
            {
                this.Clone<T_TranPurchaseOrder>(data);
                this.IsModifyData = true;
            }
        }

        private string dataBaseAction(Common.DataBaseOperation DBAction)
        {
            string sMsg = string.Empty;
            T_TranPurchaseOrder objData = this.Copy<T_TranPurchaseOrder>();
            objData.OperationFlag = DBAction;

            DataBaseResultSet DBRS = BLL.BllClient.objBllClient.Save<T_TranPurchaseOrder>(Common.DataSourceTypes.T_TranPurchaseOrderSave, objData);
            sMsg = CommonModel.GetOperationMessage<T_TranPurchaseOrder>(DBRS, objData);
            if (DBRS.ErrorCode == 0)
            {
                updateList(DBAction, objData);
                this.ResetData();
            }

            return sMsg;
        }

        private void updateList(Common.DataBaseOperation DBAction, T_TranPurchaseOrder objData)
        {
            T_TranPurchaseOrder data;
            switch ((int)DBAction)
            {
                case 0:
                    ListTranPurchaseOrder.Add(objData);
                    break;
                case 1:
                    data = getDataByCode(Convert.ToInt64(objData.TranPurchaseOrderId));
                    if (data != null)
                    {
                        ListTranPurchaseOrder.Remove(data);
                        ListTranPurchaseOrder.Add(objData);
                    }
                    break;
                case 2:
                    data = getDataByCode(Convert.ToInt64(objData.TranPurchaseOrderId));
                    if (data != null)
                    {
                        ListTranPurchaseOrder.Remove(data);
                    }
                    break;
            }
        }

        private T_TranPurchaseOrder getDataByCode(long nTranPurchaseOrderId)
        {
            var value = from data in this.ListTranPurchaseOrder
                        where Convert.ToInt64(data.TranPurchaseOrderId) == this.SearchTranPurchaseOrderId
                        select data;

            List<T_TranPurchaseOrder> list = value.ToList<T_TranPurchaseOrder>();
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
            this.SearchTranPurchaseOrderId = 0;
            this.TranPurchaseOrderId = (int)CommonModel.GetPrimkeyValue(PrimKeyTables.TranPurchaseOrder);
        }

    }
}
