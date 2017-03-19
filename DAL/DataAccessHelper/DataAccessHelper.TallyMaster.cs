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
            public void GetListTallyMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListTallyMaster";
                TallyMaster objData = objFilter as TallyMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillTallyMasterDataFromReader, ref  listData);
            }
            
            private void FillTallyMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    TallyMaster objData = obj as TallyMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveTallyMaster<T>(T objData) where T : class, IModel, new()
            {
                TallyMaster obj = objData as TallyMaster;
                string sQuery = "sprocTallyMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("TallyTag", "TallyTag", 10, GenericDataType.String, ParameterDirection.Input, obj.TallyTag));
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("VAT", "VAT", 5, GenericDataType.String, ParameterDirection.Input, obj.VAT));
                list.Add(SqlConnManager.GetConnParameters("TallyLedger", "TallyLedger", 100, GenericDataType.String, ParameterDirection.Input, obj.TallyLedger));
                list.Add(SqlConnManager.GetConnParameters("TallyVATLedger", "TallyVATLedger", 100, GenericDataType.String, ParameterDirection.Input, obj.TallyVATLedger));
                list.Add(SqlConnManager.GetConnParameters("TallyClass", "TallyClass", 100, GenericDataType.String, ParameterDirection.Input, obj.TallyClass));
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
