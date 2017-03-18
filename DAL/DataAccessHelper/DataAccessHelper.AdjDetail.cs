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
            public void GetListAdjDetail<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListAdjDetail";
                AdjDetail objData = objFilter as AdjDetail;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillAdjDetailDataFromReader, ref  listData);
            }
            
            private void FillAdjDetailDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    AdjDetail objData = obj as AdjDetail;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveAdjDetail<T>(T objData) where T : class, IModel, new()
            {
                AdjDetail obj = objData as AdjDetail;
                string sQuery = "sprocAdjDetailInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("CodeName", "CodeName", 30, GenericDataType.String, ParameterDirection.Input, obj.CodeName));
                list.Add(SqlConnManager.GetConnParameters("CodeRef", "CodeRef", 8, GenericDataType.Long, ParameterDirection.Input, obj.CodeRef));
                list.Add(SqlConnManager.GetConnParameters("BillTag", "BillTag", 20, GenericDataType.String, ParameterDirection.Input, obj.BillTag));
                list.Add(SqlConnManager.GetConnParameters("BillType", "BillType", 20, GenericDataType.String, ParameterDirection.Input, obj.BillType));
                list.Add(SqlConnManager.GetConnParameters("BillCredit", "BillCredit", 10, GenericDataType.String, ParameterDirection.Input, obj.BillCredit));
                list.Add(SqlConnManager.GetConnParameters("BillSeries", "BillSeries", 1, GenericDataType.String, ParameterDirection.Input, obj.BillSeries));
                list.Add(SqlConnManager.GetConnParameters("BillNo", "BillNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.BillNo));
                list.Add(SqlConnManager.GetConnParameters("BillDate", "BillDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.BillDate));
                list.Add(SqlConnManager.GetConnParameters("PurBillNo", "PurBillNo", 10, GenericDataType.String, ParameterDirection.Input, obj.PurBillNo));
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("Amount", "Amount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Amount));
                list.Add(SqlConnManager.GetConnParameters("RcptAmount", "RcptAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.RcptAmount));
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
