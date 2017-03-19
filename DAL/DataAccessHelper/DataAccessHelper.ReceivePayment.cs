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
            public void GetListReceivePayment<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListReceivePayment";
                ReceivePayment objData = objFilter as ReceivePayment;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillReceivePaymentDataFromReader, ref  listData);
            }
            
            private void FillReceivePaymentDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    ReceivePayment objData = obj as ReceivePayment;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveReceivePayment<T>(T objData) where T : class, IModel, new()
            {
                ReceivePayment obj = objData as ReceivePayment;
                string sQuery = "sprocReceivePaymentInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("EntryTag", "EntryTag", 30, GenericDataType.String, ParameterDirection.Input, obj.EntryTag));
                list.Add(SqlConnManager.GetConnParameters("RefNo", "RefNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RefNo));
                list.Add(SqlConnManager.GetConnParameters("EntryDate", "EntryDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EntryDate));
                list.Add(SqlConnManager.GetConnParameters("ChequeNo", "ChequeNo", 10, GenericDataType.String, ParameterDirection.Input, obj.ChequeNo));
                list.Add(SqlConnManager.GetConnParameters("ChequeDate", "ChequeDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.ChequeDate));
                list.Add(SqlConnManager.GetConnParameters("AccountCode1", "AccountCode1", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode1));
                list.Add(SqlConnManager.GetConnParameters("AccountCode2", "AccountCode2", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode2));
                list.Add(SqlConnManager.GetConnParameters("Amount", "Amount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Amount));
                list.Add(SqlConnManager.GetConnParameters("RcptMess", "RcptMess", 100, GenericDataType.String, ParameterDirection.Input, obj.RcptMess));
                list.Add(SqlConnManager.GetConnParameters("ReconDate", "ReconDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.ReconDate));
                list.Add(SqlConnManager.GetConnParameters("ShiftNo", "ShiftNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.ShiftNo));
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
