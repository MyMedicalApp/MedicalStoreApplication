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
            public void GetListErrorDesc<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListErrorDesc";
                ErrorDesc objData = objFilter as ErrorDesc;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ErrorId", "ErrorId", 4, GenericDataType.Int, ParameterDirection.Input, objData.ErrorId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillErrorDescDataFromReader, ref  listData);
            }
            
            private void FillErrorDescDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    ErrorDesc objData = obj as ErrorDesc;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveErrorDesc<T>(T objData) where T : class, IModel, new()
            {
                ErrorDesc obj = objData as ErrorDesc;
                string sQuery = "sprocErrorDescInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ErrorId", "ErrorId", 4, GenericDataType.Int, ParameterDirection.Input, obj.ErrorId));
                list.Add(SqlConnManager.GetConnParameters("CategoryID", "CategoryID", 4, GenericDataType.Int, ParameterDirection.Input, obj.CategoryID));
                list.Add(SqlConnManager.GetConnParameters("PageCode", "PageCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.PageCode));
                list.Add(SqlConnManager.GetConnParameters("MethodCode", "MethodCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.MethodCode));
                list.Add(SqlConnManager.GetConnParameters("EventCode", "EventCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.EventCode));
                list.Add(SqlConnManager.GetConnParameters("ErrorLineNo", "ErrorLineNo", 4, GenericDataType.Int, ParameterDirection.Input, obj.ErrorLineNo));
                list.Add(SqlConnManager.GetConnParameters("MethodTrace", "MethodTrace", 100, GenericDataType.String, ParameterDirection.Input, obj.MethodTrace));
                list.Add(SqlConnManager.GetConnParameters("EmpNo", "EmpNo", 50, GenericDataType.String, ParameterDirection.Input, obj.EmpNo));
                list.Add(SqlConnManager.GetConnParameters("ClientIpAddress", "ClientIpAddress", 30, GenericDataType.String, ParameterDirection.Input, obj.ClientIpAddress));
                list.Add(SqlConnManager.GetConnParameters("PageName", "PageName", 100, GenericDataType.String, ParameterDirection.Input, obj.PageName));
                list.Add(SqlConnManager.GetConnParameters("MethodName", "MethodName", 100, GenericDataType.String, ParameterDirection.Input, obj.MethodName));
                list.Add(SqlConnManager.GetConnParameters("ErrorMsg", "ErrorMsg", 1000, GenericDataType.String, ParameterDirection.Input, obj.ErrorMsg));
                list.Add(SqlConnManager.GetConnParameters("ErrorDate", "ErrorDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.ErrorDate));
                list.Add(SqlConnManager.GetConnParameters("ErrorData", "ErrorData", -1, GenericDataType.String, ParameterDirection.Input, obj.ErrorData));
                list.Add(SqlConnManager.GetConnParameters("ErrorType", "ErrorType", 100, GenericDataType.String, ParameterDirection.Input, obj.ErrorType));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
