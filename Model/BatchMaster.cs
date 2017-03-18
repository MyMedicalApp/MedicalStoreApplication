 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class BatchMaster : IModel,INotifyPropertyChanged
    {
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
        private decimal     nOctroi;
        public decimal     Octroi
        {
            get { return nOctroi; }
            set
            {
                nOctroi = value;
                OnPropertyChanged("Octroi");
            }
        }
        private decimal     nPurRs;
        public decimal     PurRs
        {
            get { return nPurRs; }
            set
            {
                nPurRs = value;
                OnPropertyChanged("PurRs");
            }
        }
        private decimal     nSaleRs;
        public decimal     SaleRs
        {
            get { return nSaleRs; }
            set
            {
                nSaleRs = value;
                OnPropertyChanged("SaleRs");
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
        private long     nStockPt;
        public long     StockPt
        {
            get { return nStockPt; }
            set
            {
                nStockPt = value;
                OnPropertyChanged("StockPt");
            }
        }
        private decimal     nOpQty;
        public decimal     OpQty
        {
            get { return nOpQty; }
            set
            {
                nOpQty = value;
                OnPropertyChanged("OpQty");
            }
        }
        private decimal     nOpQtyRs;
        public decimal     OpQtyRs
        {
            get { return nOpQtyRs; }
            set
            {
                nOpQtyRs = value;
                OnPropertyChanged("OpQtyRs");
            }
        }
        private decimal     nOpFQty;
        public decimal     OpFQty
        {
            get { return nOpFQty; }
            set
            {
                nOpFQty = value;
                OnPropertyChanged("OpFQty");
            }
        }
        private decimal     nOpFQtyRs;
        public decimal     OpFQtyRs
        {
            get { return nOpFQtyRs; }
            set
            {
                nOpFQtyRs = value;
                OnPropertyChanged("OpFQtyRs");
            }
        }
        private decimal     nPurQty;
        public decimal     PurQty
        {
            get { return nPurQty; }
            set
            {
                nPurQty = value;
                OnPropertyChanged("PurQty");
            }
        }
        private decimal     nPurQtyRs;
        public decimal     PurQtyRs
        {
            get { return nPurQtyRs; }
            set
            {
                nPurQtyRs = value;
                OnPropertyChanged("PurQtyRs");
            }
        }
        private decimal     nPurFQty;
        public decimal     PurFQty
        {
            get { return nPurFQty; }
            set
            {
                nPurFQty = value;
                OnPropertyChanged("PurFQty");
            }
        }
        private decimal     nPurFQtyRs;
        public decimal     PurFQtyRs
        {
            get { return nPurFQtyRs; }
            set
            {
                nPurFQtyRs = value;
                OnPropertyChanged("PurFQtyRs");
            }
        }
        private decimal     nCrQty;
        public decimal     CrQty
        {
            get { return nCrQty; }
            set
            {
                nCrQty = value;
                OnPropertyChanged("CrQty");
            }
        }
        private decimal     nCrQtyRs;
        public decimal     CrQtyRs
        {
            get { return nCrQtyRs; }
            set
            {
                nCrQtyRs = value;
                OnPropertyChanged("CrQtyRs");
            }
        }
        private decimal     nCrFQty;
        public decimal     CrFQty
        {
            get { return nCrFQty; }
            set
            {
                nCrFQty = value;
                OnPropertyChanged("CrFQty");
            }
        }
        private decimal     nCrFQtyRs;
        public decimal     CrFQtyRs
        {
            get { return nCrFQtyRs; }
            set
            {
                nCrFQtyRs = value;
                OnPropertyChanged("CrFQtyRs");
            }
        }
        private decimal     nRcptQty;
        public decimal     RcptQty
        {
            get { return nRcptQty; }
            set
            {
                nRcptQty = value;
                OnPropertyChanged("RcptQty");
            }
        }
        private decimal     nRcptQtyRs;
        public decimal     RcptQtyRs
        {
            get { return nRcptQtyRs; }
            set
            {
                nRcptQtyRs = value;
                OnPropertyChanged("RcptQtyRs");
            }
        }
        private decimal     nSaleQty;
        public decimal     SaleQty
        {
            get { return nSaleQty; }
            set
            {
                nSaleQty = value;
                OnPropertyChanged("SaleQty");
            }
        }
        private decimal     nSaleQtyRs;
        public decimal     SaleQtyRs
        {
            get { return nSaleQtyRs; }
            set
            {
                nSaleQtyRs = value;
                OnPropertyChanged("SaleQtyRs");
            }
        }
        private decimal     nSaleFQty;
        public decimal     SaleFQty
        {
            get { return nSaleFQty; }
            set
            {
                nSaleFQty = value;
                OnPropertyChanged("SaleFQty");
            }
        }
        private decimal     nSaleFQtyRs;
        public decimal     SaleFQtyRs
        {
            get { return nSaleFQtyRs; }
            set
            {
                nSaleFQtyRs = value;
                OnPropertyChanged("SaleFQtyRs");
            }
        }
        private decimal     nIssueQty;
        public decimal     IssueQty
        {
            get { return nIssueQty; }
            set
            {
                nIssueQty = value;
                OnPropertyChanged("IssueQty");
            }
        }
        private decimal     nIssueQtyRs;
        public decimal     IssueQtyRs
        {
            get { return nIssueQtyRs; }
            set
            {
                nIssueQtyRs = value;
                OnPropertyChanged("IssueQtyRs");
            }
        }
        private decimal     nClQty;
        public decimal     ClQty
        {
            get { return nClQty; }
            set
            {
                nClQty = value;
                OnPropertyChanged("ClQty");
            }
        }
        private decimal     nClQtyRs;
        public decimal     ClQtyRs
        {
            get { return nClQtyRs; }
            set
            {
                nClQtyRs = value;
                OnPropertyChanged("ClQtyRs");
            }
        }
        private decimal     nClFQty;
        public decimal     ClFQty
        {
            get { return nClFQty; }
            set
            {
                nClFQty = value;
                OnPropertyChanged("ClFQty");
            }
        }
        private decimal     nClFQtyRs;
        public decimal     ClFQtyRs
        {
            get { return nClFQtyRs; }
            set
            {
                nClFQtyRs = value;
                OnPropertyChanged("ClFQtyRs");
            }
        }
        private decimal     nTQty;
        public decimal     TQty
        {
            get { return nTQty; }
            set
            {
                nTQty = value;
                OnPropertyChanged("TQty");
            }
        }
        private decimal     nTQtyRs;
        public decimal     TQtyRs
        {
            get { return nTQtyRs; }
            set
            {
                nTQtyRs = value;
                OnPropertyChanged("TQtyRs");
            }
        }
        private string     sBarSeries;
        public string     BarSeries
        {
            get { return sBarSeries; }
            set
            {
                sBarSeries = value;
                OnPropertyChanged("BarSeries");
            }
        }
        private string     sBarCode;
        public string     BarCode
        {
            get { return sBarCode; }
            set
            {
                sBarCode = value;
                OnPropertyChanged("BarCode");
            }
        }
        private string     sBatchHead;
        public string     BatchHead
        {
            get { return sBatchHead; }
            set
            {
                sBatchHead = value;
                OnPropertyChanged("BatchHead");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BatchCode"))){
                    this.BatchCode = DBReader.GetInt64(DBReader.GetOrdinal("BatchCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ICode"))){
                    this.ICode = DBReader.GetString(DBReader.GetOrdinal("ICode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductCode"))){
                    this.ProductCode = DBReader.GetInt64(DBReader.GetOrdinal("ProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode"))){
                    this.AccountCode = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Inclusive"))){
                    this.Inclusive = DBReader.GetString(DBReader.GetOrdinal("Inclusive"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatOn"))){
                    this.VatOn = DBReader.GetString(DBReader.GetOrdinal("VatOn"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Vat"))){
                    this.Vat = DBReader.GetDecimal(DBReader.GetOrdinal("Vat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AdVat"))){
                    this.AdVat = DBReader.GetDecimal(DBReader.GetOrdinal("AdVat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Octroi"))){
                    this.Octroi = DBReader.GetDecimal(DBReader.GetOrdinal("Octroi"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurRs"))){
                    this.PurRs = DBReader.GetDecimal(DBReader.GetOrdinal("PurRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SaleRs"))){
                    this.SaleRs = DBReader.GetDecimal(DBReader.GetOrdinal("SaleRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NetRate"))){
                    this.NetRate = DBReader.GetDecimal(DBReader.GetOrdinal("NetRate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("StockPt"))){
                    this.StockPt = DBReader.GetInt64(DBReader.GetOrdinal("StockPt"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpQty"))){
                    this.OpQty = DBReader.GetDecimal(DBReader.GetOrdinal("OpQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpQtyRs"))){
                    this.OpQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("OpQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpFQty"))){
                    this.OpFQty = DBReader.GetDecimal(DBReader.GetOrdinal("OpFQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpFQtyRs"))){
                    this.OpFQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("OpFQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurQty"))){
                    this.PurQty = DBReader.GetDecimal(DBReader.GetOrdinal("PurQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurQtyRs"))){
                    this.PurQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("PurQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurFQty"))){
                    this.PurFQty = DBReader.GetDecimal(DBReader.GetOrdinal("PurFQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurFQtyRs"))){
                    this.PurFQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("PurFQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CrQty"))){
                    this.CrQty = DBReader.GetDecimal(DBReader.GetOrdinal("CrQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CrQtyRs"))){
                    this.CrQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("CrQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CrFQty"))){
                    this.CrFQty = DBReader.GetDecimal(DBReader.GetOrdinal("CrFQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CrFQtyRs"))){
                    this.CrFQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("CrFQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RcptQty"))){
                    this.RcptQty = DBReader.GetDecimal(DBReader.GetOrdinal("RcptQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RcptQtyRs"))){
                    this.RcptQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("RcptQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SaleQty"))){
                    this.SaleQty = DBReader.GetDecimal(DBReader.GetOrdinal("SaleQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SaleQtyRs"))){
                    this.SaleQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("SaleQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SaleFQty"))){
                    this.SaleFQty = DBReader.GetDecimal(DBReader.GetOrdinal("SaleFQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SaleFQtyRs"))){
                    this.SaleFQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("SaleFQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("IssueQty"))){
                    this.IssueQty = DBReader.GetDecimal(DBReader.GetOrdinal("IssueQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("IssueQtyRs"))){
                    this.IssueQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("IssueQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ClQty"))){
                    this.ClQty = DBReader.GetDecimal(DBReader.GetOrdinal("ClQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ClQtyRs"))){
                    this.ClQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("ClQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ClFQty"))){
                    this.ClFQty = DBReader.GetDecimal(DBReader.GetOrdinal("ClFQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ClFQtyRs"))){
                    this.ClFQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("ClFQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TQty"))){
                    this.TQty = DBReader.GetDecimal(DBReader.GetOrdinal("TQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TQtyRs"))){
                    this.TQtyRs = DBReader.GetDecimal(DBReader.GetOrdinal("TQtyRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BarSeries"))){
                    this.BarSeries = DBReader.GetString(DBReader.GetOrdinal("BarSeries"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BarCode"))){
                    this.BarCode = DBReader.GetString(DBReader.GetOrdinal("BarCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BatchHead"))){
                    this.BatchHead = DBReader.GetString(DBReader.GetOrdinal("BatchHead"));
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
            sXml.Append("<BatchCode>" + this.BatchCode + "</BatchCode>");
            sXml.Append("<ICode>" + this.ICode + "</ICode>");
            sXml.Append("<ProductCode>" + this.ProductCode + "</ProductCode>");
            sXml.Append("<AccountCode>" + this.AccountCode + "</AccountCode>");
            sXml.Append("<MRP>" + this.MRP + "</MRP>");
            sXml.Append("<BatchNo>" + this.BatchNo + "</BatchNo>");
            sXml.Append("<Expiry>" + this.Expiry + "</Expiry>");
            sXml.Append("<Inclusive>" + this.Inclusive + "</Inclusive>");
            sXml.Append("<VatOn>" + this.VatOn + "</VatOn>");
            sXml.Append("<Vat>" + this.Vat + "</Vat>");
            sXml.Append("<AdVat>" + this.AdVat + "</AdVat>");
            sXml.Append("<Octroi>" + this.Octroi + "</Octroi>");
            sXml.Append("<PurRs>" + this.PurRs + "</PurRs>");
            sXml.Append("<SaleRs>" + this.SaleRs + "</SaleRs>");
            sXml.Append("<NetRate>" + this.NetRate + "</NetRate>");
            sXml.Append("<StockPt>" + this.StockPt + "</StockPt>");
            sXml.Append("<OpQty>" + this.OpQty + "</OpQty>");
            sXml.Append("<OpQtyRs>" + this.OpQtyRs + "</OpQtyRs>");
            sXml.Append("<OpFQty>" + this.OpFQty + "</OpFQty>");
            sXml.Append("<OpFQtyRs>" + this.OpFQtyRs + "</OpFQtyRs>");
            sXml.Append("<PurQty>" + this.PurQty + "</PurQty>");
            sXml.Append("<PurQtyRs>" + this.PurQtyRs + "</PurQtyRs>");
            sXml.Append("<PurFQty>" + this.PurFQty + "</PurFQty>");
            sXml.Append("<PurFQtyRs>" + this.PurFQtyRs + "</PurFQtyRs>");
            sXml.Append("<CrQty>" + this.CrQty + "</CrQty>");
            sXml.Append("<CrQtyRs>" + this.CrQtyRs + "</CrQtyRs>");
            sXml.Append("<CrFQty>" + this.CrFQty + "</CrFQty>");
            sXml.Append("<CrFQtyRs>" + this.CrFQtyRs + "</CrFQtyRs>");
            sXml.Append("<RcptQty>" + this.RcptQty + "</RcptQty>");
            sXml.Append("<RcptQtyRs>" + this.RcptQtyRs + "</RcptQtyRs>");
            sXml.Append("<SaleQty>" + this.SaleQty + "</SaleQty>");
            sXml.Append("<SaleQtyRs>" + this.SaleQtyRs + "</SaleQtyRs>");
            sXml.Append("<SaleFQty>" + this.SaleFQty + "</SaleFQty>");
            sXml.Append("<SaleFQtyRs>" + this.SaleFQtyRs + "</SaleFQtyRs>");
            sXml.Append("<IssueQty>" + this.IssueQty + "</IssueQty>");
            sXml.Append("<IssueQtyRs>" + this.IssueQtyRs + "</IssueQtyRs>");
            sXml.Append("<ClQty>" + this.ClQty + "</ClQty>");
            sXml.Append("<ClQtyRs>" + this.ClQtyRs + "</ClQtyRs>");
            sXml.Append("<ClFQty>" + this.ClFQty + "</ClFQty>");
            sXml.Append("<ClFQtyRs>" + this.ClFQtyRs + "</ClFQtyRs>");
            sXml.Append("<TQty>" + this.TQty + "</TQty>");
            sXml.Append("<TQtyRs>" + this.TQtyRs + "</TQtyRs>");
            sXml.Append("<BarSeries>" + this.BarSeries + "</BarSeries>");
            sXml.Append("<BarCode>" + this.BarCode + "</BarCode>");
            sXml.Append("<BatchHead>" + this.BatchHead + "</BatchHead>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
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
            BatchMaster objdata = obj as BatchMaster;
            this.BatchCode = objdata.BatchCode;
            this.ICode = objdata.ICode;
            this.ProductCode = objdata.ProductCode;
            this.AccountCode = objdata.AccountCode;
            this.MRP = objdata.MRP;
            this.BatchNo = objdata.BatchNo;
            this.Expiry = objdata.Expiry;
            this.Inclusive = objdata.Inclusive;
            this.VatOn = objdata.VatOn;
            this.Vat = objdata.Vat;
            this.AdVat = objdata.AdVat;
            this.Octroi = objdata.Octroi;
            this.PurRs = objdata.PurRs;
            this.SaleRs = objdata.SaleRs;
            this.NetRate = objdata.NetRate;
            this.StockPt = objdata.StockPt;
            this.OpQty = objdata.OpQty;
            this.OpQtyRs = objdata.OpQtyRs;
            this.OpFQty = objdata.OpFQty;
            this.OpFQtyRs = objdata.OpFQtyRs;
            this.PurQty = objdata.PurQty;
            this.PurQtyRs = objdata.PurQtyRs;
            this.PurFQty = objdata.PurFQty;
            this.PurFQtyRs = objdata.PurFQtyRs;
            this.CrQty = objdata.CrQty;
            this.CrQtyRs = objdata.CrQtyRs;
            this.CrFQty = objdata.CrFQty;
            this.CrFQtyRs = objdata.CrFQtyRs;
            this.RcptQty = objdata.RcptQty;
            this.RcptQtyRs = objdata.RcptQtyRs;
            this.SaleQty = objdata.SaleQty;
            this.SaleQtyRs = objdata.SaleQtyRs;
            this.SaleFQty = objdata.SaleFQty;
            this.SaleFQtyRs = objdata.SaleFQtyRs;
            this.IssueQty = objdata.IssueQty;
            this.IssueQtyRs = objdata.IssueQtyRs;
            this.ClQty = objdata.ClQty;
            this.ClQtyRs = objdata.ClQtyRs;
            this.ClFQty = objdata.ClFQty;
            this.ClFQtyRs = objdata.ClFQtyRs;
            this.TQty = objdata.TQty;
            this.TQtyRs = objdata.TQtyRs;
            this.BarSeries = objdata.BarSeries;
            this.BarCode = objdata.BarCode;
            this.BatchHead = objdata.BatchHead;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
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
            BatchMaster objdata = obj as BatchMaster;
            objdata.BatchCode = this.BatchCode;
            objdata.ICode = this.ICode;
            objdata.ProductCode = this.ProductCode;
            objdata.AccountCode = this.AccountCode;
            objdata.MRP = this.MRP;
            objdata.BatchNo = this.BatchNo;
            objdata.Expiry = this.Expiry;
            objdata.Inclusive = this.Inclusive;
            objdata.VatOn = this.VatOn;
            objdata.Vat = this.Vat;
            objdata.AdVat = this.AdVat;
            objdata.Octroi = this.Octroi;
            objdata.PurRs = this.PurRs;
            objdata.SaleRs = this.SaleRs;
            objdata.NetRate = this.NetRate;
            objdata.StockPt = this.StockPt;
            objdata.OpQty = this.OpQty;
            objdata.OpQtyRs = this.OpQtyRs;
            objdata.OpFQty = this.OpFQty;
            objdata.OpFQtyRs = this.OpFQtyRs;
            objdata.PurQty = this.PurQty;
            objdata.PurQtyRs = this.PurQtyRs;
            objdata.PurFQty = this.PurFQty;
            objdata.PurFQtyRs = this.PurFQtyRs;
            objdata.CrQty = this.CrQty;
            objdata.CrQtyRs = this.CrQtyRs;
            objdata.CrFQty = this.CrFQty;
            objdata.CrFQtyRs = this.CrFQtyRs;
            objdata.RcptQty = this.RcptQty;
            objdata.RcptQtyRs = this.RcptQtyRs;
            objdata.SaleQty = this.SaleQty;
            objdata.SaleQtyRs = this.SaleQtyRs;
            objdata.SaleFQty = this.SaleFQty;
            objdata.SaleFQtyRs = this.SaleFQtyRs;
            objdata.IssueQty = this.IssueQty;
            objdata.IssueQtyRs = this.IssueQtyRs;
            objdata.ClQty = this.ClQty;
            objdata.ClQtyRs = this.ClQtyRs;
            objdata.ClFQty = this.ClFQty;
            objdata.ClFQtyRs = this.ClFQtyRs;
            objdata.TQty = this.TQty;
            objdata.TQtyRs = this.TQtyRs;
            objdata.BarSeries = this.BarSeries;
            objdata.BarCode = this.BarCode;
            objdata.BatchHead = this.BatchHead;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
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
            this.BatchCode = 0;
            this.ICode = string.Empty;;
            this.ProductCode = 0;
            this.AccountCode = 0;
            this.MRP = 0;
            this.BatchNo = string.Empty;;
            this.Expiry = new DateTime();
            this.Inclusive = string.Empty;;
            this.VatOn = string.Empty;;
            this.Vat = 0;
            this.AdVat = 0;
            this.Octroi = 0;
            this.PurRs = 0;
            this.SaleRs = 0;
            this.NetRate = 0;
            this.StockPt = 0;
            this.OpQty = 0;
            this.OpQtyRs = 0;
            this.OpFQty = 0;
            this.OpFQtyRs = 0;
            this.PurQty = 0;
            this.PurQtyRs = 0;
            this.PurFQty = 0;
            this.PurFQtyRs = 0;
            this.CrQty = 0;
            this.CrQtyRs = 0;
            this.CrFQty = 0;
            this.CrFQtyRs = 0;
            this.RcptQty = 0;
            this.RcptQtyRs = 0;
            this.SaleQty = 0;
            this.SaleQtyRs = 0;
            this.SaleFQty = 0;
            this.SaleFQtyRs = 0;
            this.IssueQty = 0;
            this.IssueQtyRs = 0;
            this.ClQty = 0;
            this.ClQtyRs = 0;
            this.ClFQty = 0;
            this.ClFQtyRs = 0;
            this.TQty = 0;
            this.TQtyRs = 0;
            this.BarSeries = string.Empty;;
            this.BarCode = string.Empty;;
            this.BatchHead = string.Empty;;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
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
