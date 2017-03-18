 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class BranchStock : IModel,INotifyPropertyChanged
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
        private string     sBranchName;
        public string     BranchName
        {
            get { return sBranchName; }
            set
            {
                sBranchName = value;
                OnPropertyChanged("BranchName");
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
        private long     nPartyPrdCode;
        public long     PartyPrdCode
        {
            get { return nPartyPrdCode; }
            set
            {
                nPartyPrdCode = value;
                OnPropertyChanged("PartyPrdCode");
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
        private string     sBranchCode;
        public string     BranchCode
        {
            get { return sBranchCode; }
            set
            {
                sBranchCode = value;
                OnPropertyChanged("BranchCode");
            }
        }
        private DateTime     dtUDateTime;
        public DateTime     UDateTime
        {
            get { return dtUDateTime; }
            set
            {
                dtUDateTime = value;
                OnPropertyChanged("UDateTime");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BranchName"))){
                    this.BranchName = DBReader.GetString(DBReader.GetOrdinal("BranchName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductCode"))){
                    this.ProductCode = DBReader.GetInt64(DBReader.GetOrdinal("ProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PartyPrdCode"))){
                    this.PartyPrdCode = DBReader.GetInt64(DBReader.GetOrdinal("PartyPrdCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductName"))){
                    this.ProductName = DBReader.GetString(DBReader.GetOrdinal("ProductName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Packing"))){
                    this.Packing = DBReader.GetString(DBReader.GetOrdinal("Packing"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyTag"))){
                    this.CompanyTag = DBReader.GetString(DBReader.GetOrdinal("CompanyTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RackID"))){
                    this.RackID = DBReader.GetString(DBReader.GetOrdinal("RackID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TStk"))){
                    this.TStk = DBReader.GetDecimal(DBReader.GetOrdinal("TStk"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BranchCode"))){
                    this.BranchCode = DBReader.GetString(DBReader.GetOrdinal("BranchCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("UDateTime"))){
                    this.UDateTime = DBReader.GetDateTime(DBReader.GetOrdinal("UDateTime"));
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
            sXml.Append("<BranchName>" + this.BranchName + "</BranchName>");
            sXml.Append("<ProductCode>" + this.ProductCode + "</ProductCode>");
            sXml.Append("<PartyPrdCode>" + this.PartyPrdCode + "</PartyPrdCode>");
            sXml.Append("<ProductName>" + this.ProductName + "</ProductName>");
            sXml.Append("<Packing>" + this.Packing + "</Packing>");
            sXml.Append("<CompanyTag>" + this.CompanyTag + "</CompanyTag>");
            sXml.Append("<RackID>" + this.RackID + "</RackID>");
            sXml.Append("<TStk>" + this.TStk + "</TStk>");
            sXml.Append("<Scheme>" + this.Scheme + "</Scheme>");
            sXml.Append("<SQty>" + this.SQty + "</SQty>");
            sXml.Append("<SFQty>" + this.SFQty + "</SFQty>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
            sXml.Append("<BranchCode>" + this.BranchCode + "</BranchCode>");
            sXml.Append("<UDateTime>" + this.UDateTime + "</UDateTime>");
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
            BranchStock objdata = obj as BranchStock;
            this.RecNo = objdata.RecNo;
            this.BranchName = objdata.BranchName;
            this.ProductCode = objdata.ProductCode;
            this.PartyPrdCode = objdata.PartyPrdCode;
            this.ProductName = objdata.ProductName;
            this.Packing = objdata.Packing;
            this.CompanyTag = objdata.CompanyTag;
            this.RackID = objdata.RackID;
            this.TStk = objdata.TStk;
            this.Scheme = objdata.Scheme;
            this.SQty = objdata.SQty;
            this.SFQty = objdata.SFQty;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
            this.BranchCode = objdata.BranchCode;
            this.UDateTime = objdata.UDateTime;
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
            BranchStock objdata = obj as BranchStock;
            objdata.RecNo = this.RecNo;
            objdata.BranchName = this.BranchName;
            objdata.ProductCode = this.ProductCode;
            objdata.PartyPrdCode = this.PartyPrdCode;
            objdata.ProductName = this.ProductName;
            objdata.Packing = this.Packing;
            objdata.CompanyTag = this.CompanyTag;
            objdata.RackID = this.RackID;
            objdata.TStk = this.TStk;
            objdata.Scheme = this.Scheme;
            objdata.SQty = this.SQty;
            objdata.SFQty = this.SFQty;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
            objdata.BranchCode = this.BranchCode;
            objdata.UDateTime = this.UDateTime;
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
            this.BranchName = string.Empty;;
            this.ProductCode = 0;
            this.PartyPrdCode = 0;
            this.ProductName = string.Empty;;
            this.Packing = string.Empty;;
            this.CompanyTag = string.Empty;;
            this.RackID = string.Empty;;
            this.TStk = 0;
            this.Scheme = 0;
            this.SQty = 0;
            this.SFQty = 0;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.BranchCode = string.Empty;;
            this.UDateTime = new DateTime();
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
