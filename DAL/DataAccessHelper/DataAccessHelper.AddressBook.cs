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
            public void GetListAddressBook<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListAddressBook";
                AddressBook objData = objFilter as AddressBook;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AddCode", "AddCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.AddCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillAddressBookDataFromReader, ref  listData);
            }
            
            private void FillAddressBookDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    AddressBook objData = obj as AddressBook;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveAddressBook<T>(T objData) where T : class, IModel, new()
            {
                AddressBook obj = objData as AddressBook;
                string sQuery = "sprocAddressBookInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AddCode", "AddCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AddCode));
                list.Add(SqlConnManager.GetConnParameters("AddName", "AddName", 50, GenericDataType.String, ParameterDirection.Input, obj.AddName));
                list.Add(SqlConnManager.GetConnParameters("ContactPerson", "ContactPerson", 50, GenericDataType.String, ParameterDirection.Input, obj.ContactPerson));
                list.Add(SqlConnManager.GetConnParameters("Add1", "Add1", 50, GenericDataType.String, ParameterDirection.Input, obj.Add1));
                list.Add(SqlConnManager.GetConnParameters("Add2", "Add2", 50, GenericDataType.String, ParameterDirection.Input, obj.Add2));
                list.Add(SqlConnManager.GetConnParameters("Add3", "Add3", 50, GenericDataType.String, ParameterDirection.Input, obj.Add3));
                list.Add(SqlConnManager.GetConnParameters("CityName", "CityName", 20, GenericDataType.String, ParameterDirection.Input, obj.CityName));
                list.Add(SqlConnManager.GetConnParameters("PinCode", "PinCode", 10, GenericDataType.String, ParameterDirection.Input, obj.PinCode));
                list.Add(SqlConnManager.GetConnParameters("Phone1", "Phone1", 30, GenericDataType.String, ParameterDirection.Input, obj.Phone1));
                list.Add(SqlConnManager.GetConnParameters("Phone2", "Phone2", 30, GenericDataType.String, ParameterDirection.Input, obj.Phone2));
                list.Add(SqlConnManager.GetConnParameters("Fax", "Fax", 30, GenericDataType.String, ParameterDirection.Input, obj.Fax));
                list.Add(SqlConnManager.GetConnParameters("Email", "Email", 30, GenericDataType.String, ParameterDirection.Input, obj.Email));
                list.Add(SqlConnManager.GetConnParameters("Category", "Category", 50, GenericDataType.String, ParameterDirection.Input, obj.Category));
                list.Add(SqlConnManager.GetConnParameters("RelWith", "RelWith", 50, GenericDataType.String, ParameterDirection.Input, obj.RelWith));
                list.Add(SqlConnManager.GetConnParameters("AddNote", "AddNote", 200, GenericDataType.String, ParameterDirection.Input, obj.AddNote));
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
