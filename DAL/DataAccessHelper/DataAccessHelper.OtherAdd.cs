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
            public void GetListOtherAdd<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListOtherAdd";
                OtherAdd objData = objFilter as OtherAdd;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillOtherAddDataFromReader, ref  listData);
            }
            
            private void FillOtherAddDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    OtherAdd objData = obj as OtherAdd;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveOtherAdd<T>(T objData) where T : class, IModel, new()
            {
                OtherAdd obj = objData as OtherAdd;
                string sQuery = "sprocOtherAddInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("AddName", "AddName", 50, GenericDataType.String, ParameterDirection.Input, obj.AddName));
                list.Add(SqlConnManager.GetConnParameters("KeyPerson", "KeyPerson", 50, GenericDataType.String, ParameterDirection.Input, obj.KeyPerson));
                list.Add(SqlConnManager.GetConnParameters("Address1", "Address1", 50, GenericDataType.String, ParameterDirection.Input, obj.Address1));
                list.Add(SqlConnManager.GetConnParameters("Address2", "Address2", 50, GenericDataType.String, ParameterDirection.Input, obj.Address2));
                list.Add(SqlConnManager.GetConnParameters("Address3", "Address3", 50, GenericDataType.String, ParameterDirection.Input, obj.Address3));
                list.Add(SqlConnManager.GetConnParameters("City", "City", 50, GenericDataType.String, ParameterDirection.Input, obj.City));
                list.Add(SqlConnManager.GetConnParameters("Mobile", "Mobile", 50, GenericDataType.String, ParameterDirection.Input, obj.Mobile));
                list.Add(SqlConnManager.GetConnParameters("Phone1", "Phone1", 50, GenericDataType.String, ParameterDirection.Input, obj.Phone1));
                list.Add(SqlConnManager.GetConnParameters("Phone2", "Phone2", 50, GenericDataType.String, ParameterDirection.Input, obj.Phone2));
                list.Add(SqlConnManager.GetConnParameters("PhoneR", "PhoneR", 50, GenericDataType.String, ParameterDirection.Input, obj.PhoneR));
                list.Add(SqlConnManager.GetConnParameters("Fax", "Fax", 50, GenericDataType.String, ParameterDirection.Input, obj.Fax));
                list.Add(SqlConnManager.GetConnParameters("Email", "Email", 50, GenericDataType.String, ParameterDirection.Input, obj.Email));
                list.Add(SqlConnManager.GetConnParameters("Category", "Category", 50, GenericDataType.String, ParameterDirection.Input, obj.Category));
                list.Add(SqlConnManager.GetConnParameters("AddNote", "AddNote", 200, GenericDataType.String, ParameterDirection.Input, obj.AddNote));
                list.Add(SqlConnManager.GetConnParameters("ImageName", "ImageName", 250, GenericDataType.String, ParameterDirection.Input, obj.ImageName));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
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
