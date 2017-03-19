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
            public void GetListShiftMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListShiftMaster";
                ShiftMaster objData = objFilter as ShiftMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillShiftMasterDataFromReader, ref  listData);
            }
            
            private void FillShiftMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    ShiftMaster objData = obj as ShiftMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveShiftMaster<T>(T objData) where T : class, IModel, new()
            {
                ShiftMaster obj = objData as ShiftMaster;
                string sQuery = "sprocShiftMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("ShiftName", "ShiftName", 50, GenericDataType.String, ParameterDirection.Input, obj.ShiftName));
                list.Add(SqlConnManager.GetConnParameters("ShiftNo", "ShiftNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.ShiftNo));
                list.Add(SqlConnManager.GetConnParameters("ShiftDate", "ShiftDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.ShiftDate));
                list.Add(SqlConnManager.GetConnParameters("OpCash", "OpCash", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpCash));
                list.Add(SqlConnManager.GetConnParameters("CashReceipt", "CashReceipt", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CashReceipt));
                list.Add(SqlConnManager.GetConnParameters("ReceiptVoucher", "ReceiptVoucher", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ReceiptVoucher));
                list.Add(SqlConnManager.GetConnParameters("CashReturn", "CashReturn", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CashReturn));
                list.Add(SqlConnManager.GetConnParameters("CashPayment", "CashPayment", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CashPayment));
                list.Add(SqlConnManager.GetConnParameters("PaymentVoucher", "PaymentVoucher", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PaymentVoucher));
                list.Add(SqlConnManager.GetConnParameters("ExtraAmount", "ExtraAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ExtraAmount));
                list.Add(SqlConnManager.GetConnParameters("Amount", "Amount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Amount));
                list.Add(SqlConnManager.GetConnParameters("ShiftMess", "ShiftMess", 100, GenericDataType.String, ParameterDirection.Input, obj.ShiftMess));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("CreatedBy", "CreatedBy", 50, GenericDataType.String, ParameterDirection.Input, obj.CreatedBy));
                list.Add(SqlConnManager.GetConnParameters("CreatedDate", "CreatedDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CreatedDate));
                list.Add(SqlConnManager.GetConnParameters("UpdateddBy", "UpdateddBy", 50, GenericDataType.String, ParameterDirection.Input, obj.UpdateddBy));
                list.Add(SqlConnManager.GetConnParameters("UpdatedDate", "UpdatedDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.UpdatedDate));
                list.Add(SqlConnManager.GetConnParameters("UpdatedCount", "UpdatedCount", 4, GenericDataType.Int, ParameterDirection.Input, obj.UpdatedCount));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.LUT));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
