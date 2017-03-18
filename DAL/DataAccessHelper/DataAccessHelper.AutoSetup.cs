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
            public void GetListAutoSetup<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListAutoSetup";
                AutoSetup objData = objFilter as AutoSetup;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillAutoSetupDataFromReader, ref  listData);
            }
            
            private void FillAutoSetupDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    AutoSetup objData = obj as AutoSetup;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveAutoSetup<T>(T objData) where T : class, IModel, new()
            {
                AutoSetup obj = objData as AutoSetup;
                string sQuery = "sprocAutoSetupInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("EntryTag", "EntryTag", 10, GenericDataType.String, ParameterDirection.Input, obj.EntryTag));
                list.Add(SqlConnManager.GetConnParameters("ReportName", "ReportName", 100, GenericDataType.String, ParameterDirection.Input, obj.ReportName));
                list.Add(SqlConnManager.GetConnParameters("MailTime", "MailTime", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.MailTime));
                list.Add(SqlConnManager.GetConnParameters("MailToID", "MailToID", 200, GenericDataType.String, ParameterDirection.Input, obj.MailToID));
                list.Add(SqlConnManager.GetConnParameters("MailCCID", "MailCCID", 200, GenericDataType.String, ParameterDirection.Input, obj.MailCCID));
                list.Add(SqlConnManager.GetConnParameters("MailBCCID", "MailBCCID", 200, GenericDataType.String, ParameterDirection.Input, obj.MailBCCID));
                list.Add(SqlConnManager.GetConnParameters("SName", "SName", 10, GenericDataType.String, ParameterDirection.Input, obj.SName));
                list.Add(SqlConnManager.GetConnParameters("Phone1", "Phone1", 10, GenericDataType.String, ParameterDirection.Input, obj.Phone1));
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
