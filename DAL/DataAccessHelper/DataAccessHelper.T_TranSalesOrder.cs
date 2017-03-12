 using System;                        
 using System.Collections.Generic;    
 using System.Linq;                   
 using System.Text;                   
 using System.Data.Common;            
 using System.Data;                   
 using Common;                        
 using TextileAppModel;                      
 using System.Data.Common;              
 using System.Data;                     
                                
namespace DAL
{    
     public partial class DataAccessHelper
     {    
            public void GetListT_TranSalesOrder<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_TranSalesOrder";
                T_TranSalesOrder objData = objFilter as T_TranSalesOrder;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranSalesOrderId", "TranSalesOrderId", 8, GenericDataType.Long, ParameterDirection.Input, objData.TranSalesOrderId));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Long, ParameterDirection.Input, objData.CompanyId));
                SqlConnManager.GetList<T>(sQuery, CommandType.StoredProcedure, list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_TranSalesOrder<T>(T objData) where T : class, IModel, new()
            {
                T_TranSalesOrder obj = objData as T_TranSalesOrder;
                string sQuery = "sprocT_TranSalesOrderInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranSalesOrderId", "TranSalesOrderId", 8, GenericDataType.Long, ParameterDirection.Input, obj.TranSalesOrderId));
                list.Add(SqlConnManager.GetConnParameters("ConfirmationNo", "ConfirmationNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.ConfirmationNo));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("CurrDate", "CurrDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CurrDate));
                list.Add(SqlConnManager.GetConnParameters("PartyId", "PartyId", 8, GenericDataType.Long, ParameterDirection.Input, obj.PartyId));
                list.Add(SqlConnManager.GetConnParameters("WeaverCode", "WeaverCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.WeaverCode));
                list.Add(SqlConnManager.GetConnParameters("QualityCode", "QualityCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.QualityCode));
                list.Add(SqlConnManager.GetConnParameters("BrokerCode", "BrokerCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.BrokerCode));
                list.Add(SqlConnManager.GetConnParameters("ThanCount", "ThanCount", 4, GenericDataType.Int, ParameterDirection.Input, obj.ThanCount));
                list.Add(SqlConnManager.GetConnParameters("Rate", "Rate", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Rate));
                list.Add(SqlConnManager.GetConnParameters("Side", "Side", 50, GenericDataType.String, ParameterDirection.Input, obj.Side));
                list.Add(SqlConnManager.GetConnParameters("CD", "CD", 50, GenericDataType.String, ParameterDirection.Input, obj.CD));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("PrimKeyId", "PrimKeyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.PrimKeyTableId));                
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
