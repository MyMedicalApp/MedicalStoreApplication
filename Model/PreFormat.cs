 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class PreFormat : IModel,INotifyPropertyChanged
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
        private long     nBillNo;
        public long     BillNo
        {
            get { return nBillNo; }
            set
            {
                nBillNo = value;
                OnPropertyChanged("BillNo");
            }
        }
        private DateTime     dtBillDate;
        public DateTime     BillDate
        {
            get { return dtBillDate; }
            set
            {
                dtBillDate = value;
                OnPropertyChanged("BillDate");
            }
        }
        private long     nCustomerCode;
        public long     CustomerCode
        {
            get { return nCustomerCode; }
            set
            {
                nCustomerCode = value;
                OnPropertyChanged("CustomerCode");
            }
        }
        private long     nDoctorCode;
        public long     DoctorCode
        {
            get { return nDoctorCode; }
            set
            {
                nDoctorCode = value;
                OnPropertyChanged("DoctorCode");
            }
        }
        private long     nProductCode;
        public long     ProductCode
        {
            get { return nProductCode; }
            set
            {
                nProductCode = value;
                OnPropertyChanged("ProductCode");
            }
        }
        private decimal     nQty;
        public decimal     Qty
        {
            get { return nQty; }
            set
            {
                nQty = value;
                OnPropertyChanged("Qty");
            }
        }
        private string     sRemark;
        public string     Remark
        {
            get { return sRemark; }
            set
            {
                sRemark = value;
                OnPropertyChanged("Remark");
            }
        }
        private string     sReminderTag;
        public string     ReminderTag
        {
            get { return sReminderTag; }
            set
            {
                sReminderTag = value;
                OnPropertyChanged("ReminderTag");
            }
        }
        private decimal     nReminderOn;
        public decimal     ReminderOn
        {
            get { return nReminderOn; }
            set
            {
                nReminderOn = value;
                OnPropertyChanged("ReminderOn");
            }
        }
        private decimal     nReminderUpTo;
        public decimal     ReminderUpTo
        {
            get { return nReminderUpTo; }
            set
            {
                nReminderUpTo = value;
                OnPropertyChanged("ReminderUpTo");
            }
        }
        private decimal     nDisc;
        public decimal     Disc
        {
            get { return nDisc; }
            set
            {
                nDisc = value;
                OnPropertyChanged("Disc");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillNo"))){
                    this.BillNo = DBReader.GetInt64(DBReader.GetOrdinal("BillNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillDate"))){
                    this.BillDate = DBReader.GetDateTime(DBReader.GetOrdinal("BillDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CustomerCode"))){
                    this.CustomerCode = DBReader.GetInt64(DBReader.GetOrdinal("CustomerCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DoctorCode"))){
                    this.DoctorCode = DBReader.GetInt64(DBReader.GetOrdinal("DoctorCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductCode"))){
                    this.ProductCode = DBReader.GetInt64(DBReader.GetOrdinal("ProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Qty"))){
                    this.Qty = DBReader.GetDecimal(DBReader.GetOrdinal("Qty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Remark"))){
                    this.Remark = DBReader.GetString(DBReader.GetOrdinal("Remark"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReminderTag"))){
                    this.ReminderTag = DBReader.GetString(DBReader.GetOrdinal("ReminderTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReminderOn"))){
                    this.ReminderOn = DBReader.GetDecimal(DBReader.GetOrdinal("ReminderOn"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReminderUpTo"))){
                    this.ReminderUpTo = DBReader.GetDecimal(DBReader.GetOrdinal("ReminderUpTo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Disc"))){
                    this.Disc = DBReader.GetDecimal(DBReader.GetOrdinal("Disc"));
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
            sXml.Append("<BillNo>" + this.BillNo + "</BillNo>");
            sXml.Append("<BillDate>" + this.BillDate + "</BillDate>");
            sXml.Append("<CustomerCode>" + this.CustomerCode + "</CustomerCode>");
            sXml.Append("<DoctorCode>" + this.DoctorCode + "</DoctorCode>");
            sXml.Append("<ProductCode>" + this.ProductCode + "</ProductCode>");
            sXml.Append("<Qty>" + this.Qty + "</Qty>");
            sXml.Append("<Remark>" + this.Remark + "</Remark>");
            sXml.Append("<ReminderTag>" + this.ReminderTag + "</ReminderTag>");
            sXml.Append("<ReminderOn>" + this.ReminderOn + "</ReminderOn>");
            sXml.Append("<ReminderUpTo>" + this.ReminderUpTo + "</ReminderUpTo>");
            sXml.Append("<Disc>" + this.Disc + "</Disc>");
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
            PreFormat objdata = obj as PreFormat;
            this.RecNo = objdata.RecNo;
            this.BillNo = objdata.BillNo;
            this.BillDate = objdata.BillDate;
            this.CustomerCode = objdata.CustomerCode;
            this.DoctorCode = objdata.DoctorCode;
            this.ProductCode = objdata.ProductCode;
            this.Qty = objdata.Qty;
            this.Remark = objdata.Remark;
            this.ReminderTag = objdata.ReminderTag;
            this.ReminderOn = objdata.ReminderOn;
            this.ReminderUpTo = objdata.ReminderUpTo;
            this.Disc = objdata.Disc;
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
            PreFormat objdata = obj as PreFormat;
            objdata.RecNo = this.RecNo;
            objdata.BillNo = this.BillNo;
            objdata.BillDate = this.BillDate;
            objdata.CustomerCode = this.CustomerCode;
            objdata.DoctorCode = this.DoctorCode;
            objdata.ProductCode = this.ProductCode;
            objdata.Qty = this.Qty;
            objdata.Remark = this.Remark;
            objdata.ReminderTag = this.ReminderTag;
            objdata.ReminderOn = this.ReminderOn;
            objdata.ReminderUpTo = this.ReminderUpTo;
            objdata.Disc = this.Disc;
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
            this.BillNo = 0;
            this.BillDate = new DateTime();
            this.CustomerCode = 0;
            this.DoctorCode = 0;
            this.ProductCode = 0;
            this.Qty = 0;
            this.Remark = string.Empty;;
            this.ReminderTag = string.Empty;;
            this.ReminderOn = 0;
            this.ReminderUpTo = 0;
            this.Disc = 0;
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
