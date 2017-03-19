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
            public void GetListCategoryMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListCategoryMaster";
                CategoryMaster objData = objFilter as CategoryMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("CategoryCode", "CategoryCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.CategoryCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillCategoryMasterDataFromReader, ref  listData);
            }
            
            private void FillCategoryMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    CategoryMaster objData = obj as CategoryMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveCategoryMaster<T>(T objData) where T : class, IModel, new()
            {
                CategoryMaster obj = objData as CategoryMaster;
                string sQuery = "sprocCategoryMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("CategoryCode", "CategoryCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CategoryCode));
                list.Add(SqlConnManager.GetConnParameters("ICode", "ICode", 13, GenericDataType.String, ParameterDirection.Input, obj.ICode));
                list.Add(SqlConnManager.GetConnParameters("CategoryName", "CategoryName", 50, GenericDataType.String, ParameterDirection.Input, obj.CategoryName));
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
