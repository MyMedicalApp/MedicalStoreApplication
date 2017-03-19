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
            public void GetListBranchStock<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListBranchStock";
                BranchStock objData = objFilter as BranchStock;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillBranchStockDataFromReader, ref  listData);
            }
            
            private void FillBranchStockDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    BranchStock objData = obj as BranchStock;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveBranchStock<T>(T objData) where T : class, IModel, new()
            {
                BranchStock obj = objData as BranchStock;
                string sQuery = "sprocBranchStockInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("BranchName", "BranchName", 50, GenericDataType.String, ParameterDirection.Input, obj.BranchName));
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.ProductCode));
                list.Add(SqlConnManager.GetConnParameters("PartyPrdCode", "PartyPrdCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.PartyPrdCode));
                list.Add(SqlConnManager.GetConnParameters("ProductName", "ProductName", 50, GenericDataType.String, ParameterDirection.Input, obj.ProductName));
                list.Add(SqlConnManager.GetConnParameters("Packing", "Packing", 50, GenericDataType.String, ParameterDirection.Input, obj.Packing));
                list.Add(SqlConnManager.GetConnParameters("CompanyTag", "CompanyTag", 50, GenericDataType.String, ParameterDirection.Input, obj.CompanyTag));
                list.Add(SqlConnManager.GetConnParameters("RackID", "RackID", 50, GenericDataType.String, ParameterDirection.Input, obj.RackID));
                list.Add(SqlConnManager.GetConnParameters("TStk", "TStk", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.TStk));
                list.Add(SqlConnManager.GetConnParameters("Scheme", "Scheme", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Scheme));
                list.Add(SqlConnManager.GetConnParameters("SQty", "SQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SQty));
                list.Add(SqlConnManager.GetConnParameters("SFQty", "SFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SFQty));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("BranchCode", "BranchCode", 10, GenericDataType.String, ParameterDirection.Input, obj.BranchCode));
                list.Add(SqlConnManager.GetConnParameters("UDateTime", "UDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.UDateTime));
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
