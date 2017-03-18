 using System;                        
 using System.Collections.Generic;    
                     
 using System.Text;                   
 using System.Data.Common;            
 using System.Data;                   
 using Common;                        
 using MedicalApp.Model;                      
                                
namespace DAL
{    
     public partial class DataAccessHelper
     {    
            public void GetListAccountMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListAccountMaster";
                AccountMaster objData = objFilter as AccountMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.AccountCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillAccountMasterDataFromReader, ref  listData);
            }
            
            private void FillAccountMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    AccountMaster objData = obj as AccountMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveAccountMaster<T>(T objData) where T : class, IModel, new()
            {
                AccountMaster obj = objData as AccountMaster;
                string sQuery = "sprocAccountMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("ICode", "ICode", 13, GenericDataType.String, ParameterDirection.Input, obj.ICode));
                list.Add(SqlConnManager.GetConnParameters("AccountName", "AccountName", 50, GenericDataType.String, ParameterDirection.Input, obj.AccountName));
                list.Add(SqlConnManager.GetConnParameters("Add1", "Add1", 50, GenericDataType.String, ParameterDirection.Input, obj.Add1));
                list.Add(SqlConnManager.GetConnParameters("Add2", "Add2", 50, GenericDataType.String, ParameterDirection.Input, obj.Add2));
                list.Add(SqlConnManager.GetConnParameters("Add3", "Add3", 50, GenericDataType.String, ParameterDirection.Input, obj.Add3));
                list.Add(SqlConnManager.GetConnParameters("Add4", "Add4", 50, GenericDataType.String, ParameterDirection.Input, obj.Add4));
                list.Add(SqlConnManager.GetConnParameters("CityCode", "CityCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CityCode));
                list.Add(SqlConnManager.GetConnParameters("ContactPerson", "ContactPerson", 50, GenericDataType.String, ParameterDirection.Input, obj.ContactPerson));
                list.Add(SqlConnManager.GetConnParameters("Phone1", "Phone1", 50, GenericDataType.String, ParameterDirection.Input, obj.Phone1));
                list.Add(SqlConnManager.GetConnParameters("Phone2", "Phone2", 50, GenericDataType.String, ParameterDirection.Input, obj.Phone2));
                list.Add(SqlConnManager.GetConnParameters("Email", "Email", 50, GenericDataType.String, ParameterDirection.Input, obj.Email));
                list.Add(SqlConnManager.GetConnParameters("DLNo1", "DLNo1", 50, GenericDataType.String, ParameterDirection.Input, obj.DLNo1));
                list.Add(SqlConnManager.GetConnParameters("DLNo2", "DLNo2", 50, GenericDataType.String, ParameterDirection.Input, obj.DLNo2));
                list.Add(SqlConnManager.GetConnParameters("VatTin", "VatTin", 50, GenericDataType.String, ParameterDirection.Input, obj.VatTin));
                list.Add(SqlConnManager.GetConnParameters("VatDate", "VatDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VatDate));
                list.Add(SqlConnManager.GetConnParameters("CSTVat", "CSTVat", 50, GenericDataType.String, ParameterDirection.Input, obj.CSTVat));
                list.Add(SqlConnManager.GetConnParameters("CSTVatDate", "CSTVatDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CSTVatDate));
                list.Add(SqlConnManager.GetConnParameters("CashDiscount", "CashDiscount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CashDiscount));
                list.Add(SqlConnManager.GetConnParameters("BillSeries", "BillSeries", 20, GenericDataType.String, ParameterDirection.Input, obj.BillSeries));
                list.Add(SqlConnManager.GetConnParameters("BillType", "BillType", 20, GenericDataType.String, ParameterDirection.Input, obj.BillType));
                list.Add(SqlConnManager.GetConnParameters("AccountType", "AccountType", 50, GenericDataType.String, ParameterDirection.Input, obj.AccountType));
                list.Add(SqlConnManager.GetConnParameters("GroupCode", "GroupCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.GroupCode));
                list.Add(SqlConnManager.GetConnParameters("VisitDay", "VisitDay", 21, GenericDataType.String, ParameterDirection.Input, obj.VisitDay));
                list.Add(SqlConnManager.GetConnParameters("InfoID", "InfoID", 10, GenericDataType.String, ParameterDirection.Input, obj.InfoID));
                list.Add(SqlConnManager.GetConnParameters("OpBalAmount", "OpBalAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpBalAmount));
                list.Add(SqlConnManager.GetConnParameters("OpSetAmount", "OpSetAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpSetAmount));
                list.Add(SqlConnManager.GetConnParameters("BalAmount", "BalAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.BalAmount));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("LCode", "LCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.LCode));
                list.Add(SqlConnManager.GetConnParameters("DLock", "DLock", 3, GenericDataType.String, ParameterDirection.Input, obj.DLock));
                list.Add(SqlConnManager.GetConnParameters("ChequeName", "ChequeName", 50, GenericDataType.String, ParameterDirection.Input, obj.ChequeName));
                list.Add(SqlConnManager.GetConnParameters("LBT", "LBT", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.LBT));
                list.Add(SqlConnManager.GetConnParameters("LBTNo", "LBTNo", 50, GenericDataType.String, ParameterDirection.Input, obj.LBTNo));
                list.Add(SqlConnManager.GetConnParameters("LBTCat", "LBTCat", 50, GenericDataType.String, ParameterDirection.Input, obj.LBTCat));
                list.Add(SqlConnManager.GetConnParameters("DueDay", "DueDay", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.DueDay));
                list.Add(SqlConnManager.GetConnParameters("MailFormat", "MailFormat", 50, GenericDataType.String, ParameterDirection.Input, obj.MailFormat));
                list.Add(SqlConnManager.GetConnParameters("CreatedBy", "CreatedBy", 50, GenericDataType.String, ParameterDirection.Input, obj.CreatedBy));
                list.Add(SqlConnManager.GetConnParameters("CreatedDate", "CreatedDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CreatedDate));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.LUT));
                list.Add(SqlConnManager.GetConnParameters("UpdateddBy", "UpdateddBy", 50, GenericDataType.String, ParameterDirection.Input, obj.UpdateddBy));
                list.Add(SqlConnManager.GetConnParameters("UpdatedDate", "UpdatedDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.UpdatedDate));
                list.Add(SqlConnManager.GetConnParameters("UpdatedCount", "UpdatedCount", 4, GenericDataType.Int, ParameterDirection.Input, obj.UpdatedCount));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
