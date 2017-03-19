 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class VatDetail : IModel,INotifyPropertyChanged
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
        private string     sBillTag;
        public string     BillTag
        {
            get { return sBillTag; }
            set
            {
                sBillTag = value;
                OnPropertyChanged("BillTag");
            }
        }
        private string     sBillType;
        public string     BillType
        {
            get { return sBillType; }
            set
            {
                sBillType = value;
                OnPropertyChanged("BillType");
            }
        }
        private string     sBillCredit;
        public string     BillCredit
        {
            get { return sBillCredit; }
            set
            {
                sBillCredit = value;
                OnPropertyChanged("BillCredit");
            }
        }
        private string     sBillSeries;
        public string     BillSeries
        {
            get { return sBillSeries; }
            set
            {
                sBillSeries = value;
                OnPropertyChanged("BillSeries");
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
        private decimal     nTaxPer;
        public decimal     TaxPer
        {
            get { return nTaxPer; }
            set
            {
                nTaxPer = value;
                OnPropertyChanged("TaxPer");
            }
        }
        private decimal     nTaxAmt;
        public decimal     TaxAmt
        {
            get { return nTaxAmt; }
            set
            {
                nTaxAmt = value;
                OnPropertyChanged("TaxAmt");
            }
        }
        private decimal     nTaxRs;
        public decimal     TaxRs
        {
            get { return nTaxRs; }
            set
            {
                nTaxRs = value;
                OnPropertyChanged("TaxRs");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillTag"))){
                    this.BillTag = DBReader.GetString(DBReader.GetOrdinal("BillTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillType"))){
                    this.BillType = DBReader.GetString(DBReader.GetOrdinal("BillType"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillCredit"))){
                    this.BillCredit = DBReader.GetString(DBReader.GetOrdinal("BillCredit"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillSeries"))){
                    this.BillSeries = DBReader.GetString(DBReader.GetOrdinal("BillSeries"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillNo"))){
                    this.BillNo = DBReader.GetInt64(DBReader.GetOrdinal("BillNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TaxPer"))){
                    this.TaxPer = DBReader.GetDecimal(DBReader.GetOrdinal("TaxPer"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TaxAmt"))){
                    this.TaxAmt = DBReader.GetDecimal(DBReader.GetOrdinal("TaxAmt"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TaxRs"))){
                    this.TaxRs = DBReader.GetDecimal(DBReader.GetOrdinal("TaxRs"));
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
            sXml.Append("<BillTag>" + this.BillTag + "</BillTag>");
            sXml.Append("<BillType>" + this.BillType + "</BillType>");
            sXml.Append("<BillCredit>" + this.BillCredit + "</BillCredit>");
            sXml.Append("<BillSeries>" + this.BillSeries + "</BillSeries>");
            sXml.Append("<BillNo>" + this.BillNo + "</BillNo>");
            sXml.Append("<TaxPer>" + this.TaxPer + "</TaxPer>");
            sXml.Append("<TaxAmt>" + this.TaxAmt + "</TaxAmt>");
            sXml.Append("<TaxRs>" + this.TaxRs + "</TaxRs>");
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
            VatDetail objdata = obj as VatDetail;
            this.RecNo = objdata.RecNo;
            this.BillTag = objdata.BillTag;
            this.BillType = objdata.BillType;
            this.BillCredit = objdata.BillCredit;
            this.BillSeries = objdata.BillSeries;
            this.BillNo = objdata.BillNo;
            this.TaxPer = objdata.TaxPer;
            this.TaxAmt = objdata.TaxAmt;
            this.TaxRs = objdata.TaxRs;
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
            VatDetail objdata = obj as VatDetail;
            objdata.RecNo = this.RecNo;
            objdata.BillTag = this.BillTag;
            objdata.BillType = this.BillType;
            objdata.BillCredit = this.BillCredit;
            objdata.BillSeries = this.BillSeries;
            objdata.BillNo = this.BillNo;
            objdata.TaxPer = this.TaxPer;
            objdata.TaxAmt = this.TaxAmt;
            objdata.TaxRs = this.TaxRs;
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
            this.BillTag = string.Empty;;
            this.BillType = string.Empty;;
            this.BillCredit = string.Empty;;
            this.BillSeries = string.Empty;;
            this.BillNo = 0;
            this.TaxPer = 0;
            this.TaxAmt = 0;
            this.TaxRs = 0;
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
