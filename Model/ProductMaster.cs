 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class ProductMaster : IModel,INotifyPropertyChanged
    {
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
        private string     sProductName;
        public string     ProductName
        {
            get { return sProductName; }
            set
            {
                sProductName = value;
                OnPropertyChanged("ProductName");
            }
        }
        private string     sPacking;
        public string     Packing
        {
            get { return sPacking; }
            set
            {
                sPacking = value;
                OnPropertyChanged("Packing");
            }
        }
        private string     sPackingType;
        public string     PackingType
        {
            get { return sPackingType; }
            set
            {
                sPackingType = value;
                OnPropertyChanged("PackingType");
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
        private long     nCategoryCode;
        public long     CategoryCode
        {
            get { return nCategoryCode; }
            set
            {
                nCategoryCode = value;
                OnPropertyChanged("CategoryCode");
            }
        }
        private long     nGenericCode;
        public long     GenericCode
        {
            get { return nGenericCode; }
            set
            {
                nGenericCode = value;
                OnPropertyChanged("GenericCode");
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
        private decimal     nSplRate;
        public decimal     SplRate
        {
            get { return nSplRate; }
            set
            {
                nSplRate = value;
                OnPropertyChanged("SplRate");
            }
        }
        private string     sDiscYN;
        public string     DiscYN
        {
            get { return sDiscYN; }
            set
            {
                sDiscYN = value;
                OnPropertyChanged("DiscYN");
            }
        }
        private decimal     nDiscount;
        public decimal     Discount
        {
            get { return nDiscount; }
            set
            {
                nDiscount = value;
                OnPropertyChanged("Discount");
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
        private decimal     nCST;
        public decimal     CST
        {
            get { return nCST; }
            set
            {
                nCST = value;
                OnPropertyChanged("CST");
            }
        }
        private string     sBarPrint;
        public string     BarPrint
        {
            get { return sBarPrint; }
            set
            {
                sBarPrint = value;
                OnPropertyChanged("BarPrint");
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
        private decimal     nMinQty;
        public decimal     MinQty
        {
            get { return nMinQty; }
            set
            {
                nMinQty = value;
                OnPropertyChanged("MinQty");
            }
        }
        private decimal     nMaxQty;
        public decimal     MaxQty
        {
            get { return nMaxQty; }
            set
            {
                nMaxQty = value;
                OnPropertyChanged("MaxQty");
            }
        }
        private decimal     nReOrderQty;
        public decimal     ReOrderQty
        {
            get { return nReOrderQty; }
            set
            {
                nReOrderQty = value;
                OnPropertyChanged("ReOrderQty");
            }
        }
        private string     sRackID;
        public string     RackID
        {
            get { return sRackID; }
            set
            {
                sRackID = value;
                OnPropertyChanged("RackID");
            }
        }
        private decimal     nTStk;
        public decimal     TStk
        {
            get { return nTStk; }
            set
            {
                nTStk = value;
                OnPropertyChanged("TStk");
            }
        }
        private decimal     nLPurRs;
        public decimal     LPurRs
        {
            get { return nLPurRs; }
            set
            {
                nLPurRs = value;
                OnPropertyChanged("LPurRs");
            }
        }
        private string     sImageName;
        public string     ImageName
        {
            get { return sImageName; }
            set
            {
                sImageName = value;
                OnPropertyChanged("ImageName");
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
        private decimal     nSQty;
        public decimal     SQty
        {
            get { return nSQty; }
            set
            {
                nSQty = value;
                OnPropertyChanged("SQty");
            }
        }
        private decimal     nSFQty;
        public decimal     SFQty
        {
            get { return nSFQty; }
            set
            {
                nSFQty = value;
                OnPropertyChanged("SFQty");
            }
        }
        private string     sNDRX;
        public string     NDRX
        {
            get { return sNDRX; }
            set
            {
                sNDRX = value;
                OnPropertyChanged("NDRX");
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
        private long     nSaleCatCode;
        public long     SaleCatCode
        {
            get { return nSaleCatCode; }
            set
            {
                nSaleCatCode = value;
                OnPropertyChanged("SaleCatCode");
            }
        }
        private long     nOldProductCode;
        public long     OldProductCode
        {
            get { return nOldProductCode; }
            set
            {
                nOldProductCode = value;
                OnPropertyChanged("OldProductCode");
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
        private string     sSchDrg;
        public string     SchDrg
        {
            get { return sSchDrg; }
            set
            {
                sSchDrg = value;
                OnPropertyChanged("SchDrg");
            }
        }
        private string     sNote1;
        public string     Note1
        {
            get { return sNote1; }
            set
            {
                sNote1 = value;
                OnPropertyChanged("Note1");
            }
        }
        private string     sFav;
        public string     Fav
        {
            get { return sFav; }
            set
            {
                sFav = value;
                OnPropertyChanged("Fav");
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

        private int totalQty;
        public int TotalQty
        {
            get { return this.totalQty; }
            set
            {
                this.totalQty = value;
                OnPropertyChanged("TotalQty");
            }
        }
        private decimal totalAmount;
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set
            {
                totalAmount = value;
                OnPropertyChanged("TotalAmount");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductCode"))){
                    this.ProductCode = DBReader.GetInt64(DBReader.GetOrdinal("ProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ICode"))){
                    this.ICode = DBReader.GetString(DBReader.GetOrdinal("ICode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductName"))){
                    this.ProductName = DBReader.GetString(DBReader.GetOrdinal("ProductName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Packing"))){
                    this.Packing = DBReader.GetString(DBReader.GetOrdinal("Packing"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PackingType"))){
                    this.PackingType = DBReader.GetString(DBReader.GetOrdinal("PackingType"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ConversionUnit"))){
                    this.ConversionUnit = DBReader.GetDecimal(DBReader.GetOrdinal("ConversionUnit"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyTag"))){
                    this.CompanyTag = DBReader.GetString(DBReader.GetOrdinal("CompanyTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyCode"))){
                    this.CompanyCode = DBReader.GetInt64(DBReader.GetOrdinal("CompanyCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CategoryCode"))){
                    this.CategoryCode = DBReader.GetInt64(DBReader.GetOrdinal("CategoryCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("GenericCode"))){
                    this.GenericCode = DBReader.GetInt64(DBReader.GetOrdinal("GenericCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Rate"))){
                    this.Rate = DBReader.GetDecimal(DBReader.GetOrdinal("Rate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SplRate"))){
                    this.SplRate = DBReader.GetDecimal(DBReader.GetOrdinal("SplRate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DiscYN"))){
                    this.DiscYN = DBReader.GetString(DBReader.GetOrdinal("DiscYN"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Discount"))){
                    this.Discount = DBReader.GetDecimal(DBReader.GetOrdinal("Discount"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CST"))){
                    this.CST = DBReader.GetDecimal(DBReader.GetOrdinal("CST"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BarPrint"))){
                    this.BarPrint = DBReader.GetString(DBReader.GetOrdinal("BarPrint"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BarCode"))){
                    this.BarCode = DBReader.GetString(DBReader.GetOrdinal("BarCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MinQty"))){
                    this.MinQty = DBReader.GetDecimal(DBReader.GetOrdinal("MinQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MaxQty"))){
                    this.MaxQty = DBReader.GetDecimal(DBReader.GetOrdinal("MaxQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReOrderQty"))){
                    this.ReOrderQty = DBReader.GetDecimal(DBReader.GetOrdinal("ReOrderQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RackID"))){
                    this.RackID = DBReader.GetString(DBReader.GetOrdinal("RackID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TStk"))){
                    this.TStk = DBReader.GetDecimal(DBReader.GetOrdinal("TStk"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LPurRs"))){
                    this.LPurRs = DBReader.GetDecimal(DBReader.GetOrdinal("LPurRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ImageName"))){
                    this.ImageName = DBReader.GetString(DBReader.GetOrdinal("ImageName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Scheme"))){
                    this.Scheme = DBReader.GetDecimal(DBReader.GetOrdinal("Scheme"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SQty"))){
                    this.SQty = DBReader.GetDecimal(DBReader.GetOrdinal("SQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SFQty"))){
                    this.SFQty = DBReader.GetDecimal(DBReader.GetOrdinal("SFQty"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NDRX"))){
                    this.NDRX = DBReader.GetString(DBReader.GetOrdinal("NDRX"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SaleCatCode"))){
                    this.SaleCatCode = DBReader.GetInt64(DBReader.GetOrdinal("SaleCatCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OldProductCode"))){
                    this.OldProductCode = DBReader.GetInt64(DBReader.GetOrdinal("OldProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DoctorCode"))){
                    this.DoctorCode = DBReader.GetInt64(DBReader.GetOrdinal("DoctorCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DLock"))){
                    this.DLock = DBReader.GetString(DBReader.GetOrdinal("DLock"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SchDrg"))){
                    this.SchDrg = DBReader.GetString(DBReader.GetOrdinal("SchDrg"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Note1"))){
                    this.Note1 = DBReader.GetString(DBReader.GetOrdinal("Note1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Fav"))){
                    this.Fav = DBReader.GetString(DBReader.GetOrdinal("Fav"));
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
            sXml.Append("<ProductCode>" + this.ProductCode + "</ProductCode>");
            sXml.Append("<ICode>" + this.ICode + "</ICode>");
            sXml.Append("<ProductName>" + this.ProductName + "</ProductName>");
            sXml.Append("<Packing>" + this.Packing + "</Packing>");
            sXml.Append("<PackingType>" + this.PackingType + "</PackingType>");
            sXml.Append("<ConversionUnit>" + this.ConversionUnit + "</ConversionUnit>");
            sXml.Append("<CompanyTag>" + this.CompanyTag + "</CompanyTag>");
            sXml.Append("<CompanyCode>" + this.CompanyCode + "</CompanyCode>");
            sXml.Append("<CategoryCode>" + this.CategoryCode + "</CategoryCode>");
            sXml.Append("<GenericCode>" + this.GenericCode + "</GenericCode>");
            sXml.Append("<Rate>" + this.Rate + "</Rate>");
            sXml.Append("<SplRate>" + this.SplRate + "</SplRate>");
            sXml.Append("<DiscYN>" + this.DiscYN + "</DiscYN>");
            sXml.Append("<Discount>" + this.Discount + "</Discount>");
            sXml.Append("<Inclusive>" + this.Inclusive + "</Inclusive>");
            sXml.Append("<VatOn>" + this.VatOn + "</VatOn>");
            sXml.Append("<Vat>" + this.Vat + "</Vat>");
            sXml.Append("<AdVat>" + this.AdVat + "</AdVat>");
            sXml.Append("<CST>" + this.CST + "</CST>");
            sXml.Append("<BarPrint>" + this.BarPrint + "</BarPrint>");
            sXml.Append("<BarCode>" + this.BarCode + "</BarCode>");
            sXml.Append("<MinQty>" + this.MinQty + "</MinQty>");
            sXml.Append("<MaxQty>" + this.MaxQty + "</MaxQty>");
            sXml.Append("<ReOrderQty>" + this.ReOrderQty + "</ReOrderQty>");
            sXml.Append("<RackID>" + this.RackID + "</RackID>");
            sXml.Append("<TStk>" + this.TStk + "</TStk>");
            sXml.Append("<LPurRs>" + this.LPurRs + "</LPurRs>");
            sXml.Append("<ImageName>" + this.ImageName + "</ImageName>");
            sXml.Append("<Scheme>" + this.Scheme + "</Scheme>");
            sXml.Append("<SQty>" + this.SQty + "</SQty>");
            sXml.Append("<SFQty>" + this.SFQty + "</SFQty>");
            sXml.Append("<NDRX>" + this.NDRX + "</NDRX>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
            sXml.Append("<LCode>" + this.LCode + "</LCode>");
            sXml.Append("<SaleCatCode>" + this.SaleCatCode + "</SaleCatCode>");
            sXml.Append("<OldProductCode>" + this.OldProductCode + "</OldProductCode>");
            sXml.Append("<DoctorCode>" + this.DoctorCode + "</DoctorCode>");
            sXml.Append("<DLock>" + this.DLock + "</DLock>");
            sXml.Append("<SchDrg>" + this.SchDrg + "</SchDrg>");
            sXml.Append("<Note1>" + this.Note1 + "</Note1>");
            sXml.Append("<Fav>" + this.Fav + "</Fav>");
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
            ProductMaster objdata = obj as ProductMaster;
            this.ProductCode = objdata.ProductCode;
            this.ICode = objdata.ICode;
            this.ProductName = objdata.ProductName;
            this.Packing = objdata.Packing;
            this.PackingType = objdata.PackingType;
            this.ConversionUnit = objdata.ConversionUnit;
            this.CompanyTag = objdata.CompanyTag;
            this.CompanyCode = objdata.CompanyCode;
            this.CategoryCode = objdata.CategoryCode;
            this.GenericCode = objdata.GenericCode;
            this.Rate = objdata.Rate;
            this.SplRate = objdata.SplRate;
            this.DiscYN = objdata.DiscYN;
            this.Discount = objdata.Discount;
            this.Inclusive = objdata.Inclusive;
            this.VatOn = objdata.VatOn;
            this.Vat = objdata.Vat;
            this.AdVat = objdata.AdVat;
            this.CST = objdata.CST;
            this.BarPrint = objdata.BarPrint;
            this.BarCode = objdata.BarCode;
            this.MinQty = objdata.MinQty;
            this.MaxQty = objdata.MaxQty;
            this.ReOrderQty = objdata.ReOrderQty;
            this.RackID = objdata.RackID;
            this.TStk = objdata.TStk;
            this.LPurRs = objdata.LPurRs;
            this.ImageName = objdata.ImageName;
            this.Scheme = objdata.Scheme;
            this.SQty = objdata.SQty;
            this.SFQty = objdata.SFQty;
            this.NDRX = objdata.NDRX;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
            this.LCode = objdata.LCode;
            this.SaleCatCode = objdata.SaleCatCode;
            this.OldProductCode = objdata.OldProductCode;
            this.DoctorCode = objdata.DoctorCode;
            this.DLock = objdata.DLock;
            this.SchDrg = objdata.SchDrg;
            this.Note1 = objdata.Note1;
            this.Fav = objdata.Fav;
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
            ProductMaster objdata = obj as ProductMaster;
            objdata.ProductCode = this.ProductCode;
            objdata.ICode = this.ICode;
            objdata.ProductName = this.ProductName;
            objdata.Packing = this.Packing;
            objdata.PackingType = this.PackingType;
            objdata.ConversionUnit = this.ConversionUnit;
            objdata.CompanyTag = this.CompanyTag;
            objdata.CompanyCode = this.CompanyCode;
            objdata.CategoryCode = this.CategoryCode;
            objdata.GenericCode = this.GenericCode;
            objdata.Rate = this.Rate;
            objdata.SplRate = this.SplRate;
            objdata.DiscYN = this.DiscYN;
            objdata.Discount = this.Discount;
            objdata.Inclusive = this.Inclusive;
            objdata.VatOn = this.VatOn;
            objdata.Vat = this.Vat;
            objdata.AdVat = this.AdVat;
            objdata.CST = this.CST;
            objdata.BarPrint = this.BarPrint;
            objdata.BarCode = this.BarCode;
            objdata.MinQty = this.MinQty;
            objdata.MaxQty = this.MaxQty;
            objdata.ReOrderQty = this.ReOrderQty;
            objdata.RackID = this.RackID;
            objdata.TStk = this.TStk;
            objdata.LPurRs = this.LPurRs;
            objdata.ImageName = this.ImageName;
            objdata.Scheme = this.Scheme;
            objdata.SQty = this.SQty;
            objdata.SFQty = this.SFQty;
            objdata.NDRX = this.NDRX;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
            objdata.LCode = this.LCode;
            objdata.SaleCatCode = this.SaleCatCode;
            objdata.OldProductCode = this.OldProductCode;
            objdata.DoctorCode = this.DoctorCode;
            objdata.DLock = this.DLock;
            objdata.SchDrg = this.SchDrg;
            objdata.Note1 = this.Note1;
            objdata.Fav = this.Fav;
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
            this.ProductCode = 0;
            this.ICode = string.Empty;;
            this.ProductName = string.Empty;;
            this.Packing = string.Empty;;
            this.PackingType = string.Empty;;
            this.ConversionUnit = 0;
            this.CompanyTag = string.Empty;;
            this.CompanyCode = 0;
            this.CategoryCode = 0;
            this.GenericCode = 0;
            this.Rate = 0;
            this.SplRate = 0;
            this.DiscYN = string.Empty;;
            this.Discount = 0;
            this.Inclusive = string.Empty;;
            this.VatOn = string.Empty;;
            this.Vat = 0;
            this.AdVat = 0;
            this.CST = 0;
            this.BarPrint = string.Empty;;
            this.BarCode = string.Empty;;
            this.MinQty = 0;
            this.MaxQty = 0;
            this.ReOrderQty = 0;
            this.RackID = string.Empty;;
            this.TStk = 0;
            this.LPurRs = 0;
            this.ImageName = string.Empty;;
            this.Scheme = 0;
            this.SQty = 0;
            this.SFQty = 0;
            this.NDRX = string.Empty;;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.LCode = 0;
            this.SaleCatCode = 0;
            this.OldProductCode = 0;
            this.DoctorCode = 0;
            this.DLock = string.Empty;;
            this.SchDrg = string.Empty;;
            this.Note1 = string.Empty;;
            this.Fav = string.Empty;;
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
