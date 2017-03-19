 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class OrderDetail : IModel,INotifyPropertyChanged
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
        private long     nAccountCode;
        public long     AccountCode
        {
            get { return nAccountCode; }
            set
            {
                nAccountCode = value;
                OnPropertyChanged("AccountCode");
            }
        }
        private long     nChallanNo;
        public long     ChallanNo
        {
            get { return nChallanNo; }
            set
            {
                nChallanNo = value;
                OnPropertyChanged("ChallanNo");
            }
        }
        private DateTime     dtChallanDate;
        public DateTime     ChallanDate
        {
            get { return dtChallanDate; }
            set
            {
                dtChallanDate = value;
                OnPropertyChanged("ChallanDate");
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
        private long     nBatchCode;
        public long     BatchCode
        {
            get { return nBatchCode; }
            set
            {
                nBatchCode = value;
                OnPropertyChanged("BatchCode");
            }
        }
        private decimal     nMRP;
        public decimal     MRP
        {
            get { return nMRP; }
            set
            {
                nMRP = value;
                OnPropertyChanged("MRP");
            }
        }
        private string     sBatchNo;
        public string     BatchNo
        {
            get { return sBatchNo; }
            set
            {
                sBatchNo = value;
                OnPropertyChanged("BatchNo");
            }
        }
        private DateTime     dtExpiry;
        public DateTime     Expiry
        {
            get { return dtExpiry; }
            set
            {
                dtExpiry = value;
                OnPropertyChanged("Expiry");
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
        private decimal     nFQty;
        public decimal     FQty
        {
            get { return nFQty; }
            set
            {
                nFQty = value;
                OnPropertyChanged("FQty");
            }
        }
        private decimal     nConversionUnit;
        public decimal     ConversionUnit
        {
            get { return nConversionUnit; }
            set
            {
                nConversionUnit = value;
                OnPropertyChanged("ConversionUnit");
            }
        }
        private decimal     nRate;
        public decimal     Rate
        {
            get { return nRate; }
            set
            {
                nRate = value;
                OnPropertyChanged("Rate");
            }
        }
        private string     sHalfScheme;
        public string     HalfScheme
        {
            get { return sHalfScheme; }
            set
            {
                sHalfScheme = value;
                OnPropertyChanged("HalfScheme");
            }
        }
        private decimal     nScheme;
        public decimal     Scheme
        {
            get { return nScheme; }
            set
            {
                nScheme = value;
                OnPropertyChanged("Scheme");
            }
        }
        private decimal     nSchemeRs;
        public decimal     SchemeRs
        {
            get { return nSchemeRs; }
            set
            {
                nSchemeRs = value;
                OnPropertyChanged("SchemeRs");
            }
        }
        private decimal     nSplDisc;
        public decimal     SplDisc
        {
            get { return nSplDisc; }
            set
            {
                nSplDisc = value;
                OnPropertyChanged("SplDisc");
            }
        }
        private decimal     nSplDiscRs;
        public decimal     SplDiscRs
        {
            get { return nSplDiscRs; }
            set
            {
                nSplDiscRs = value;
                OnPropertyChanged("SplDiscRs");
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
        private decimal     nDiscRs;
        public decimal     DiscRs
        {
            get { return nDiscRs; }
            set
            {
                nDiscRs = value;
                OnPropertyChanged("DiscRs");
            }
        }
        private string     sInclusive;
        public string     Inclusive
        {
            get { return sInclusive; }
            set
            {
                sInclusive = value;
                OnPropertyChanged("Inclusive");
            }
        }
        private string     sVatOn;
        public string     VatOn
        {
            get { return sVatOn; }
            set
            {
                sVatOn = value;
                OnPropertyChanged("VatOn");
            }
        }
        private decimal     nVat;
        public decimal     Vat
        {
            get { return nVat; }
            set
            {
                nVat = value;
                OnPropertyChanged("Vat");
            }
        }
        private decimal     nVatRs;
        public decimal     VatRs
        {
            get { return nVatRs; }
            set
            {
                nVatRs = value;
                OnPropertyChanged("VatRs");
            }
        }
        private decimal     nAdVat;
        public decimal     AdVat
        {
            get { return nAdVat; }
            set
            {
                nAdVat = value;
                OnPropertyChanged("AdVat");
            }
        }
        private decimal     nAdVatRs;
        public decimal     AdVatRs
        {
            get { return nAdVatRs; }
            set
            {
                nAdVatRs = value;
                OnPropertyChanged("AdVatRs");
            }
        }
        private decimal     nNetRate;
        public decimal     NetRate
        {
            get { return nNetRate; }
            set
            {
                nNetRate = value;
                OnPropertyChanged("NetRate");
            }
        }
        private string     sVatOnFree;
        public string     VatOnFree
        {
            get { return sVatOnFree; }
            set
            {
                sVatOnFree = value;
                OnPropertyChanged("VatOnFree");
            }
        }
        private decimal     nNetCostRate;
        public decimal     NetCostRate
        {
            get { return nNetCostRate; }
            set
            {
                nNetCostRate = value;
                OnPropertyChanged("NetCostRate");
            }
        }
        private decimal     nNetAmount;
        public decimal     NetAmount
        {
            get { return nNetAmount; }
            set
            {
                nNetAmount = value;
                OnPropertyChanged("NetAmount");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillDate"))){
                    this.BillDate = DBReader.GetDateTime(DBReader.GetOrdinal("BillDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode"))){
                    this.AccountCode = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ChallanNo"))){
                    this.ChallanNo = DBReader.GetInt64(DBReader.GetOrdinal("ChallanNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ChallanDate"))){
                    this.ChallanDate = DBReader.GetDateTime(DBReader.GetOrdinal("ChallanDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EntryTag"))){
                    this.EntryTag = DBReader.GetString(DBReader.GetOrdinal("EntryTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductCode"))){
                    this.ProductCode = DBReader.GetInt64(DBReader.GetOrdinal("ProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyCode"))){
                    this.CompanyCode = DBReader.GetInt64(DBReader.GetOrdinal("CompanyCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BatchCode"))){
                    this.BatchCode = DBReader.GetInt64(DBReader.GetOrdinal("BatchCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MRP"))){
                    this.MRP = DBReader.GetDecimal(DBReader.GetOrdinal("MRP"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BatchNo"))){
                    this.BatchNo = DBReader.GetString(DBReader.GetOrdinal("BatchNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Expiry"))){
                    this.Expiry = DBReader.GetDateTime(DBReader.GetOrdinal("Expiry"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Qty"))){
                    this.Qty = DBReader.GetDecimal(DBReader.GetOrdinal("Qty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FQty"))){
                    this.FQty = DBReader.GetDecimal(DBReader.GetOrdinal("FQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ConversionUnit"))){
                    this.ConversionUnit = DBReader.GetDecimal(DBReader.GetOrdinal("ConversionUnit"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Rate"))){
                    this.Rate = DBReader.GetDecimal(DBReader.GetOrdinal("Rate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("HalfScheme"))){
                    this.HalfScheme = DBReader.GetString(DBReader.GetOrdinal("HalfScheme"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Scheme"))){
                    this.Scheme = DBReader.GetDecimal(DBReader.GetOrdinal("Scheme"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SchemeRs"))){
                    this.SchemeRs = DBReader.GetDecimal(DBReader.GetOrdinal("SchemeRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SplDisc"))){
                    this.SplDisc = DBReader.GetDecimal(DBReader.GetOrdinal("SplDisc"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SplDiscRs"))){
                    this.SplDiscRs = DBReader.GetDecimal(DBReader.GetOrdinal("SplDiscRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Disc"))){
                    this.Disc = DBReader.GetDecimal(DBReader.GetOrdinal("Disc"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DiscRs"))){
                    this.DiscRs = DBReader.GetDecimal(DBReader.GetOrdinal("DiscRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Inclusive"))){
                    this.Inclusive = DBReader.GetString(DBReader.GetOrdinal("Inclusive"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatOn"))){
                    this.VatOn = DBReader.GetString(DBReader.GetOrdinal("VatOn"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Vat"))){
                    this.Vat = DBReader.GetDecimal(DBReader.GetOrdinal("Vat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatRs"))){
                    this.VatRs = DBReader.GetDecimal(DBReader.GetOrdinal("VatRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AdVat"))){
                    this.AdVat = DBReader.GetDecimal(DBReader.GetOrdinal("AdVat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AdVatRs"))){
                    this.AdVatRs = DBReader.GetDecimal(DBReader.GetOrdinal("AdVatRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NetRate"))){
                    this.NetRate = DBReader.GetDecimal(DBReader.GetOrdinal("NetRate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatOnFree"))){
                    this.VatOnFree = DBReader.GetString(DBReader.GetOrdinal("VatOnFree"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NetCostRate"))){
                    this.NetCostRate = DBReader.GetDecimal(DBReader.GetOrdinal("NetCostRate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NetAmount"))){
                    this.NetAmount = DBReader.GetDecimal(DBReader.GetOrdinal("NetAmount"));
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
            sXml.Append("<BillDate>" + this.BillDate + "</BillDate>");
            sXml.Append("<AccountCode>" + this.AccountCode + "</AccountCode>");
            sXml.Append("<ChallanNo>" + this.ChallanNo + "</ChallanNo>");
            sXml.Append("<ChallanDate>" + this.ChallanDate + "</ChallanDate>");
            sXml.Append("<EntryTag>" + this.EntryTag + "</EntryTag>");
            sXml.Append("<ProductCode>" + this.ProductCode + "</ProductCode>");
            sXml.Append("<CompanyCode>" + this.CompanyCode + "</CompanyCode>");
            sXml.Append("<BatchCode>" + this.BatchCode + "</BatchCode>");
            sXml.Append("<MRP>" + this.MRP + "</MRP>");
            sXml.Append("<BatchNo>" + this.BatchNo + "</BatchNo>");
            sXml.Append("<Expiry>" + this.Expiry + "</Expiry>");
            sXml.Append("<Qty>" + this.Qty + "</Qty>");
            sXml.Append("<FQty>" + this.FQty + "</FQty>");
            sXml.Append("<ConversionUnit>" + this.ConversionUnit + "</ConversionUnit>");
            sXml.Append("<Rate>" + this.Rate + "</Rate>");
            sXml.Append("<HalfScheme>" + this.HalfScheme + "</HalfScheme>");
            sXml.Append("<Scheme>" + this.Scheme + "</Scheme>");
            sXml.Append("<SchemeRs>" + this.SchemeRs + "</SchemeRs>");
            sXml.Append("<SplDisc>" + this.SplDisc + "</SplDisc>");
            sXml.Append("<SplDiscRs>" + this.SplDiscRs + "</SplDiscRs>");
            sXml.Append("<Disc>" + this.Disc + "</Disc>");
            sXml.Append("<DiscRs>" + this.DiscRs + "</DiscRs>");
            sXml.Append("<Inclusive>" + this.Inclusive + "</Inclusive>");
            sXml.Append("<VatOn>" + this.VatOn + "</VatOn>");
            sXml.Append("<Vat>" + this.Vat + "</Vat>");
            sXml.Append("<VatRs>" + this.VatRs + "</VatRs>");
            sXml.Append("<AdVat>" + this.AdVat + "</AdVat>");
            sXml.Append("<AdVatRs>" + this.AdVatRs + "</AdVatRs>");
            sXml.Append("<NetRate>" + this.NetRate + "</NetRate>");
            sXml.Append("<VatOnFree>" + this.VatOnFree + "</VatOnFree>");
            sXml.Append("<NetCostRate>" + this.NetCostRate + "</NetCostRate>");
            sXml.Append("<NetAmount>" + this.NetAmount + "</NetAmount>");
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
            OrderDetail objdata = obj as OrderDetail;
            this.RecNo = objdata.RecNo;
            this.BillTag = objdata.BillTag;
            this.BillType = objdata.BillType;
            this.BillCredit = objdata.BillCredit;
            this.BillSeries = objdata.BillSeries;
            this.BillNo = objdata.BillNo;
            this.BillDate = objdata.BillDate;
            this.AccountCode = objdata.AccountCode;
            this.ChallanNo = objdata.ChallanNo;
            this.ChallanDate = objdata.ChallanDate;
            this.EntryTag = objdata.EntryTag;
            this.ProductCode = objdata.ProductCode;
            this.CompanyCode = objdata.CompanyCode;
            this.BatchCode = objdata.BatchCode;
            this.MRP = objdata.MRP;
            this.BatchNo = objdata.BatchNo;
            this.Expiry = objdata.Expiry;
            this.Qty = objdata.Qty;
            this.FQty = objdata.FQty;
            this.ConversionUnit = objdata.ConversionUnit;
            this.Rate = objdata.Rate;
            this.HalfScheme = objdata.HalfScheme;
            this.Scheme = objdata.Scheme;
            this.SchemeRs = objdata.SchemeRs;
            this.SplDisc = objdata.SplDisc;
            this.SplDiscRs = objdata.SplDiscRs;
            this.Disc = objdata.Disc;
            this.DiscRs = objdata.DiscRs;
            this.Inclusive = objdata.Inclusive;
            this.VatOn = objdata.VatOn;
            this.Vat = objdata.Vat;
            this.VatRs = objdata.VatRs;
            this.AdVat = objdata.AdVat;
            this.AdVatRs = objdata.AdVatRs;
            this.NetRate = objdata.NetRate;
            this.VatOnFree = objdata.VatOnFree;
            this.NetCostRate = objdata.NetCostRate;
            this.NetAmount = objdata.NetAmount;
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
            OrderDetail objdata = obj as OrderDetail;
            objdata.RecNo = this.RecNo;
            objdata.BillTag = this.BillTag;
            objdata.BillType = this.BillType;
            objdata.BillCredit = this.BillCredit;
            objdata.BillSeries = this.BillSeries;
            objdata.BillNo = this.BillNo;
            objdata.BillDate = this.BillDate;
            objdata.AccountCode = this.AccountCode;
            objdata.ChallanNo = this.ChallanNo;
            objdata.ChallanDate = this.ChallanDate;
            objdata.EntryTag = this.EntryTag;
            objdata.ProductCode = this.ProductCode;
            objdata.CompanyCode = this.CompanyCode;
            objdata.BatchCode = this.BatchCode;
            objdata.MRP = this.MRP;
            objdata.BatchNo = this.BatchNo;
            objdata.Expiry = this.Expiry;
            objdata.Qty = this.Qty;
            objdata.FQty = this.FQty;
            objdata.ConversionUnit = this.ConversionUnit;
            objdata.Rate = this.Rate;
            objdata.HalfScheme = this.HalfScheme;
            objdata.Scheme = this.Scheme;
            objdata.SchemeRs = this.SchemeRs;
            objdata.SplDisc = this.SplDisc;
            objdata.SplDiscRs = this.SplDiscRs;
            objdata.Disc = this.Disc;
            objdata.DiscRs = this.DiscRs;
            objdata.Inclusive = this.Inclusive;
            objdata.VatOn = this.VatOn;
            objdata.Vat = this.Vat;
            objdata.VatRs = this.VatRs;
            objdata.AdVat = this.AdVat;
            objdata.AdVatRs = this.AdVatRs;
            objdata.NetRate = this.NetRate;
            objdata.VatOnFree = this.VatOnFree;
            objdata.NetCostRate = this.NetCostRate;
            objdata.NetAmount = this.NetAmount;
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
            this.BillDate = new DateTime();
            this.AccountCode = 0;
            this.ChallanNo = 0;
            this.ChallanDate = new DateTime();
            this.EntryTag = string.Empty;;
            this.ProductCode = 0;
            this.CompanyCode = 0;
            this.BatchCode = 0;
            this.MRP = 0;
            this.BatchNo = string.Empty;;
            this.Expiry = new DateTime();
            this.Qty = 0;
            this.FQty = 0;
            this.ConversionUnit = 0;
            this.Rate = 0;
            this.HalfScheme = string.Empty;;
            this.Scheme = 0;
            this.SchemeRs = 0;
            this.SplDisc = 0;
            this.SplDiscRs = 0;
            this.Disc = 0;
            this.DiscRs = 0;
            this.Inclusive = string.Empty;;
            this.VatOn = string.Empty;;
            this.Vat = 0;
            this.VatRs = 0;
            this.AdVat = 0;
            this.AdVatRs = 0;
            this.NetRate = 0;
            this.VatOnFree = string.Empty;;
            this.NetCostRate = 0;
            this.NetAmount = 0;
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
