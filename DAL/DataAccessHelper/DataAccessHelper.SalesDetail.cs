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
            public void GetListSalesDetail<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListSalesDetail";
                SalesDetail objData = objFilter as SalesDetail;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillSalesDetailDataFromReader, ref  listData);
            }
            
            private void FillSalesDetailDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    SalesDetail objData = obj as SalesDetail;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveSalesDetail<T>(T objData) where T : class, IModel, new()
            {
                SalesDetail obj = objData as SalesDetail;
                string sQuery = "sprocSalesDetailInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("BillTag", "BillTag", 20, GenericDataType.String, ParameterDirection.Input, obj.BillTag));
                list.Add(SqlConnManager.GetConnParameters("BillType", "BillType", 20, GenericDataType.String, ParameterDirection.Input, obj.BillType));
                list.Add(SqlConnManager.GetConnParameters("BillCredit", "BillCredit", 10, GenericDataType.String, ParameterDirection.Input, obj.BillCredit));
                list.Add(SqlConnManager.GetConnParameters("BillSeries", "BillSeries", 1, GenericDataType.String, ParameterDirection.Input, obj.BillSeries));
                list.Add(SqlConnManager.GetConnParameters("BillNo", "BillNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.BillNo));
                list.Add(SqlConnManager.GetConnParameters("BillDate", "BillDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.BillDate));
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("ChallanNo", "ChallanNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.ChallanNo));
                list.Add(SqlConnManager.GetConnParameters("ChallanDate", "ChallanDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.ChallanDate));
                list.Add(SqlConnManager.GetConnParameters("EntryTag", "EntryTag", 8, GenericDataType.String, ParameterDirection.Input, obj.EntryTag));
                list.Add(SqlConnManager.GetConnParameters("ProductCode", "ProductCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.ProductCode));
                list.Add(SqlConnManager.GetConnParameters("CompanyCode", "CompanyCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CompanyCode));
                list.Add(SqlConnManager.GetConnParameters("BatchCode", "BatchCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.BatchCode));
                list.Add(SqlConnManager.GetConnParameters("RateTag", "RateTag", 10, GenericDataType.String, ParameterDirection.Input, obj.RateTag));
                list.Add(SqlConnManager.GetConnParameters("MRP", "MRP", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.MRP));
                list.Add(SqlConnManager.GetConnParameters("BatchNo", "BatchNo", 15, GenericDataType.String, ParameterDirection.Input, obj.BatchNo));
                list.Add(SqlConnManager.GetConnParameters("Expiry", "Expiry", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.Expiry));
                list.Add(SqlConnManager.GetConnParameters("Qty", "Qty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Qty));
                list.Add(SqlConnManager.GetConnParameters("FQty", "FQty", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.FQty));
                list.Add(SqlConnManager.GetConnParameters("ConversionUnit", "ConversionUnit", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ConversionUnit));
                list.Add(SqlConnManager.GetConnParameters("Rate", "Rate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Rate));
                list.Add(SqlConnManager.GetConnParameters("HalfScheme", "HalfScheme", 3, GenericDataType.String, ParameterDirection.Input, obj.HalfScheme));
                list.Add(SqlConnManager.GetConnParameters("Scheme", "Scheme", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Scheme));
                list.Add(SqlConnManager.GetConnParameters("SchemeRs", "SchemeRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SchemeRs));
                list.Add(SqlConnManager.GetConnParameters("SplDisc", "SplDisc", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SplDisc));
                list.Add(SqlConnManager.GetConnParameters("SplDiscRs", "SplDiscRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SplDiscRs));
                list.Add(SqlConnManager.GetConnParameters("Disc", "Disc", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Disc));
                list.Add(SqlConnManager.GetConnParameters("DiscRs", "DiscRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.DiscRs));
                list.Add(SqlConnManager.GetConnParameters("Inclusive", "Inclusive", 3, GenericDataType.String, ParameterDirection.Input, obj.Inclusive));
                list.Add(SqlConnManager.GetConnParameters("VatOn", "VatOn", 5, GenericDataType.String, ParameterDirection.Input, obj.VatOn));
                list.Add(SqlConnManager.GetConnParameters("Vat", "Vat", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Vat));
                list.Add(SqlConnManager.GetConnParameters("VatRs", "VatRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.VatRs));
                list.Add(SqlConnManager.GetConnParameters("AdVat", "AdVat", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.AdVat));
                list.Add(SqlConnManager.GetConnParameters("AdVatRs", "AdVatRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.AdVatRs));
                list.Add(SqlConnManager.GetConnParameters("DiscYN", "DiscYN", 3, GenericDataType.String, ParameterDirection.Input, obj.DiscYN));
                list.Add(SqlConnManager.GetConnParameters("NetRate", "NetRate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.NetRate));
                list.Add(SqlConnManager.GetConnParameters("VatOnFree", "VatOnFree", 3, GenericDataType.String, ParameterDirection.Input, obj.VatOnFree));
                list.Add(SqlConnManager.GetConnParameters("NetCostRate", "NetCostRate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.NetCostRate));
                list.Add(SqlConnManager.GetConnParameters("NetAmount", "NetAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.NetAmount));
                list.Add(SqlConnManager.GetConnParameters("PurRs", "PurRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.PurRs));
                list.Add(SqlConnManager.GetConnParameters("VarifyBy", "VarifyBy", 8, GenericDataType.Long, ParameterDirection.Input, obj.VarifyBy));
                list.Add(SqlConnManager.GetConnParameters("VarifyDate", "VarifyDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VarifyDate));
                list.Add(SqlConnManager.GetConnParameters("NodeName", "NodeName", 8, GenericDataType.String, ParameterDirection.Input, obj.NodeName));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("Narration", "Narration", 10, GenericDataType.String, ParameterDirection.Input, obj.Narration));
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
