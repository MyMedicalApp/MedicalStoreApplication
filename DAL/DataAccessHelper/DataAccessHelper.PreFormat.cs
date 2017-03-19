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
            public void GetListPreFormat<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListPreFormat";
                PreFormat objData = objFilter as PreFormat;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillPreFormatDataFromReader, ref  listData);
            }
            
            private void FillPreFormatDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    PreFormat objData = obj as PreFormat;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SavePreFormat<T>(T objData) where T : class, IModel, new()
            {
                PreFormat obj = objData as PreFormat;
                string sQuery = "sprocPreFormatInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("BillNo", "BillNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.BillNo));
                list.Add(SqlConnManager.GetConnParameters("BillDate", "BillDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.BillDate));
                list.Add(SqlConnManager.GetConnParameters("CustomerCode", "CustomerCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CustomerCode));
                list.Add(SqlConnManager.GetConnParameters("DoctorCode", "DoctorCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.DoctorCode));
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.ProductCode));
                list.Add(SqlConnManager.GetConnParameters("Qty", "Qty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Qty));
                list.Add(SqlConnManager.GetConnParameters("Remark", "Remark", 50, GenericDataType.String, ParameterDirection.Input, obj.Remark));
                list.Add(SqlConnManager.GetConnParameters("ReminderTag", "ReminderTag", 10, GenericDataType.String, ParameterDirection.Input, obj.ReminderTag));
                list.Add(SqlConnManager.GetConnParameters("ReminderOn", "ReminderOn", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ReminderOn));
                list.Add(SqlConnManager.GetConnParameters("ReminderUpTo", "ReminderUpTo", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ReminderUpTo));
                list.Add(SqlConnManager.GetConnParameters("Disc", "Disc", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Disc));
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
