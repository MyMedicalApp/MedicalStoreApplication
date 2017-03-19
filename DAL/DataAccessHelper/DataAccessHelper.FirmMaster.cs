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
            public void GetListFirmMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListFirmMaster";
                FirmMaster objData = objFilter as FirmMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillFirmMasterDataFromReader, ref  listData);
            }
            
            private void FillFirmMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    FirmMaster objData = obj as FirmMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveFirmMaster<T>(T objData) where T : class, IModel, new()
            {
                FirmMaster obj = objData as FirmMaster;
                string sQuery = "sprocFirmMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("FirmName", "FirmName", 50, GenericDataType.String, ParameterDirection.Input, obj.FirmName));
                list.Add(SqlConnManager.GetConnParameters("Add1", "Add1", 50, GenericDataType.String, ParameterDirection.Input, obj.Add1));
                list.Add(SqlConnManager.GetConnParameters("Add2", "Add2", 50, GenericDataType.String, ParameterDirection.Input, obj.Add2));
                list.Add(SqlConnManager.GetConnParameters("Add3", "Add3", 50, GenericDataType.String, ParameterDirection.Input, obj.Add3));
                list.Add(SqlConnManager.GetConnParameters("Area", "Area", 30, GenericDataType.String, ParameterDirection.Input, obj.Area));
                list.Add(SqlConnManager.GetConnParameters("City", "City", 20, GenericDataType.String, ParameterDirection.Input, obj.City));
                list.Add(SqlConnManager.GetConnParameters("PinCode", "PinCode", 10, GenericDataType.String, ParameterDirection.Input, obj.PinCode));
                list.Add(SqlConnManager.GetConnParameters("KeyPerson", "KeyPerson", 50, GenericDataType.String, ParameterDirection.Input, obj.KeyPerson));
                list.Add(SqlConnManager.GetConnParameters("PhoneNo", "PhoneNo", 35, GenericDataType.String, ParameterDirection.Input, obj.PhoneNo));
                list.Add(SqlConnManager.GetConnParameters("Email", "Email", 50, GenericDataType.String, ParameterDirection.Input, obj.Email));
                list.Add(SqlConnManager.GetConnParameters("VatNo", "VatNo", 20, GenericDataType.String, ParameterDirection.Input, obj.VatNo));
                list.Add(SqlConnManager.GetConnParameters("VatDate", "VatDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VatDate));
                list.Add(SqlConnManager.GetConnParameters("CSTVatNo", "CSTVatNo", 20, GenericDataType.String, ParameterDirection.Input, obj.CSTVatNo));
                list.Add(SqlConnManager.GetConnParameters("CSTVatDate", "CSTVatDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CSTVatDate));
                list.Add(SqlConnManager.GetConnParameters("DlNo1", "DlNo1", 50, GenericDataType.String, ParameterDirection.Input, obj.DlNo1));
                list.Add(SqlConnManager.GetConnParameters("DlNo2", "DlNo2", 50, GenericDataType.String, ParameterDirection.Input, obj.DlNo2));
                list.Add(SqlConnManager.GetConnParameters("RegKey", "RegKey", 25, GenericDataType.String, ParameterDirection.Input, obj.RegKey));
                list.Add(SqlConnManager.GetConnParameters("DataPath", "DataPath", 8, GenericDataType.String, ParameterDirection.Input, obj.DataPath));
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
