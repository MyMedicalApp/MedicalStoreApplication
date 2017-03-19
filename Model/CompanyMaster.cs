 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class CompanyMaster : IModel,INotifyPropertyChanged
    {
        private long     nCompanyCode;
        public long     CompanyCode
        {
            get { return nCompanyCode; }
            set
            {
                nCompanyCode = value;
                OnPropertyChanged("CompanyCode");
            }
        }
        private string     sICode;
        public string     ICode
        {
            get { return sICode; }
            set
            {
                sICode = value;
                OnPropertyChanged("ICode");
            }
        }
        private string     sCompanyName;
        public string     CompanyName
        {
            get { return sCompanyName; }
            set
            {
                sCompanyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
        private string     sCompanyTag;
        public string     CompanyTag
        {
            get { return sCompanyTag; }
            set
            {
                sCompanyTag = value;
                OnPropertyChanged("CompanyTag");
            }
        }
        private string     sAdd1;
        public string     Add1
        {
            get { return sAdd1; }
            set
            {
                sAdd1 = value;
                OnPropertyChanged("Add1");
            }
        }
        private string     sAdd2;
        public string     Add2
        {
            get { return sAdd2; }
            set
            {
                sAdd2 = value;
                OnPropertyChanged("Add2");
            }
        }
        private string     sAdd3;
        public string     Add3
        {
            get { return sAdd3; }
            set
            {
                sAdd3 = value;
                OnPropertyChanged("Add3");
            }
        }
        private string     sCutExp;
        public string     CutExp
        {
            get { return sCutExp; }
            set
            {
                sCutExp = value;
                OnPropertyChanged("CutExp");
            }
        }
        private long     nCUser;
        public long     CUser
        {
            get { return nCUser; }
            set
            {
                nCUser = value;
                OnPropertyChanged("CUser");
            }
        }
        private DateTime     dtCDateTime;
        public DateTime     CDateTime
        {
            get { return dtCDateTime; }
            set
            {
                dtCDateTime = value;
                OnPropertyChanged("CDateTime");
            }
        }
        private long     nEUser;
        public long     EUser
        {
            get { return nEUser; }
            set
            {
                nEUser = value;
                OnPropertyChanged("EUser");
            }
        }
        private DateTime     dtEDateTime;
        public DateTime     EDateTime
        {
            get { return dtEDateTime; }
            set
            {
                dtEDateTime = value;
                OnPropertyChanged("EDateTime");
            }
        }
        private long     nLCode;
        public long     LCode
        {
            get { return nLCode; }
            set
            {
                nLCode = value;
                OnPropertyChanged("LCode");
            }
        }
        private string     sDLock;
        public string     DLock
        {
            get { return sDLock; }
            set
            {
                sDLock = value;
                OnPropertyChanged("DLock");
            }
        }
        private string     sCreatedBy;
        public string     CreatedBy
        {
            get { return sCreatedBy; }
            set
            {
                sCreatedBy = value;
                OnPropertyChanged("CreatedBy");
            }
        }
        private DateTime     dtCreatedDate;
        public DateTime     CreatedDate
        {
            get { return dtCreatedDate; }
            set
            {
                dtCreatedDate = value;
                OnPropertyChanged("CreatedDate");
            }
        }
        private string     sUpdateddBy;
        public string     UpdateddBy
        {
            get { return sUpdateddBy; }
            set
            {
                sUpdateddBy = value;
                OnPropertyChanged("UpdateddBy");
            }
        }
        private DateTime     dtUpdatedDate;
        public DateTime     UpdatedDate
        {
            get { return dtUpdatedDate; }
            set
            {
                dtUpdatedDate = value;
                OnPropertyChanged("UpdatedDate");
            }
        }
        private int     nUpdatedCount;
        public int     UpdatedCount
        {
            get { return nUpdatedCount; }
            set
            {
                nUpdatedCount = value;
                OnPropertyChanged("UpdatedCount");
            }
        }
        private DateTime     dtLUT;
        public DateTime     LUT
        {
            get { return dtLUT; }
            set
            {
                dtLUT = value;
                OnPropertyChanged("LUT");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyCode"))){
                    this.CompanyCode = DBReader.GetInt64(DBReader.GetOrdinal("CompanyCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ICode"))){
                    this.ICode = DBReader.GetString(DBReader.GetOrdinal("ICode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyName"))){
                    this.CompanyName = DBReader.GetString(DBReader.GetOrdinal("CompanyName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyTag"))){
                    this.CompanyTag = DBReader.GetString(DBReader.GetOrdinal("CompanyTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add1"))){
                    this.Add1 = DBReader.GetString(DBReader.GetOrdinal("Add1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add2"))){
                    this.Add2 = DBReader.GetString(DBReader.GetOrdinal("Add2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add3"))){
                    this.Add3 = DBReader.GetString(DBReader.GetOrdinal("Add3"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CutExp"))){
                    this.CutExp = DBReader.GetString(DBReader.GetOrdinal("CutExp"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CUser"))){
                    this.CUser = DBReader.GetInt64(DBReader.GetOrdinal("CUser"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CDateTime"))){
                    this.CDateTime = DBReader.GetDateTime(DBReader.GetOrdinal("CDateTime"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EUser"))){
                    this.EUser = DBReader.GetInt64(DBReader.GetOrdinal("EUser"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EDateTime"))){
                    this.EDateTime = DBReader.GetDateTime(DBReader.GetOrdinal("EDateTime"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LCode"))){
                    this.LCode = DBReader.GetInt64(DBReader.GetOrdinal("LCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DLock"))){
                    this.DLock = DBReader.GetString(DBReader.GetOrdinal("DLock"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreatedBy"))){
                    this.CreatedBy = DBReader.GetString(DBReader.GetOrdinal("CreatedBy"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreatedDate"))){
                    this.CreatedDate = DBReader.GetDateTime(DBReader.GetOrdinal("CreatedDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("UpdateddBy"))){
                    this.UpdateddBy = DBReader.GetString(DBReader.GetOrdinal("UpdateddBy"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("UpdatedDate"))){
                    this.UpdatedDate = DBReader.GetDateTime(DBReader.GetOrdinal("UpdatedDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("UpdatedCount"))){
                    this.UpdatedCount = DBReader.GetInt32(DBReader.GetOrdinal("UpdatedCount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT"))){
                    this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
                }
            }
        #endregion
  
        public string GetXmlString()
        {  
            StringBuilder sXml = new StringBuilder();  
            sXml.Append("<data>");
            sXml.Append("<CompanyCode>" + this.CompanyCode + "</CompanyCode>");
            sXml.Append("<ICode>" + this.ICode + "</ICode>");
            sXml.Append("<CompanyName>" + this.CompanyName + "</CompanyName>");
            sXml.Append("<CompanyTag>" + this.CompanyTag + "</CompanyTag>");
            sXml.Append("<Add1>" + this.Add1 + "</Add1>");
            sXml.Append("<Add2>" + this.Add2 + "</Add2>");
            sXml.Append("<Add3>" + this.Add3 + "</Add3>");
            sXml.Append("<CutExp>" + this.CutExp + "</CutExp>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
            sXml.Append("<LCode>" + this.LCode + "</LCode>");
            sXml.Append("<DLock>" + this.DLock + "</DLock>");
            sXml.Append("<CreatedBy>" + this.CreatedBy + "</CreatedBy>");
            sXml.Append("<CreatedDate>" + this.CreatedDate + "</CreatedDate>");
            sXml.Append("<UpdateddBy>" + this.UpdateddBy + "</UpdateddBy>");
            sXml.Append("<UpdatedDate>" + this.UpdatedDate + "</UpdatedDate>");
            sXml.Append("<UpdatedCount>" + this.UpdatedCount + "</UpdatedCount>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            CompanyMaster objdata = obj as CompanyMaster;
            this.CompanyCode = objdata.CompanyCode;
            this.ICode = objdata.ICode;
            this.CompanyName = objdata.CompanyName;
            this.CompanyTag = objdata.CompanyTag;
            this.Add1 = objdata.Add1;
            this.Add2 = objdata.Add2;
            this.Add3 = objdata.Add3;
            this.CutExp = objdata.CutExp;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
            this.LCode = objdata.LCode;
            this.DLock = objdata.DLock;
            this.CreatedBy = objdata.CreatedBy;
            this.CreatedDate = objdata.CreatedDate;
            this.UpdateddBy = objdata.UpdateddBy;
            this.UpdatedDate = objdata.UpdatedDate;
            this.UpdatedCount = objdata.UpdatedCount;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            CompanyMaster objdata = obj as CompanyMaster;
            objdata.CompanyCode = this.CompanyCode;
            objdata.ICode = this.ICode;
            objdata.CompanyName = this.CompanyName;
            objdata.CompanyTag = this.CompanyTag;
            objdata.Add1 = this.Add1;
            objdata.Add2 = this.Add2;
            objdata.Add3 = this.Add3;
            objdata.CutExp = this.CutExp;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
            objdata.LCode = this.LCode;
            objdata.DLock = this.DLock;
            objdata.CreatedBy = this.CreatedBy;
            objdata.CreatedDate = this.CreatedDate;
            objdata.UpdateddBy = this.UpdateddBy;
            objdata.UpdatedDate = this.UpdatedDate;
            objdata.UpdatedCount = this.UpdatedCount;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.CompanyCode = 0;
            this.ICode = string.Empty;;
            this.CompanyName = string.Empty;;
            this.CompanyTag = string.Empty;;
            this.Add1 = string.Empty;;
            this.Add2 = string.Empty;;
            this.Add3 = string.Empty;;
            this.CutExp = string.Empty;;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.LCode = 0;
            this.DLock = string.Empty;;
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
