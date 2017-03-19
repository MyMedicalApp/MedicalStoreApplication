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
            public void GetListConfig<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListConfig";
                Config objData = objFilter as Config;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillConfigDataFromReader, ref  listData);
            }
            
            private void FillConfigDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    Config objData = obj as Config;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveConfig<T>(T objData) where T : class, IModel, new()
            {
                Config obj = objData as Config;
                string sQuery = "sprocConfigInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("DfltVariable", "DfltVariable", 50, GenericDataType.String, ParameterDirection.Input, obj.DfltVariable));
                list.Add(SqlConnManager.GetConnParameters("DfltValue", "DfltValue", 50, GenericDataType.String, ParameterDirection.Input, obj.DfltValue));
                list.Add(SqlConnManager.GetConnParameters("USERCODE", "USERCODE", 8, GenericDataType.Long, ParameterDirection.Input, obj.USERCODE));
                list.Add(SqlConnManager.GetConnParameters("CUSER", "CUSER", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUSER));
                list.Add(SqlConnManager.GetConnParameters("CDATETIME", "CDATETIME", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDATETIME));
                list.Add(SqlConnManager.GetConnParameters("EUSER", "EUSER", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUSER));
                list.Add(SqlConnManager.GetConnParameters("EDATETIME", "EDATETIME", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDATETIME));
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
