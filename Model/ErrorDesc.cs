 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class ErrorDesc : IModel,INotifyPropertyChanged
    {
        private int     nErrorId;
        public int     ErrorId
        {
            get { return nErrorId; }
            set
            {
                nErrorId = value;
                OnPropertyChanged("ErrorId");
            }
        }
        private int     nCategoryID;
        public int     CategoryID
        {
            get { return nCategoryID; }
            set
            {
                nCategoryID = value;
                OnPropertyChanged("CategoryID");
            }
        }
        private int     nPageCode;
        public int     PageCode
        {
            get { return nPageCode; }
            set
            {
                nPageCode = value;
                OnPropertyChanged("PageCode");
            }
        }
        private int     nMethodCode;
        public int     MethodCode
        {
            get { return nMethodCode; }
            set
            {
                nMethodCode = value;
                OnPropertyChanged("MethodCode");
            }
        }
        private int     nEventCode;
        public int     EventCode
        {
            get { return nEventCode; }
            set
            {
                nEventCode = value;
                OnPropertyChanged("EventCode");
            }
        }
        private int     nErrorLineNo;
        public int     ErrorLineNo
        {
            get { return nErrorLineNo; }
            set
            {
                nErrorLineNo = value;
                OnPropertyChanged("ErrorLineNo");
            }
        }
        private string     sMethodTrace;
        public string     MethodTrace
        {
            get { return sMethodTrace; }
            set
            {
                sMethodTrace = value;
                OnPropertyChanged("MethodTrace");
            }
        }
        private string     sEmpNo;
        public string     EmpNo
        {
            get { return sEmpNo; }
            set
            {
                sEmpNo = value;
                OnPropertyChanged("EmpNo");
            }
        }
        private string     sClientIpAddress;
        public string     ClientIpAddress
        {
            get { return sClientIpAddress; }
            set
            {
                sClientIpAddress = value;
                OnPropertyChanged("ClientIpAddress");
            }
        }
        private string     sPageName;
        public string     PageName
        {
            get { return sPageName; }
            set
            {
                sPageName = value;
                OnPropertyChanged("PageName");
            }
        }
        private string     sMethodName;
        public string     MethodName
        {
            get { return sMethodName; }
            set
            {
                sMethodName = value;
                OnPropertyChanged("MethodName");
            }
        }
        private string     sErrorMsg;
        public string     ErrorMsg
        {
            get { return sErrorMsg; }
            set
            {
                sErrorMsg = value;
                OnPropertyChanged("ErrorMsg");
            }
        }
        private DateTime     dtErrorDate;
        public DateTime     ErrorDate
        {
            get { return dtErrorDate; }
            set
            {
                dtErrorDate = value;
                OnPropertyChanged("ErrorDate");
            }
        }
        private string     sErrorData;
        public string     ErrorData
        {
            get { return sErrorData; }
            set
            {
                sErrorData = value;
                OnPropertyChanged("ErrorData");
            }
        }
        private string     sErrorType;
        public string     ErrorType
        {
            get { return sErrorType; }
            set
            {
                sErrorType = value;
                OnPropertyChanged("ErrorType");
            }
        }
        public DataBaseOperation OperationFlag { get; set; }
        #region INotifyPropertyChanged Members
            /// <summary>
            /// Event to which the view's controls will subscribe.
            /// This will enable them to refresh themselves when the binded property changes provided you fire this event.
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;
        
            /// <summary>
            /// When property is changed call this method to fire the PropertyChanged Event
            /// </summary>
            /// <param name="propertyName"></param>
            public void OnPropertyChanged(string propertyName)
            {
                //Fire the PropertyChanged event in case somebody subscribed to it
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        
        #endregion
    
        #region IViewDetail Members
            public void FillDataFromDB(IDataRecord DBReader)
            {
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ErrorId"))){
                    this.ErrorId = DBReader.GetInt32(DBReader.GetOrdinal("ErrorId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CategoryID"))){
                    this.CategoryID = DBReader.GetInt32(DBReader.GetOrdinal("CategoryID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PageCode"))){
                    this.PageCode = DBReader.GetInt32(DBReader.GetOrdinal("PageCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MethodCode"))){
                    this.MethodCode = DBReader.GetInt32(DBReader.GetOrdinal("MethodCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EventCode"))){
                    this.EventCode = DBReader.GetInt32(DBReader.GetOrdinal("EventCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ErrorLineNo"))){
                    this.ErrorLineNo = DBReader.GetInt32(DBReader.GetOrdinal("ErrorLineNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MethodTrace"))){
                    this.MethodTrace = DBReader.GetString(DBReader.GetOrdinal("MethodTrace"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EmpNo"))){
                    this.EmpNo = DBReader.GetString(DBReader.GetOrdinal("EmpNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ClientIpAddress"))){
                    this.ClientIpAddress = DBReader.GetString(DBReader.GetOrdinal("ClientIpAddress"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PageName"))){
                    this.PageName = DBReader.GetString(DBReader.GetOrdinal("PageName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MethodName"))){
                    this.MethodName = DBReader.GetString(DBReader.GetOrdinal("MethodName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ErrorMsg"))){
                    this.ErrorMsg = DBReader.GetString(DBReader.GetOrdinal("ErrorMsg"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ErrorDate"))){
                    this.ErrorDate = DBReader.GetDateTime(DBReader.GetOrdinal("ErrorDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ErrorData"))){
                    this.ErrorData = DBReader.GetString(DBReader.GetOrdinal("ErrorData"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ErrorType"))){
                    this.ErrorType = DBReader.GetString(DBReader.GetOrdinal("ErrorType"));
                }
            }
        #endregion
  
        public string GetXmlString()
        {  
            StringBuilder sXml = new StringBuilder();  
            sXml.Append("<data>");
            sXml.Append("<ErrorId>" + this.ErrorId + "</ErrorId>");
            sXml.Append("<CategoryID>" + this.CategoryID + "</CategoryID>");
            sXml.Append("<PageCode>" + this.PageCode + "</PageCode>");
            sXml.Append("<MethodCode>" + this.MethodCode + "</MethodCode>");
            sXml.Append("<EventCode>" + this.EventCode + "</EventCode>");
            sXml.Append("<ErrorLineNo>" + this.ErrorLineNo + "</ErrorLineNo>");
            sXml.Append("<MethodTrace>" + this.MethodTrace + "</MethodTrace>");
            sXml.Append("<EmpNo>" + this.EmpNo + "</EmpNo>");
            sXml.Append("<ClientIpAddress>" + this.ClientIpAddress + "</ClientIpAddress>");
            sXml.Append("<PageName>" + this.PageName + "</PageName>");
            sXml.Append("<MethodName>" + this.MethodName + "</MethodName>");
            sXml.Append("<ErrorMsg>" + this.ErrorMsg + "</ErrorMsg>");
            sXml.Append("<ErrorDate>" + this.ErrorDate + "</ErrorDate>");
            sXml.Append("<ErrorData>" + this.ErrorData + "</ErrorData>");
            sXml.Append("<ErrorType>" + this.ErrorType + "</ErrorType>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            ErrorDesc objdata = obj as ErrorDesc;
            this.ErrorId = objdata.ErrorId;
            this.CategoryID = objdata.CategoryID;
            this.PageCode = objdata.PageCode;
            this.MethodCode = objdata.MethodCode;
            this.EventCode = objdata.EventCode;
            this.ErrorLineNo = objdata.ErrorLineNo;
            this.MethodTrace = objdata.MethodTrace;
            this.EmpNo = objdata.EmpNo;
            this.ClientIpAddress = objdata.ClientIpAddress;
            this.PageName = objdata.PageName;
            this.MethodName = objdata.MethodName;
            this.ErrorMsg = objdata.ErrorMsg;
            this.ErrorDate = objdata.ErrorDate;
            this.ErrorData = objdata.ErrorData;
            this.ErrorType = objdata.ErrorType;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            ErrorDesc objdata = obj as ErrorDesc;
            objdata.ErrorId = this.ErrorId;
            objdata.CategoryID = this.CategoryID;
            objdata.PageCode = this.PageCode;
            objdata.MethodCode = this.MethodCode;
            objdata.EventCode = this.EventCode;
            objdata.ErrorLineNo = this.ErrorLineNo;
            objdata.MethodTrace = this.MethodTrace;
            objdata.EmpNo = this.EmpNo;
            objdata.ClientIpAddress = this.ClientIpAddress;
            objdata.PageName = this.PageName;
            objdata.MethodName = this.MethodName;
            objdata.ErrorMsg = this.ErrorMsg;
            objdata.ErrorDate = this.ErrorDate;
            objdata.ErrorData = this.ErrorData;
            objdata.ErrorType = this.ErrorType;
            return obj; 
        }  

        public void ResetData()
        {  
            this.ErrorId = 0;
            this.CategoryID = 0;
            this.PageCode = 0;
            this.MethodCode = 0;
            this.EventCode = 0;
            this.ErrorLineNo = 0;
            this.MethodTrace = string.Empty;;
            this.EmpNo = string.Empty;;
            this.ClientIpAddress = string.Empty;;
            this.PageName = string.Empty;;
            this.MethodName = string.Empty;;
            this.ErrorMsg = string.Empty;;
            this.ErrorDate = new DateTime();
            this.ErrorData = string.Empty;;
            this.ErrorType = string.Empty;;
        }  

    }  
}
