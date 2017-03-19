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
            public void GetListUserMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListUserMaster";
                UserMaster objData = objFilter as UserMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("UserCode", "UserCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.UserCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillUserMasterDataFromReader, ref  listData);
            }
            
            private void FillUserMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    UserMaster objData = obj as UserMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveUserMaster<T>(T objData) where T : class, IModel, new()
            {
                UserMaster obj = objData as UserMaster;
                string sQuery = "sprocUserMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("UserCode", "UserCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.UserCode));
                list.Add(SqlConnManager.GetConnParameters("ICode", "ICode", 13, GenericDataType.String, ParameterDirection.Input, obj.ICode));
                list.Add(SqlConnManager.GetConnParameters("UserName", "UserName", 50, GenericDataType.String, ParameterDirection.Input, obj.UserName));
                list.Add(SqlConnManager.GetConnParameters("UserPass", "UserPass", 10, GenericDataType.String, ParameterDirection.Input, obj.UserPass));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("LCode", "LCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.LCode));
                list.Add(SqlConnManager.GetConnParameters("DLock", "DLock", 3, GenericDataType.String, ParameterDirection.Input, obj.DLock));
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
