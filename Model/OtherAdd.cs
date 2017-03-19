 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class OtherAdd : IModel,INotifyPropertyChanged
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
        private string     sAddName;
        public string     AddName
        {
            get { return sAddName; }
            set
            {
                sAddName = value;
                OnPropertyChanged("AddName");
            }
        }
        private string     sKeyPerson;
        public string     KeyPerson
        {
            get { return sKeyPerson; }
            set
            {
                sKeyPerson = value;
                OnPropertyChanged("KeyPerson");
            }
        }
        private string     sAddress1;
        public string     Address1
        {
            get { return sAddress1; }
            set
            {
                sAddress1 = value;
                OnPropertyChanged("Address1");
            }
        }
        private string     sAddress2;
        public string     Address2
        {
            get { return sAddress2; }
            set
            {
                sAddress2 = value;
                OnPropertyChanged("Address2");
            }
        }
        private string     sAddress3;
        public string     Address3
        {
            get { return sAddress3; }
            set
            {
                sAddress3 = value;
                OnPropertyChanged("Address3");
            }
        }
        private string     sCity;
        public string     City
        {
            get { return sCity; }
            set
            {
                sCity = value;
                OnPropertyChanged("City");
            }
        }
        private string     sMobile;
        public string     Mobile
        {
            get { return sMobile; }
            set
            {
                sMobile = value;
                OnPropertyChanged("Mobile");
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
        private string     sPhone2;
        public string     Phone2
        {
            get { return sPhone2; }
            set
            {
                sPhone2 = value;
                OnPropertyChanged("Phone2");
            }
        }
        private string     sPhoneR;
        public string     PhoneR
        {
            get { return sPhoneR; }
            set
            {
                sPhoneR = value;
                OnPropertyChanged("PhoneR");
            }
        }
        private string     sFax;
        public string     Fax
        {
            get { return sFax; }
            set
            {
                sFax = value;
                OnPropertyChanged("Fax");
            }
        }
        private string     sEmail;
        public string     Email
        {
            get { return sEmail; }
            set
            {
                sEmail = value;
                OnPropertyChanged("Email");
            }
        }
        private string     sCategory;
        public string     Category
        {
            get { return sCategory; }
            set
            {
                sCategory = value;
                OnPropertyChanged("Category");
            }
        }
        private string     sAddNote;
        public string     AddNote
        {
            get { return sAddNote; }
            set
            {
                sAddNote = value;
                OnPropertyChanged("AddNote");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RecNo"))){
                    this.RecNo = DBReader.GetInt64(DBReader.GetOrdinal("RecNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AddName"))){
                    this.AddName = DBReader.GetString(DBReader.GetOrdinal("AddName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("KeyPerson"))){
                    this.KeyPerson = DBReader.GetString(DBReader.GetOrdinal("KeyPerson"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Address1"))){
                    this.Address1 = DBReader.GetString(DBReader.GetOrdinal("Address1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Address2"))){
                    this.Address2 = DBReader.GetString(DBReader.GetOrdinal("Address2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Address3"))){
                    this.Address3 = DBReader.GetString(DBReader.GetOrdinal("Address3"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("City"))){
                    this.City = DBReader.GetString(DBReader.GetOrdinal("City"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Mobile"))){
                    this.Mobile = DBReader.GetString(DBReader.GetOrdinal("Mobile"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone1"))){
                    this.Phone1 = DBReader.GetString(DBReader.GetOrdinal("Phone1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone2"))){
                    this.Phone2 = DBReader.GetString(DBReader.GetOrdinal("Phone2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PhoneR"))){
                    this.PhoneR = DBReader.GetString(DBReader.GetOrdinal("PhoneR"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Fax"))){
                    this.Fax = DBReader.GetString(DBReader.GetOrdinal("Fax"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Email"))){
                    this.Email = DBReader.GetString(DBReader.GetOrdinal("Email"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Category"))){
                    this.Category = DBReader.GetString(DBReader.GetOrdinal("Category"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AddNote"))){
                    this.AddNote = DBReader.GetString(DBReader.GetOrdinal("AddNote"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ImageName"))){
                    this.ImageName = DBReader.GetString(DBReader.GetOrdinal("ImageName"));
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
            sXml.Append("<RecNo>" + this.RecNo + "</RecNo>");
            sXml.Append("<AddName>" + this.AddName + "</AddName>");
            sXml.Append("<KeyPerson>" + this.KeyPerson + "</KeyPerson>");
            sXml.Append("<Address1>" + this.Address1 + "</Address1>");
            sXml.Append("<Address2>" + this.Address2 + "</Address2>");
            sXml.Append("<Address3>" + this.Address3 + "</Address3>");
            sXml.Append("<City>" + this.City + "</City>");
            sXml.Append("<Mobile>" + this.Mobile + "</Mobile>");
            sXml.Append("<Phone1>" + this.Phone1 + "</Phone1>");
            sXml.Append("<Phone2>" + this.Phone2 + "</Phone2>");
            sXml.Append("<PhoneR>" + this.PhoneR + "</PhoneR>");
            sXml.Append("<Fax>" + this.Fax + "</Fax>");
            sXml.Append("<Email>" + this.Email + "</Email>");
            sXml.Append("<Category>" + this.Category + "</Category>");
            sXml.Append("<AddNote>" + this.AddNote + "</AddNote>");
            sXml.Append("<ImageName>" + this.ImageName + "</ImageName>");
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
            OtherAdd objdata = obj as OtherAdd;
            this.RecNo = objdata.RecNo;
            this.AddName = objdata.AddName;
            this.KeyPerson = objdata.KeyPerson;
            this.Address1 = objdata.Address1;
            this.Address2 = objdata.Address2;
            this.Address3 = objdata.Address3;
            this.City = objdata.City;
            this.Mobile = objdata.Mobile;
            this.Phone1 = objdata.Phone1;
            this.Phone2 = objdata.Phone2;
            this.PhoneR = objdata.PhoneR;
            this.Fax = objdata.Fax;
            this.Email = objdata.Email;
            this.Category = objdata.Category;
            this.AddNote = objdata.AddNote;
            this.ImageName = objdata.ImageName;
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
            OtherAdd objdata = obj as OtherAdd;
            objdata.RecNo = this.RecNo;
            objdata.AddName = this.AddName;
            objdata.KeyPerson = this.KeyPerson;
            objdata.Address1 = this.Address1;
            objdata.Address2 = this.Address2;
            objdata.Address3 = this.Address3;
            objdata.City = this.City;
            objdata.Mobile = this.Mobile;
            objdata.Phone1 = this.Phone1;
            objdata.Phone2 = this.Phone2;
            objdata.PhoneR = this.PhoneR;
            objdata.Fax = this.Fax;
            objdata.Email = this.Email;
            objdata.Category = this.Category;
            objdata.AddNote = this.AddNote;
            objdata.ImageName = this.ImageName;
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
            this.RecNo = 0;
            this.AddName = string.Empty;;
            this.KeyPerson = string.Empty;;
            this.Address1 = string.Empty;;
            this.Address2 = string.Empty;;
            this.Address3 = string.Empty;;
            this.City = string.Empty;;
            this.Mobile = string.Empty;;
            this.Phone1 = string.Empty;;
            this.Phone2 = string.Empty;;
            this.PhoneR = string.Empty;;
            this.Fax = string.Empty;;
            this.Email = string.Empty;;
            this.Category = string.Empty;;
            this.AddNote = string.Empty;;
            this.ImageName = string.Empty;;
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
