 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using DAL;
 using MedicalApp.Model;
    
namespace BLL
{    
    public class BllClient
    {
        private DataAccessHelper objDAL = new DataAccessHelper();
        public List<T> GetList<T>(DataSourceTypes DataSourceTypes, T objFilter) where T: class, IModel, new()
        {
            List<T> list = new List<T>();
            switch (DataSourceTypes)
            {
             
                case Common.DataSourceTypes.SalesDetailList:
                    objDAL.GetListSalesDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.AreaMasterList:
                    objDAL.GetListAreaMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.oVatDetailList:
                    objDAL.GetListoVatDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.AutoSetupList:
                    objDAL.GetListAutoSetup(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.CustomerMasterList:
                    objDAL.GetListCustomerMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.ErrorDescList:
                    objDAL.GetListErrorDesc(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.DoctorMasterList:
                    objDAL.GetListDoctorMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.FirmMasterList:
                    objDAL.GetListFirmMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.DiseaseDetailList:
                    objDAL.GetListDiseaseDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.AdjDetailList:
                    objDAL.GetListAdjDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.ShiftMasterList:
                    objDAL.GetListShiftMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.DiseaseMasterList:
                    objDAL.GetListDiseaseMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.CrDrDetailList:
                    objDAL.GetListCrDrDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.VatDetailList:
                    objDAL.GetListVatDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.GroupMasterList:
                    objDAL.GetListGroupMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.MapProductList:
                    objDAL.GetListMapProduct(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.OldBillMasterList:
                    objDAL.GetListOldBillMaster(objFilter, ref list);
                    break;              
                case Common.DataSourceTypes.XDetailList:
                    objDAL.GetListXDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.OrderDetailList:
                    objDAL.GetListOrderDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.DeletedDetailList:
                    objDAL.GetListDeletedDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.TallyMasterList:
                    objDAL.GetListTallyMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.OBillMasterList:
                    objDAL.GetListOBillMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.BranchStockList:
                    objDAL.GetListBranchStock(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.XMasterList:
                    objDAL.GetListXMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.oBatchMasterList:
                    objDAL.GetListoBatchMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.AccountMasterList:
                    objDAL.GetListAccountMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.CityMasterList:
                    objDAL.GetListCityMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.OrderMasterList:
                    objDAL.GetListOrderMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.CompanyDetailList:
                    objDAL.GetListCompanyDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.MiscRcptPmtList:
                    objDAL.GetListMiscRcptPmt(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.CategoryMasterList:
                    objDAL.GetListCategoryMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.CompanyMasterList:
                    objDAL.GetListCompanyMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.PurDetailList:
                    objDAL.GetListPurDetail(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.ConfigList:
                    objDAL.GetListConfig(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.GenericMasterList:
                    objDAL.GetListGenericMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.SalesManMasterList:
                    objDAL.GetListSalesManMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.BillMasterList:
                    objDAL.GetListBillMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.ProductMasterList:
                    objDAL.GetListProductMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.GetAllListProduct:
                    objDAL.GetAllListProduct(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.OtherAddList:
                    objDAL.GetListOtherAdd(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.PatientMasterList:
                    objDAL.GetListPatientMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.BatchMasterList:
                    objDAL.GetListBatchMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.BatchMasterListByProductCode:
                    objDAL.GetListBatchMasterByProductCode(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.PreFormatList:
                    objDAL.GetListPreFormat(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.UserMasterList:
                    objDAL.GetListUserMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.PrintFormatList:
                    objDAL.GetListPrintFormat(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.ReceivePaymentList:
                    objDAL.GetListReceivePayment(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.AddressBookList:
                    objDAL.GetListAddressBook(objFilter, ref list);
                    break;
            }
            return list;
        }
        public DataBaseResultSet Save<T>(DataSourceTypes DataSourceTypes, T objFilter) where T : class, IModel, new()
        {
            DataBaseResultSet nResult = new DataBaseResultSet();
            switch (DataSourceTypes)
            {
                case Common.DataSourceTypes.SalesDetailSave:
                    nResult = objDAL.SaveSalesDetail(objFilter);
                    break;
                case Common.DataSourceTypes.AreaMasterSave:
                    nResult = objDAL.SaveAreaMaster(objFilter);
                    break;
                case Common.DataSourceTypes.oVatDetailSave:
                    nResult = objDAL.SaveoVatDetail(objFilter);
                    break;
                case Common.DataSourceTypes.AutoSetupSave:
                    nResult = objDAL.SaveAutoSetup(objFilter);
                    break;
                case Common.DataSourceTypes.CustomerMasterSave:
                    nResult = objDAL.SaveCustomerMaster(objFilter);
                    break;
                case Common.DataSourceTypes.ErrorDescSave:
                    nResult = objDAL.SaveErrorDesc(objFilter);
                    break;
                case Common.DataSourceTypes.DoctorMasterSave:
                    nResult = objDAL.SaveDoctorMaster(objFilter);
                    break;
                case Common.DataSourceTypes.FirmMasterSave:
                    nResult = objDAL.SaveFirmMaster(objFilter);
                    break;
                case Common.DataSourceTypes.DiseaseDetailSave:
                    nResult = objDAL.SaveDiseaseDetail(objFilter);
                    break;
                case Common.DataSourceTypes.AdjDetailSave:
                    nResult = objDAL.SaveAdjDetail(objFilter);
                    break;
                case Common.DataSourceTypes.ShiftMasterSave:
                    nResult = objDAL.SaveShiftMaster(objFilter);
                    break;
                case Common.DataSourceTypes.DiseaseMasterSave:
                    nResult = objDAL.SaveDiseaseMaster(objFilter);
                    break;
                case Common.DataSourceTypes.CrDrDetailSave:
                    nResult = objDAL.SaveCrDrDetail(objFilter);
                    break;
                case Common.DataSourceTypes.VatDetailSave:
                    nResult = objDAL.SaveVatDetail(objFilter);
                    break;
                case Common.DataSourceTypes.GroupMasterSave:
                    nResult = objDAL.SaveGroupMaster(objFilter);
                    break;
                case Common.DataSourceTypes.MapProductSave:
                    nResult = objDAL.SaveMapProduct(objFilter);
                    break;
                case Common.DataSourceTypes.OldBillMasterSave:
                    nResult = objDAL.SaveOldBillMaster(objFilter);
                    break;              
                case Common.DataSourceTypes.XDetailSave:
                    nResult = objDAL.SaveXDetail(objFilter);
                    break;
                case Common.DataSourceTypes.OrderDetailSave:
                    nResult = objDAL.SaveOrderDetail(objFilter);
                    break;
                case Common.DataSourceTypes.DeletedDetailSave:
                    nResult = objDAL.SaveDeletedDetail(objFilter);
                    break;
                case Common.DataSourceTypes.TallyMasterSave:
                    nResult = objDAL.SaveTallyMaster(objFilter);
                    break;
                case Common.DataSourceTypes.OBillMasterSave:
                    nResult = objDAL.SaveOBillMaster(objFilter);
                    break;
                case Common.DataSourceTypes.BranchStockSave:
                    nResult = objDAL.SaveBranchStock(objFilter);
                    break;
                case Common.DataSourceTypes.XMasterSave:
                    nResult = objDAL.SaveXMaster(objFilter);
                    break;
                case Common.DataSourceTypes.oBatchMasterSave:
                    nResult = objDAL.SaveoBatchMaster(objFilter);
                    break;
                case Common.DataSourceTypes.AccountMasterSave:
                    nResult = objDAL.SaveAccountMaster(objFilter);
                    break;
                case Common.DataSourceTypes.CityMasterSave:
                    nResult = objDAL.SaveCityMaster(objFilter);
                    break;
                case Common.DataSourceTypes.OrderMasterSave:
                    nResult = objDAL.SaveOrderMaster(objFilter);
                    break;
                case Common.DataSourceTypes.CompanyDetailSave:
                    nResult = objDAL.SaveCompanyDetail(objFilter);
                    break;
                case Common.DataSourceTypes.MiscRcptPmtSave:
                    nResult = objDAL.SaveMiscRcptPmt(objFilter);
                    break;
                case Common.DataSourceTypes.CategoryMasterSave:
                    nResult = objDAL.SaveCategoryMaster(objFilter);
                    break;
                case Common.DataSourceTypes.CompanyMasterSave:
                    nResult = objDAL.SaveCompanyMaster(objFilter);
                    break;
                case Common.DataSourceTypes.PurDetailSave:
                    nResult = objDAL.SavePurDetail(objFilter);
                    break;
                case Common.DataSourceTypes.ConfigSave:
                    nResult = objDAL.SaveConfig(objFilter);
                    break;
                case Common.DataSourceTypes.GenericMasterSave:
                    nResult = objDAL.SaveGenericMaster(objFilter);
                    break;
                case Common.DataSourceTypes.SalesManMasterSave:
                    nResult = objDAL.SaveSalesManMaster(objFilter);
                    break;
                case Common.DataSourceTypes.BillMasterSave:
                    nResult = objDAL.SaveBillMaster(objFilter);
                    break;
                case Common.DataSourceTypes.ProductMasterSave:
                    nResult = objDAL.SaveProductMaster(objFilter);
                    break;
                case Common.DataSourceTypes.OtherAddSave:
                    nResult = objDAL.SaveOtherAdd(objFilter);
                    break;
                case Common.DataSourceTypes.PatientMasterSave:
                    nResult = objDAL.SavePatientMaster(objFilter);
                    break;
                case Common.DataSourceTypes.BatchMasterSave:
                    nResult = objDAL.SaveBatchMaster(objFilter);
                    break;
                case Common.DataSourceTypes.PreFormatSave:
                    nResult = objDAL.SavePreFormat(objFilter);
                    break;
                case Common.DataSourceTypes.UserMasterSave:
                    nResult = objDAL.SaveUserMaster(objFilter);
                    break;
                case Common.DataSourceTypes.PrintFormatSave:
                    nResult = objDAL.SavePrintFormat(objFilter);
                    break;
                case Common.DataSourceTypes.ReceivePaymentSave:
                    nResult = objDAL.SaveReceivePayment(objFilter);
                    break;
                case Common.DataSourceTypes.AddressBookSave:
                    nResult = objDAL.SaveAddressBook(objFilter);
                    break;
            }

            if (nResult.ErrorCode != 0)
            {
                checkAndWriteDatabaseException<T>(objFilter, nResult, DataSourceTypes);
            }

            return nResult;
        }

        private void checkAndWriteDatabaseException<T>(T objData, DataBaseResultSet DBSet, DataSourceTypes DST) where T : class, IModel, new()
        {
            T_ErrorDesc objErrorData = WriteServiceErrorLog.GetErrorLog(DBSet, DST, objData.GetXmlString());
            string sMsg = string.Empty;
            DataBaseResultSet DBSetSaveError = objDAL.SaveT_ErrorDesc(objData);
        }
        
        public static BllClient objBllClient = new BllClient();
    }
}
