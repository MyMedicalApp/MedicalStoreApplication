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
            public void GetListBatchMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListBatchMaster";
                BatchMaster objData = objFilter as BatchMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("BatchCode", "BatchCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.BatchCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillBatchMasterDataFromReader, ref  listData);
            }
            
            private void FillBatchMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    BatchMaster objData = obj as BatchMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveBatchMaster<T>(T objData) where T : class, IModel, new()
            {
                BatchMaster obj = objData as BatchMaster;
                string sQuery = "sprocBatchMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("BatchCode", "BatchCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.BatchCode));
                list.Add(SqlConnManager.GetConnParameters("ICode", "ICode", 13, GenericDataType.String, ParameterDirection.Input, obj.ICode));
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.ProductCode));
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("MRP", "MRP", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.MRP));
                list.Add(SqlConnManager.GetConnParameters("BatchNo", "BatchNo", 15, GenericDataType.String, ParameterDirection.Input, obj.BatchNo));
                list.Add(SqlConnManager.GetConnParameters("Expiry", "Expiry", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.Expiry));
                list.Add(SqlConnManager.GetConnParameters("Inclusive", "Inclusive", 3, GenericDataType.String, ParameterDirection.Input, obj.Inclusive));
                list.Add(SqlConnManager.GetConnParameters("VatOn", "VatOn", 5, GenericDataType.String, ParameterDirection.Input, obj.VatOn));
                list.Add(SqlConnManager.GetConnParameters("Vat", "Vat", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Vat));
                list.Add(SqlConnManager.GetConnParameters("AdVat", "AdVat", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.AdVat));
                list.Add(SqlConnManager.GetConnParameters("Octroi", "Octroi", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Octroi));
                list.Add(SqlConnManager.GetConnParameters("PurRs", "PurRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PurRs));
                list.Add(SqlConnManager.GetConnParameters("SaleRs", "SaleRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SaleRs));
                list.Add(SqlConnManager.GetConnParameters("NetRate", "NetRate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.NetRate));
                list.Add(SqlConnManager.GetConnParameters("StockPt", "StockPt", 8, GenericDataType.Long, ParameterDirection.Input, obj.StockPt));
                list.Add(SqlConnManager.GetConnParameters("OpQty", "OpQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpQty));
                list.Add(SqlConnManager.GetConnParameters("OpQtyRs", "OpQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpQtyRs));
                list.Add(SqlConnManager.GetConnParameters("OpFQty", "OpFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpFQty));
                list.Add(SqlConnManager.GetConnParameters("OpFQtyRs", "OpFQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpFQtyRs));
                list.Add(SqlConnManager.GetConnParameters("PurQty", "PurQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PurQty));
                list.Add(SqlConnManager.GetConnParameters("PurQtyRs", "PurQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PurQtyRs));
                list.Add(SqlConnManager.GetConnParameters("PurFQty", "PurFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PurFQty));
                list.Add(SqlConnManager.GetConnParameters("PurFQtyRs", "PurFQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PurFQtyRs));
                list.Add(SqlConnManager.GetConnParameters("CrQty", "CrQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CrQty));
                list.Add(SqlConnManager.GetConnParameters("CrQtyRs", "CrQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CrQtyRs));
                list.Add(SqlConnManager.GetConnParameters("CrFQty", "CrFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CrFQty));
                list.Add(SqlConnManager.GetConnParameters("CrFQtyRs", "CrFQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CrFQtyRs));
                list.Add(SqlConnManager.GetConnParameters("RcptQty", "RcptQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.RcptQty));
                list.Add(SqlConnManager.GetConnParameters("RcptQtyRs", "RcptQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.RcptQtyRs));
                list.Add(SqlConnManager.GetConnParameters("SaleQty", "SaleQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SaleQty));
                list.Add(SqlConnManager.GetConnParameters("SaleQtyRs", "SaleQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SaleQtyRs));
                list.Add(SqlConnManager.GetConnParameters("SaleFQty", "SaleFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SaleFQty));
                list.Add(SqlConnManager.GetConnParameters("SaleFQtyRs", "SaleFQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SaleFQtyRs));
                list.Add(SqlConnManager.GetConnParameters("IssueQty", "IssueQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.IssueQty));
                list.Add(SqlConnManager.GetConnParameters("IssueQtyRs", "IssueQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.IssueQtyRs));
                list.Add(SqlConnManager.GetConnParameters("ClQty", "ClQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ClQty));
                list.Add(SqlConnManager.GetConnParameters("ClQtyRs", "ClQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ClQtyRs));
                list.Add(SqlConnManager.GetConnParameters("ClFQty", "ClFQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ClFQty));
                list.Add(SqlConnManager.GetConnParameters("ClFQtyRs", "ClFQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ClFQtyRs));
                list.Add(SqlConnManager.GetConnParameters("TQty", "TQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.TQty));
                list.Add(SqlConnManager.GetConnParameters("TQtyRs", "TQtyRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.TQtyRs));
                list.Add(SqlConnManager.GetConnParameters("BarSeries", "BarSeries", 2, GenericDataType.String, ParameterDirection.Input, obj.BarSeries));
                list.Add(SqlConnManager.GetConnParameters("BarCode", "BarCode", 13, GenericDataType.String, ParameterDirection.Input, obj.BarCode));
                list.Add(SqlConnManager.GetConnParameters("BatchHead", "BatchHead", 10, GenericDataType.String, ParameterDirection.Input, obj.BatchHead));
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
