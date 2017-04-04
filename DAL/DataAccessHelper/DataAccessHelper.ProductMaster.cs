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
            public void GetListProductMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListProductMaster";
                ProductMaster objData = objFilter as ProductMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.ProductCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillProductMasterDataFromReader, ref  listData);
            }

            public void GetAllListProduct<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "sprocGetAllListProduct";
                ProductMaster objData = objFilter as ProductMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.ProductCode));
                SqlConnManager.GetList<T>(sQuery, CommandType.StoredProcedure, list.ToArray(), FillProductMasterDataFromReader, ref  listData);
            }
            private void FillProductMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    ProductMaster objData = obj as ProductMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveProductMaster<T>(T objData) where T : class, IModel, new()
            {
                ProductMaster obj = objData as ProductMaster;
                string sQuery = "sprocProductMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.ProductCode));
                list.Add(SqlConnManager.GetConnParameters("ICode", "ICode", 50, GenericDataType.String, ParameterDirection.Input, obj.ICode));
                list.Add(SqlConnManager.GetConnParameters("ProductName", "ProductName", 50, GenericDataType.String, ParameterDirection.Input, obj.ProductName));
                list.Add(SqlConnManager.GetConnParameters("Packing", "Packing", 50, GenericDataType.String, ParameterDirection.Input, obj.Packing));
                list.Add(SqlConnManager.GetConnParameters("PackingType", "PackingType", 50, GenericDataType.String, ParameterDirection.Input, obj.PackingType));
                list.Add(SqlConnManager.GetConnParameters("ConversionUnit", "ConversionUnit", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ConversionUnit));
                list.Add(SqlConnManager.GetConnParameters("CompanyTag", "CompanyTag", 50, GenericDataType.String, ParameterDirection.Input, obj.CompanyTag));
                list.Add(SqlConnManager.GetConnParameters("CompanyCode", "CompanyCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CompanyCode));
                list.Add(SqlConnManager.GetConnParameters("CategoryCode", "CategoryCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CategoryCode));
                list.Add(SqlConnManager.GetConnParameters("GenericCode", "GenericCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.GenericCode));
                list.Add(SqlConnManager.GetConnParameters("Rate", "Rate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Rate));
                list.Add(SqlConnManager.GetConnParameters("SplRate", "SplRate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SplRate));
                list.Add(SqlConnManager.GetConnParameters("DiscYN", "DiscYN", 50, GenericDataType.String, ParameterDirection.Input, obj.DiscYN));
                list.Add(SqlConnManager.GetConnParameters("Discount", "Discount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Discount));
                list.Add(SqlConnManager.GetConnParameters("Inclusive", "Inclusive", 50, GenericDataType.String, ParameterDirection.Input, obj.Inclusive));
                list.Add(SqlConnManager.GetConnParameters("VatOn", "VatOn", 50, GenericDataType.String, ParameterDirection.Input, obj.VatOn));
                list.Add(SqlConnManager.GetConnParameters("Vat", "Vat", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Vat));
                list.Add(SqlConnManager.GetConnParameters("AdVat", "AdVat", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.AdVat));
                list.Add(SqlConnManager.GetConnParameters("CST", "CST", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CST));
                list.Add(SqlConnManager.GetConnParameters("BarPrint", "BarPrint", 50, GenericDataType.String, ParameterDirection.Input, obj.BarPrint));
                list.Add(SqlConnManager.GetConnParameters("BarCode", "BarCode", 13, GenericDataType.String, ParameterDirection.Input, obj.BarCode));
                list.Add(SqlConnManager.GetConnParameters("MinQty", "MinQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.MinQty));
                list.Add(SqlConnManager.GetConnParameters("MaxQty", "MaxQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.MaxQty));
                list.Add(SqlConnManager.GetConnParameters("ReOrderQty", "ReOrderQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ReOrderQty));
                list.Add(SqlConnManager.GetConnParameters("RackID", "RackID", 50, GenericDataType.String, ParameterDirection.Input, obj.RackID));
                list.Add(SqlConnManager.GetConnParameters("TStk", "TStk", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.TStk));
                list.Add(SqlConnManager.GetConnParameters("LPurRs", "LPurRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.LPurRs));
                list.Add(SqlConnManager.GetConnParameters("ImageName", "ImageName", 50, GenericDataType.String, ParameterDirection.Input, obj.ImageName));
                list.Add(SqlConnManager.GetConnParameters("Scheme", "Scheme", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Scheme));
                list.Add(SqlConnManager.GetConnParameters("SQty", "SQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SQty));
                list.Add(SqlConnManager.GetConnParameters("SFQty", "SFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SFQty));
                list.Add(SqlConnManager.GetConnParameters("NDRX", "NDRX", 3, GenericDataType.String, ParameterDirection.Input, obj.NDRX));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("LCode", "LCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.LCode));
                list.Add(SqlConnManager.GetConnParameters("SaleCatCode", "SaleCatCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.SaleCatCode));
                list.Add(SqlConnManager.GetConnParameters("OldProductCode", "OldProductCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.OldProductCode));
                list.Add(SqlConnManager.GetConnParameters("DoctorCode", "DoctorCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.DoctorCode));
                list.Add(SqlConnManager.GetConnParameters("DLock", "DLock", 3, GenericDataType.String, ParameterDirection.Input, obj.DLock));
                list.Add(SqlConnManager.GetConnParameters("SchDrg", "SchDrg", 10, GenericDataType.String, ParameterDirection.Input, obj.SchDrg));
                list.Add(SqlConnManager.GetConnParameters("Note1", "Note1", 200, GenericDataType.String, ParameterDirection.Input, obj.Note1));
                list.Add(SqlConnManager.GetConnParameters("Fav", "Fav", 3, GenericDataType.String, ParameterDirection.Input, obj.Fav));
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
