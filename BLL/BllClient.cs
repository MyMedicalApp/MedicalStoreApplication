 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using DAL;
 using MedicalApp.Model;
    
namespace BLL
{    
    public class BllClient
    {
        private DataAccessHelper objDAL = new DataAccessHelper();
        public List<T> GetList<T>(DataSourceTypes DataSourceTypes, T objFilter) where T: class, IModel, new()
        {
            List<T> list = new List<T>();
            switch (DataSourceTypes)
            {
                case Common.DataSourceTypes.GenericMasterList:
                    objDAL.GetListGenericMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.DoctorMasterList:
                    objDAL.GetListDoctorMaster(objFilter, ref list);
                    break;
            }
            return list;
        }
        public DataBaseResultSet Save<T>(DataSourceTypes DataSourceTypes, T objFilter) where T : class, IModel, new()
        {
            DataBaseResultSet nResult = new DataBaseResultSet();
            switch (DataSourceTypes)
            {
                case Common.DataSourceTypes.T_ErrorDescSave :
                    nResult = objDAL.SaveT_ErrorDesc(objFilter);
                    break;
                case Common.DataSourceTypes.GenericMasterSave:
                    nResult = objDAL.SaveGenericMaster(objFilter);
                    break;
                case Common.DataSourceTypes.DoctorMasterSave:
                    nResult = objDAL.SaveDoctorMaster(objFilter);
                    break;
            }

            if (nResult.ErrorCode != 0)
            {
                checkAndWriteDatabaseException<T>(objFilter, nResult, DataSourceTypes);
            }

            return nResult;
        }

        private void checkAndWriteDatabaseException<T>(T objData, DataBaseResultSet DBSet, DataSourceTypes DST) where T : class, IModel, new()
        {
            T_ErrorDesc objErrorData = WriteServiceErrorLog.GetErrorLog(DBSet, DST, objData.GetXmlString());
            string sMsg = string.Empty;
            DataBaseResultSet DBSetSaveError = objDAL.SaveT_ErrorDesc(objData);
        }
        
        public static BllClient objBllClient = new BllClient();
    }
}
