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
            public void GetListPrintFormat<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListPrintFormat";
                PrintFormat objData = objFilter as PrintFormat;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, objData.RecNo));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillPrintFormatDataFromReader, ref  listData);
            }
            
            private void FillPrintFormatDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    PrintFormat objData = obj as PrintFormat;
                    obj.FillDataFromDB(DbReader);
                    listData.Add(obj);
                }
            }
  
            public DataBaseResultSet SavePrintFormat<T>(T objData) where T : class, IModel, new()
            {
                PrintFormat obj = objData as PrintFormat;
                string sQuery = "sprocPrintFormatInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("RecNo", "RecNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.RecNo));
                list.Add(SqlConnManager.GetConnParameters("LabelType", "LabelType", 50, GenericDataType.String, ParameterDirection.Input, obj.LabelType));
                list.Add(SqlConnManager.GetConnParameters("OprtSys", "OprtSys", 50, GenericDataType.String, ParameterDirection.Input, obj.OprtSys));
                list.Add(SqlConnManager.GetConnParameters("FormatName", "FormatName", 50, GenericDataType.String, ParameterDirection.Input, obj.FormatName));
                list.Add(SqlConnManager.GetConnParameters("PrinterName", "PrinterName", 50, GenericDataType.String, ParameterDirection.Input, obj.PrinterName));
                list.Add(SqlConnManager.GetConnParameters("TxtType", "TxtType", 50, GenericDataType.String, ParameterDirection.Input, obj.TxtType));
                list.Add(SqlConnManager.GetConnParameters("SampleTxt", "SampleTxt", 200, GenericDataType.String, ParameterDirection.Input, obj.SampleTxt));
                list.Add(SqlConnManager.GetConnParameters("FPrefix", "FPrefix", 50, GenericDataType.String, ParameterDirection.Input, obj.FPrefix));
                list.Add(SqlConnManager.GetConnParameters("FldName", "FldName", 50, GenericDataType.String, ParameterDirection.Input, obj.FldName));
                list.Add(SqlConnManager.GetConnParameters("FSufix", "FSufix", 50, GenericDataType.String, ParameterDirection.Input, obj.FSufix));
                list.Add(SqlConnManager.GetConnParameters("PrntFormat", "PrntFormat", 50, GenericDataType.String, ParameterDirection.Input, obj.PrntFormat));
                list.Add(SqlConnManager.GetConnParameters("PosX", "PosX", 8, GenericDataType.Long, ParameterDirection.Input, obj.PosX));
                list.Add(SqlConnManager.GetConnParameters("PosY", "PosY", 8, GenericDataType.Long, ParameterDirection.Input, obj.PosY));
                list.Add(SqlConnManager.GetConnParameters("PWidth", "PWidth", 8, GenericDataType.Long, ParameterDirection.Input, obj.PWidth));
                list.Add(SqlConnManager.GetConnParameters("PHeight", "PHeight", 8, GenericDataType.Long, ParameterDirection.Input, obj.PHeight));
                list.Add(SqlConnManager.GetConnParameters("FntName", "FntName", 50, GenericDataType.String, ParameterDirection.Input, obj.FntName));
                list.Add(SqlConnManager.GetConnParameters("FntStyle", "FntStyle", 50, GenericDataType.String, ParameterDirection.Input, obj.FntStyle));
                list.Add(SqlConnManager.GetConnParameters("FntBold", "FntBold", 3, GenericDataType.String, ParameterDirection.Input, obj.FntBold));
                list.Add(SqlConnManager.GetConnParameters("FntItalic", "FntItalic", 3, GenericDataType.String, ParameterDirection.Input, obj.FntItalic));
                list.Add(SqlConnManager.GetConnParameters("FntStrikout", "FntStrikout", 3, GenericDataType.String, ParameterDirection.Input, obj.FntStrikout));
                list.Add(SqlConnManager.GetConnParameters("FntUnderLine", "FntUnderLine", 3, GenericDataType.String, ParameterDirection.Input, obj.FntUnderLine));
                list.Add(SqlConnManager.GetConnParameters("FntSize", "FntSize", 8, GenericDataType.Long, ParameterDirection.Input, obj.FntSize));
                list.Add(SqlConnManager.GetConnParameters("FntColor", "FntColor", 8, GenericDataType.Long, ParameterDirection.Input, obj.FntColor));
                list.Add(SqlConnManager.GetConnParameters("AcrossLbl", "AcrossLbl", 8, GenericDataType.Long, ParameterDirection.Input, obj.AcrossLbl));
                list.Add(SqlConnManager.GetConnParameters("PgLbl", "PgLbl", 8, GenericDataType.Long, ParameterDirection.Input, obj.PgLbl));
                list.Add(SqlConnManager.GetConnParameters("DuplicateLbl", "DuplicateLbl", 3, GenericDataType.String, ParameterDirection.Input, obj.DuplicateLbl));
                list.Add(SqlConnManager.GetConnParameters("PgTopMargin", "PgTopMargin", 8, GenericDataType.Long, ParameterDirection.Input, obj.PgTopMargin));
                list.Add(SqlConnManager.GetConnParameters("PgLeftMargin", "PgLeftMargin", 8, GenericDataType.Long, ParameterDirection.Input, obj.PgLeftMargin));
                list.Add(SqlConnManager.GetConnParameters("LblVerticalGap", "LblVerticalGap", 8, GenericDataType.Long, ParameterDirection.Input, obj.LblVerticalGap));
                list.Add(SqlConnManager.GetConnParameters("LblHorizontalGap", "LblHorizontalGap", 8, GenericDataType.Long, ParameterDirection.Input, obj.LblHorizontalGap));
                list.Add(SqlConnManager.GetConnParameters("LblWidth", "LblWidth", 8, GenericDataType.Long, ParameterDirection.Input, obj.LblWidth));
                list.Add(SqlConnManager.GetConnParameters("LblHeight", "LblHeight", 8, GenericDataType.Long, ParameterDirection.Input, obj.LblHeight));
                list.Add(SqlConnManager.GetConnParameters("NoOfLine", "NoOfLine", 8, GenericDataType.Long, ParameterDirection.Input, obj.NoOfLine));
                list.Add(SqlConnManager.GetConnParameters("GapLine", "GapLine", 8, GenericDataType.Long, ParameterDirection.Input, obj.GapLine));
                list.Add(SqlConnManager.GetConnParameters("CUser", "CUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.CUser));
                list.Add(SqlConnManager.GetConnParameters("CDateTime", "CDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.CDateTime));
                list.Add(SqlConnManager.GetConnParameters("EUser", "EUser", 8, GenericDataType.Long, ParameterDirection.Input, obj.EUser));
                list.Add(SqlConnManager.GetConnParameters("EDateTime", "EDateTime", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EDateTime));
                list.Add(SqlConnManager.GetConnParameters("PrintStyle", "PrintStyle", 50, GenericDataType.String, ParameterDirection.Input, obj.PrintStyle));
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
