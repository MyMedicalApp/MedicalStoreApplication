 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class MapProduct : IModel,INotifyPropertyChanged
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
        private string     sPartyProdCode;
        public string     PartyProdCode
        {
            get { return sPartyProdCode; }
            set
            {
                sPartyProdCode = value;
                OnPropertyChanged("PartyProdCode");
            }
        }
        private string     sPartyProdName;
        public string     PartyProdName
        {
            get { return sPartyProdName; }
            set
            {
                sPartyProdName = value;
                OnPropertyChanged("PartyProdName");
            }
        }
        private string     sPartyProdPacking;
        public string     PartyProdPacking
        {
            get { return sPartyProdPacking; }
            set
            {
                sPartyProdPacking = value;
                OnPropertyChanged("PartyProdPacking");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode"))){
                    this.AccountCode = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PartyProdCode"))){
                    this.PartyProdCode = DBReader.GetString(DBReader.GetOrdinal("PartyProdCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PartyProdName"))){
                    this.PartyProdName = DBReader.GetString(DBReader.GetOrdinal("PartyProdName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PartyProdPacking"))){
                    this.PartyProdPacking = DBReader.GetString(DBReader.GetOrdinal("PartyProdPacking"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductCode"))){
                    this.ProductCode = DBReader.GetInt64(DBReader.GetOrdinal("ProductCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ProductName"))){
                    this.ProductName = DBReader.GetString(DBReader.GetOrdinal("ProductName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Packing"))){
                    this.Packing = DBReader.GetString(DBReader.GetOrdinal("Packing"));
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
            sXml.Append("<AccountCode>" + this.AccountCode + "</AccountCode>");
            sXml.Append("<PartyProdCode>" + this.PartyProdCode + "</PartyProdCode>");
            sXml.Append("<PartyProdName>" + this.PartyProdName + "</PartyProdName>");
            sXml.Append("<PartyProdPacking>" + this.PartyProdPacking + "</PartyProdPacking>");
            sXml.Append("<ProductCode>" + this.ProductCode + "</ProductCode>");
            sXml.Append("<ProductName>" + this.ProductName + "</ProductName>");
            sXml.Append("<Packing>" + this.Packing + "</Packing>");
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
            MapProduct objdata = obj as MapProduct;
            this.RecNo = objdata.RecNo;
            this.AccountCode = objdata.AccountCode;
            this.PartyProdCode = objdata.PartyProdCode;
            this.PartyProdName = objdata.PartyProdName;
            this.PartyProdPacking = objdata.PartyProdPacking;
            this.ProductCode = objdata.ProductCode;
            this.ProductName = objdata.ProductName;
            this.Packing = objdata.Packing;
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
            MapProduct objdata = obj as MapProduct;
            objdata.RecNo = this.RecNo;
            objdata.AccountCode = this.AccountCode;
            objdata.PartyProdCode = this.PartyProdCode;
            objdata.PartyProdName = this.PartyProdName;
            objdata.PartyProdPacking = this.PartyProdPacking;
            objdata.ProductCode = this.ProductCode;
            objdata.ProductName = this.ProductName;
            objdata.Packing = this.Packing;
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
            this.AccountCode = 0;
            this.PartyProdCode = string.Empty;;
            this.PartyProdName = string.Empty;;
            this.PartyProdPacking = string.Empty;;
            this.ProductCode = 0;
            this.ProductName = string.Empty;;
            this.Packing = string.Empty;;
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
