 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class AddressBook : IModel,INotifyPropertyChanged
    {
        private long     nAddCode;
        public long     AddCode
        {
            get { return nAddCode; }
            set
            {
                nAddCode = value;
                OnPropertyChanged("AddCode");
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
        private string     sContactPerson;
        public string     ContactPerson
        {
            get { return sContactPerson; }
            set
            {
                sContactPerson = value;
                OnPropertyChanged("ContactPerson");
            }
        }
        private string     sAdd1;
        public string     Add1
        {
            get { return sAdd1; }
            set
            {
                sAdd1 = value;
                OnPropertyChanged("Add1");
            }
        }
        private string     sAdd2;
        public string     Add2
        {
            get { return sAdd2; }
            set
            {
                sAdd2 = value;
                OnPropertyChanged("Add2");
            }
        }
        private string     sAdd3;
        public string     Add3
        {
            get { return sAdd3; }
            set
            {
                sAdd3 = value;
                OnPropertyChanged("Add3");
            }
        }
        private string     sCityName;
        public string     CityName
        {
            get { return sCityName; }
            set
            {
                sCityName = value;
                OnPropertyChanged("CityName");
            }
        }
        private string     sPinCode;
        public string     PinCode
        {
            get { return sPinCode; }
            set
            {
                sPinCode = value;
                OnPropertyChanged("PinCode");
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
        private string     sRelWith;
        public string     RelWith
        {
            get { return sRelWith; }
            set
            {
                sRelWith = value;
                OnPropertyChanged("RelWith");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AddCode"))){
                    this.AddCode = DBReader.GetInt64(DBReader.GetOrdinal("AddCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AddName"))){
                    this.AddName = DBReader.GetString(DBReader.GetOrdinal("AddName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ContactPerson"))){
                    this.ContactPerson = DBReader.GetString(DBReader.GetOrdinal("ContactPerson"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add1"))){
                    this.Add1 = DBReader.GetString(DBReader.GetOrdinal("Add1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add2"))){
                    this.Add2 = DBReader.GetString(DBReader.GetOrdinal("Add2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add3"))){
                    this.Add3 = DBReader.GetString(DBReader.GetOrdinal("Add3"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CityName"))){
                    this.CityName = DBReader.GetString(DBReader.GetOrdinal("CityName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PinCode"))){
                    this.PinCode = DBReader.GetString(DBReader.GetOrdinal("PinCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone1"))){
                    this.Phone1 = DBReader.GetString(DBReader.GetOrdinal("Phone1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone2"))){
                    this.Phone2 = DBReader.GetString(DBReader.GetOrdinal("Phone2"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RelWith"))){
                    this.RelWith = DBReader.GetString(DBReader.GetOrdinal("RelWith"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AddNote"))){
                    this.AddNote = DBReader.GetString(DBReader.GetOrdinal("AddNote"));
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
            sXml.Append("<AddCode>" + this.AddCode + "</AddCode>");
            sXml.Append("<AddName>" + this.AddName + "</AddName>");
            sXml.Append("<ContactPerson>" + this.ContactPerson + "</ContactPerson>");
            sXml.Append("<Add1>" + this.Add1 + "</Add1>");
            sXml.Append("<Add2>" + this.Add2 + "</Add2>");
            sXml.Append("<Add3>" + this.Add3 + "</Add3>");
            sXml.Append("<CityName>" + this.CityName + "</CityName>");
            sXml.Append("<PinCode>" + this.PinCode + "</PinCode>");
            sXml.Append("<Phone1>" + this.Phone1 + "</Phone1>");
            sXml.Append("<Phone2>" + this.Phone2 + "</Phone2>");
            sXml.Append("<Fax>" + this.Fax + "</Fax>");
            sXml.Append("<Email>" + this.Email + "</Email>");
            sXml.Append("<Category>" + this.Category + "</Category>");
            sXml.Append("<RelWith>" + this.RelWith + "</RelWith>");
            sXml.Append("<AddNote>" + this.AddNote + "</AddNote>");
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
            AddressBook objdata = obj as AddressBook;
            this.AddCode = objdata.AddCode;
            this.AddName = objdata.AddName;
            this.ContactPerson = objdata.ContactPerson;
            this.Add1 = objdata.Add1;
            this.Add2 = objdata.Add2;
            this.Add3 = objdata.Add3;
            this.CityName = objdata.CityName;
            this.PinCode = objdata.PinCode;
            this.Phone1 = objdata.Phone1;
            this.Phone2 = objdata.Phone2;
            this.Fax = objdata.Fax;
            this.Email = objdata.Email;
            this.Category = objdata.Category;
            this.RelWith = objdata.RelWith;
            this.AddNote = objdata.AddNote;
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
            AddressBook objdata = obj as AddressBook;
            objdata.AddCode = this.AddCode;
            objdata.AddName = this.AddName;
            objdata.ContactPerson = this.ContactPerson;
            objdata.Add1 = this.Add1;
            objdata.Add2 = this.Add2;
            objdata.Add3 = this.Add3;
            objdata.CityName = this.CityName;
            objdata.PinCode = this.PinCode;
            objdata.Phone1 = this.Phone1;
            objdata.Phone2 = this.Phone2;
            objdata.Fax = this.Fax;
            objdata.Email = this.Email;
            objdata.Category = this.Category;
            objdata.RelWith = this.RelWith;
            objdata.AddNote = this.AddNote;
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
            this.AddCode = 0;
            this.AddName = string.Empty;;
            this.ContactPerson = string.Empty;;
            this.Add1 = string.Empty;;
            this.Add2 = string.Empty;;
            this.Add3 = string.Empty;;
            this.CityName = string.Empty;;
            this.PinCode = string.Empty;;
            this.Phone1 = string.Empty;;
            this.Phone2 = string.Empty;;
            this.Fax = string.Empty;;
            this.Email = string.Empty;;
            this.Category = string.Empty;;
            this.RelWith = string.Empty;;
            this.AddNote = string.Empty;;
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
