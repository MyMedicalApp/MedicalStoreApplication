 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class AutoSetup : IModel,INotifyPropertyChanged
    {
        private long     nRecNo;
        public long     RecNo
        {
            get { return nRecNo; }
            set
            {
                nRecNo = value;
                OnPropertyChanged("RecNo");
            }
        }
        private string     sEntryTag;
        public string     EntryTag
        {
            get { return sEntryTag; }
            set
            {
                sEntryTag = value;
                OnPropertyChanged("EntryTag");
            }
        }
        private string     sReportName;
        public string     ReportName
        {
            get { return sReportName; }
            set
            {
                sReportName = value;
                OnPropertyChanged("ReportName");
            }
        }
        private decimal     nMailTime;
        public decimal     MailTime
        {
            get { return nMailTime; }
            set
            {
                nMailTime = value;
                OnPropertyChanged("MailTime");
            }
        }
        private string     sMailToID;
        public string     MailToID
        {
            get { return sMailToID; }
            set
            {
                sMailToID = value;
                OnPropertyChanged("MailToID");
            }
        }
        private string     sMailCCID;
        public string     MailCCID
        {
            get { return sMailCCID; }
            set
            {
                sMailCCID = value;
                OnPropertyChanged("MailCCID");
            }
        }
        private string     sMailBCCID;
        public string     MailBCCID
        {
            get { return sMailBCCID; }
            set
            {
                sMailBCCID = value;
                OnPropertyChanged("MailBCCID");
            }
        }
        private string     sSName;
        public string     SName
        {
            get { return sSName; }
            set
            {
                sSName = value;
                OnPropertyChanged("SName");
            }
        }
        private string     sPhone1;
        public string     Phone1
        {
            get { return sPhone1; }
            set
            {
                sPhone1 = value;
                OnPropertyChanged("Phone1");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RecNo"))){
                    this.RecNo = DBReader.GetInt64(DBReader.GetOrdinal("RecNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EntryTag"))){
                    this.EntryTag = DBReader.GetString(DBReader.GetOrdinal("EntryTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReportName"))){
                    this.ReportName = DBReader.GetString(DBReader.GetOrdinal("ReportName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MailTime"))){
                    this.MailTime = DBReader.GetDecimal(DBReader.GetOrdinal("MailTime"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MailToID"))){
                    this.MailToID = DBReader.GetString(DBReader.GetOrdinal("MailToID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MailCCID"))){
                    this.MailCCID = DBReader.GetString(DBReader.GetOrdinal("MailCCID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MailBCCID"))){
                    this.MailBCCID = DBReader.GetString(DBReader.GetOrdinal("MailBCCID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SName"))){
                    this.SName = DBReader.GetString(DBReader.GetOrdinal("SName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone1"))){
                    this.Phone1 = DBReader.GetString(DBReader.GetOrdinal("Phone1"));
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
            sXml.Append("<RecNo>" + this.RecNo + "</RecNo>");
            sXml.Append("<EntryTag>" + this.EntryTag + "</EntryTag>");
            sXml.Append("<ReportName>" + this.ReportName + "</ReportName>");
            sXml.Append("<MailTime>" + this.MailTime + "</MailTime>");
            sXml.Append("<MailToID>" + this.MailToID + "</MailToID>");
            sXml.Append("<MailCCID>" + this.MailCCID + "</MailCCID>");
            sXml.Append("<MailBCCID>" + this.MailBCCID + "</MailBCCID>");
            sXml.Append("<SName>" + this.SName + "</SName>");
            sXml.Append("<Phone1>" + this.Phone1 + "</Phone1>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
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
            AutoSetup objdata = obj as AutoSetup;
            this.RecNo = objdata.RecNo;
            this.EntryTag = objdata.EntryTag;
            this.ReportName = objdata.ReportName;
            this.MailTime = objdata.MailTime;
            this.MailToID = objdata.MailToID;
            this.MailCCID = objdata.MailCCID;
            this.MailBCCID = objdata.MailBCCID;
            this.SName = objdata.SName;
            this.Phone1 = objdata.Phone1;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
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
            AutoSetup objdata = obj as AutoSetup;
            objdata.RecNo = this.RecNo;
            objdata.EntryTag = this.EntryTag;
            objdata.ReportName = this.ReportName;
            objdata.MailTime = this.MailTime;
            objdata.MailToID = this.MailToID;
            objdata.MailCCID = this.MailCCID;
            objdata.MailBCCID = this.MailBCCID;
            objdata.SName = this.SName;
            objdata.Phone1 = this.Phone1;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
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
            this.RecNo = 0;
            this.EntryTag = string.Empty;;
            this.ReportName = string.Empty;;
            this.MailTime = 0;
            this.MailToID = string.Empty;;
            this.MailCCID = string.Empty;;
            this.MailBCCID = string.Empty;;
            this.SName = string.Empty;;
            this.Phone1 = string.Empty;;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
