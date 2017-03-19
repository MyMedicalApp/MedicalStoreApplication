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
            public void GetListOBillMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListOBillMaster";
                OBillMaster objData = objFilter as OBillMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillOBillMasterDataFromReader, ref  listData);
            }
            
            private void FillOBillMasterDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    OBillMaster objData = obj as OBillMaster;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SaveOBillMaster<T>(T objData) where T : class, IModel, new()
            {
                OBillMaster obj = objData as OBillMaster;
                string sQuery = "sprocOBillMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("BillTag", "BillTag", 20, GenericDataType.String, ParameterDirection.Input, obj.BillTag));
                list.Add(SqlConnManager.GetConnParameters("BillType", "BillType", 20, GenericDataType.String, ParameterDirection.Input, obj.BillType));
                list.Add(SqlConnManager.GetConnParameters("BillCredit", "BillCredit", 10, GenericDataType.String, ParameterDirection.Input, obj.BillCredit));
                list.Add(SqlConnManager.GetConnParameters("BillSeries", "BillSeries", 1, GenericDataType.String, ParameterDirection.Input, obj.BillSeries));
                list.Add(SqlConnManager.GetConnParameters("BillNo", "BillNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.BillNo));
                list.Add(SqlConnManager.GetConnParameters("BillDate", "BillDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.BillDate));
                list.Add(SqlConnManager.GetConnParameters("PurBillNo", "PurBillNo", 10, GenericDataType.String, ParameterDirection.Input, obj.PurBillNo));
                list.Add(SqlConnManager.GetConnParameters("PurBillDate", "PurBillDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.PurBillDate));
                list.Add(SqlConnManager.GetConnParameters("CustomerCode", "CustomerCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.CustomerCode));
                list.Add(SqlConnManager.GetConnParameters("DoctorCode", "DoctorCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.DoctorCode));
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("SalesmanCode", "SalesmanCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.SalesmanCode));
                list.Add(SqlConnManager.GetConnParameters("VatInRate", "VatInRate", 3, GenericDataType.String, ParameterDirection.Input, obj.VatInRate));
                list.Add(SqlConnManager.GetConnParameters("GrossAmount", "GrossAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.GrossAmount));
                list.Add(SqlConnManager.GetConnParameters("SchemeRs", "SchemeRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SchemeRs));
                list.Add(SqlConnManager.GetConnParameters("SplDiscRs", "SplDiscRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.SplDiscRs));
                list.Add(SqlConnManager.GetConnParameters("DiscPer", "DiscPer", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.DiscPer));
                list.Add(SqlConnManager.GetConnParameters("DiscRs", "DiscRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.DiscRs));
                list.Add(SqlConnManager.GetConnParameters("VatPer", "VatPer", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.VatPer));
                list.Add(SqlConnManager.GetConnParameters("VatRs", "VatRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.VatRs));
                list.Add(SqlConnManager.GetConnParameters("AdVatPer", "AdVatPer", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.AdVatPer));
                list.Add(SqlConnManager.GetConnParameters("AdVatRs", "AdVatRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.AdVatRs));
                list.Add(SqlConnManager.GetConnParameters("CrRs", "CrRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.CrRs));
                list.Add(SqlConnManager.GetConnParameters("OtherAdj", "OtherAdj", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OtherAdj));
                list.Add(SqlConnManager.GetConnParameters("RndOff", "RndOff", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.RndOff));
                list.Add(SqlConnManager.GetConnParameters("NetAmount", "NetAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.NetAmount));
                list.Add(SqlConnManager.GetConnParameters("RateTag", "RateTag", 10, GenericDataType.String, ParameterDirection.Input, obj.RateTag));
                list.Add(SqlConnManager.GetConnParameters("OrdRef", "OrdRef", 20, GenericDataType.String, ParameterDirection.Input, obj.OrdRef));
                list.Add(SqlConnManager.GetConnParameters("ModOfDespatch", "ModOfDespatch", 20, GenericDataType.String, ParameterDirection.Input, obj.ModOfDespatch));
                list.Add(SqlConnManager.GetConnParameters("RRNo", "RRNo", 20, GenericDataType.String, ParameterDirection.Input, obj.RRNo));
                list.Add(SqlConnManager.GetConnParameters("NoOfPack", "NoOfPack", 20, GenericDataType.String, ParameterDirection.Input, obj.NoOfPack));
                list.Add(SqlConnManager.GetConnParameters("DespDate", "DespDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.DespDate));
                list.Add(SqlConnManager.GetConnParameters("SplInst", "SplInst", 50, GenericDataType.String, ParameterDirection.Input, obj.SplInst));
                list.Add(SqlConnManager.GetConnParameters("RcptAmount", "RcptAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.RcptAmount));
                list.Add(SqlConnManager.GetConnParameters("MiscPndAmount", "MiscPndAmount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.MiscPndAmount));
                list.Add(SqlConnManager.GetConnParameters("AdjTag", "AdjTag", 2, GenericDataType.String, ParameterDirection.Input, obj.AdjTag));
                list.Add(SqlConnManager.GetConnParameters("VarifyBy", "VarifyBy", 8, GenericDataType.Long, ParameterDirection.Input, obj.VarifyBy));
                list.Add(SqlConnManager.GetConnParameters("VarifyDate", "VarifyDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VarifyDate));
                list.Add(SqlConnManager.GetConnParameters("NodeName", "NodeName", 8, GenericDataType.String, ParameterDirection.Input, obj.NodeName));
                list.Add(SqlConnManager.GetConnParameters("ShiftNo", "ShiftNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.ShiftNo));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("DueDate", "DueDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.DueDate));
                list.Add(SqlConnManager.GetConnParameters("DelBoyName", "DelBoyName", 8, GenericDataType.Long, ParameterDirection.Input, obj.DelBoyName));
                list.Add(SqlConnManager.GetConnParameters("Narration", "Narration", 50, GenericDataType.String, ParameterDirection.Input, obj.Narration));
                list.Add(SqlConnManager.GetConnParameters("LBT", "LBT", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.LBT));
                list.Add(SqlConnManager.GetConnParameters("LBTRs", "LBTRs", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.LBTRs));
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
