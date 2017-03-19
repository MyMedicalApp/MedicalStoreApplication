 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class ReceivePayment : IModel,INotifyPropertyChanged
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
        private long     nRefNo;
        public long     RefNo
        {
            get { return nRefNo; }
            set
            {
                nRefNo = value;
                OnPropertyChanged("RefNo");
            }
        }
        private DateTime     dtEntryDate;
        public DateTime     EntryDate
        {
            get { return dtEntryDate; }
            set
            {
                dtEntryDate = value;
                OnPropertyChanged("EntryDate");
            }
        }
        private string     sChequeNo;
        public string     ChequeNo
        {
            get { return sChequeNo; }
            set
            {
                sChequeNo = value;
                OnPropertyChanged("ChequeNo");
            }
        }
        private DateTime     dtChequeDate;
        public DateTime     ChequeDate
        {
            get { return dtChequeDate; }
            set
            {
                dtChequeDate = value;
                OnPropertyChanged("ChequeDate");
            }
        }
        private long     nAccountCode1;
        public long     AccountCode1
        {
            get { return nAccountCode1; }
            set
            {
                nAccountCode1 = value;
                OnPropertyChanged("AccountCode1");
            }
        }
        private long     nAccountCode2;
        public long     AccountCode2
        {
            get { return nAccountCode2; }
            set
            {
                nAccountCode2 = value;
                OnPropertyChanged("AccountCode2");
            }
        }
        private decimal     nAmount;
        public decimal     Amount
        {
            get { return nAmount; }
            set
            {
                nAmount = value;
                OnPropertyChanged("Amount");
            }
        }
        private string     sRcptMess;
        public string     RcptMess
        {
            get { return sRcptMess; }
            set
            {
                sRcptMess = value;
                OnPropertyChanged("RcptMess");
            }
        }
        private DateTime     dtReconDate;
        public DateTime     ReconDate
        {
            get { return dtReconDate; }
            set
            {
                dtReconDate = value;
                OnPropertyChanged("ReconDate");
            }
        }
        private long     nShiftNo;
        public long     ShiftNo
        {
            get { return nShiftNo; }
            set
            {
                nShiftNo = value;
                OnPropertyChanged("ShiftNo");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RefNo"))){
                    this.RefNo = DBReader.GetInt64(DBReader.GetOrdinal("RefNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EntryDate"))){
                    this.EntryDate = DBReader.GetDateTime(DBReader.GetOrdinal("EntryDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ChequeNo"))){
                    this.ChequeNo = DBReader.GetString(DBReader.GetOrdinal("ChequeNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ChequeDate"))){
                    this.ChequeDate = DBReader.GetDateTime(DBReader.GetOrdinal("ChequeDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode1"))){
                    this.AccountCode1 = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode2"))){
                    this.AccountCode2 = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Amount"))){
                    this.Amount = DBReader.GetDecimal(DBReader.GetOrdinal("Amount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RcptMess"))){
                    this.RcptMess = DBReader.GetString(DBReader.GetOrdinal("RcptMess"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReconDate"))){
                    this.ReconDate = DBReader.GetDateTime(DBReader.GetOrdinal("ReconDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ShiftNo"))){
                    this.ShiftNo = DBReader.GetInt64(DBReader.GetOrdinal("ShiftNo"));
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
            sXml.Append("<RefNo>" + this.RefNo + "</RefNo>");
            sXml.Append("<EntryDate>" + this.EntryDate + "</EntryDate>");
            sXml.Append("<ChequeNo>" + this.ChequeNo + "</ChequeNo>");
            sXml.Append("<ChequeDate>" + this.ChequeDate + "</ChequeDate>");
            sXml.Append("<AccountCode1>" + this.AccountCode1 + "</AccountCode1>");
            sXml.Append("<AccountCode2>" + this.AccountCode2 + "</AccountCode2>");
            sXml.Append("<Amount>" + this.Amount + "</Amount>");
            sXml.Append("<RcptMess>" + this.RcptMess + "</RcptMess>");
            sXml.Append("<ReconDate>" + this.ReconDate + "</ReconDate>");
            sXml.Append("<ShiftNo>" + this.ShiftNo + "</ShiftNo>");
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
            ReceivePayment objdata = obj as ReceivePayment;
            this.RecNo = objdata.RecNo;
            this.EntryTag = objdata.EntryTag;
            this.RefNo = objdata.RefNo;
            this.EntryDate = objdata.EntryDate;
            this.ChequeNo = objdata.ChequeNo;
            this.ChequeDate = objdata.ChequeDate;
            this.AccountCode1 = objdata.AccountCode1;
            this.AccountCode2 = objdata.AccountCode2;
            this.Amount = objdata.Amount;
            this.RcptMess = objdata.RcptMess;
            this.ReconDate = objdata.ReconDate;
            this.ShiftNo = objdata.ShiftNo;
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
            ReceivePayment objdata = obj as ReceivePayment;
            objdata.RecNo = this.RecNo;
            objdata.EntryTag = this.EntryTag;
            objdata.RefNo = this.RefNo;
            objdata.EntryDate = this.EntryDate;
            objdata.ChequeNo = this.ChequeNo;
            objdata.ChequeDate = this.ChequeDate;
            objdata.AccountCode1 = this.AccountCode1;
            objdata.AccountCode2 = this.AccountCode2;
            objdata.Amount = this.Amount;
            objdata.RcptMess = this.RcptMess;
            objdata.ReconDate = this.ReconDate;
            objdata.ShiftNo = this.ShiftNo;
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
            this.RefNo = 0;
            this.EntryDate = new DateTime();
            this.ChequeNo = string.Empty;;
            this.ChequeDate = new DateTime();
            this.AccountCode1 = 0;
            this.AccountCode2 = 0;
            this.Amount = 0;
            this.RcptMess = string.Empty;;
            this.ReconDate = new DateTime();
            this.ShiftNo = 0;
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
