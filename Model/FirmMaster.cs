 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class FirmMaster : IModel,INotifyPropertyChanged
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
        private string     sFirmName;
        public string     FirmName
        {
            get { return sFirmName; }
            set
            {
                sFirmName = value;
                OnPropertyChanged("FirmName");
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
        private string     sArea;
        public string     Area
        {
            get { return sArea; }
            set
            {
                sArea = value;
                OnPropertyChanged("Area");
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
        private string     sPhoneNo;
        public string     PhoneNo
        {
            get { return sPhoneNo; }
            set
            {
                sPhoneNo = value;
                OnPropertyChanged("PhoneNo");
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
        private string     sVatNo;
        public string     VatNo
        {
            get { return sVatNo; }
            set
            {
                sVatNo = value;
                OnPropertyChanged("VatNo");
            }
        }
        private DateTime     dtVatDate;
        public DateTime     VatDate
        {
            get { return dtVatDate; }
            set
            {
                dtVatDate = value;
                OnPropertyChanged("VatDate");
            }
        }
        private string     sCSTVatNo;
        public string     CSTVatNo
        {
            get { return sCSTVatNo; }
            set
            {
                sCSTVatNo = value;
                OnPropertyChanged("CSTVatNo");
            }
        }
        private DateTime     dtCSTVatDate;
        public DateTime     CSTVatDate
        {
            get { return dtCSTVatDate; }
            set
            {
                dtCSTVatDate = value;
                OnPropertyChanged("CSTVatDate");
            }
        }
        private string     sDlNo1;
        public string     DlNo1
        {
            get { return sDlNo1; }
            set
            {
                sDlNo1 = value;
                OnPropertyChanged("DlNo1");
            }
        }
        private string     sDlNo2;
        public string     DlNo2
        {
            get { return sDlNo2; }
            set
            {
                sDlNo2 = value;
                OnPropertyChanged("DlNo2");
            }
        }
        private string     sRegKey;
        public string     RegKey
        {
            get { return sRegKey; }
            set
            {
                sRegKey = value;
                OnPropertyChanged("RegKey");
            }
        }
        private string     sDataPath;
        public string     DataPath
        {
            get { return sDataPath; }
            set
            {
                sDataPath = value;
                OnPropertyChanged("DataPath");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FirmName"))){
                    this.FirmName = DBReader.GetString(DBReader.GetOrdinal("FirmName"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Area"))){
                    this.Area = DBReader.GetString(DBReader.GetOrdinal("Area"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("City"))){
                    this.City = DBReader.GetString(DBReader.GetOrdinal("City"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PinCode"))){
                    this.PinCode = DBReader.GetString(DBReader.GetOrdinal("PinCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("KeyPerson"))){
                    this.KeyPerson = DBReader.GetString(DBReader.GetOrdinal("KeyPerson"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PhoneNo"))){
                    this.PhoneNo = DBReader.GetString(DBReader.GetOrdinal("PhoneNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Email"))){
                    this.Email = DBReader.GetString(DBReader.GetOrdinal("Email"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatNo"))){
                    this.VatNo = DBReader.GetString(DBReader.GetOrdinal("VatNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatDate"))){
                    this.VatDate = DBReader.GetDateTime(DBReader.GetOrdinal("VatDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CSTVatNo"))){
                    this.CSTVatNo = DBReader.GetString(DBReader.GetOrdinal("CSTVatNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CSTVatDate"))){
                    this.CSTVatDate = DBReader.GetDateTime(DBReader.GetOrdinal("CSTVatDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DlNo1"))){
                    this.DlNo1 = DBReader.GetString(DBReader.GetOrdinal("DlNo1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DlNo2"))){
                    this.DlNo2 = DBReader.GetString(DBReader.GetOrdinal("DlNo2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RegKey"))){
                    this.RegKey = DBReader.GetString(DBReader.GetOrdinal("RegKey"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DataPath"))){
                    this.DataPath = DBReader.GetString(DBReader.GetOrdinal("DataPath"));
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
            sXml.Append("<FirmName>" + this.FirmName + "</FirmName>");
            sXml.Append("<Add1>" + this.Add1 + "</Add1>");
            sXml.Append("<Add2>" + this.Add2 + "</Add2>");
            sXml.Append("<Add3>" + this.Add3 + "</Add3>");
            sXml.Append("<Area>" + this.Area + "</Area>");
            sXml.Append("<City>" + this.City + "</City>");
            sXml.Append("<PinCode>" + this.PinCode + "</PinCode>");
            sXml.Append("<KeyPerson>" + this.KeyPerson + "</KeyPerson>");
            sXml.Append("<PhoneNo>" + this.PhoneNo + "</PhoneNo>");
            sXml.Append("<Email>" + this.Email + "</Email>");
            sXml.Append("<VatNo>" + this.VatNo + "</VatNo>");
            sXml.Append("<VatDate>" + this.VatDate + "</VatDate>");
            sXml.Append("<CSTVatNo>" + this.CSTVatNo + "</CSTVatNo>");
            sXml.Append("<CSTVatDate>" + this.CSTVatDate + "</CSTVatDate>");
            sXml.Append("<DlNo1>" + this.DlNo1 + "</DlNo1>");
            sXml.Append("<DlNo2>" + this.DlNo2 + "</DlNo2>");
            sXml.Append("<RegKey>" + this.RegKey + "</RegKey>");
            sXml.Append("<DataPath>" + this.DataPath + "</DataPath>");
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
            FirmMaster objdata = obj as FirmMaster;
            this.RecNo = objdata.RecNo;
            this.FirmName = objdata.FirmName;
            this.Add1 = objdata.Add1;
            this.Add2 = objdata.Add2;
            this.Add3 = objdata.Add3;
            this.Area = objdata.Area;
            this.City = objdata.City;
            this.PinCode = objdata.PinCode;
            this.KeyPerson = objdata.KeyPerson;
            this.PhoneNo = objdata.PhoneNo;
            this.Email = objdata.Email;
            this.VatNo = objdata.VatNo;
            this.VatDate = objdata.VatDate;
            this.CSTVatNo = objdata.CSTVatNo;
            this.CSTVatDate = objdata.CSTVatDate;
            this.DlNo1 = objdata.DlNo1;
            this.DlNo2 = objdata.DlNo2;
            this.RegKey = objdata.RegKey;
            this.DataPath = objdata.DataPath;
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
            FirmMaster objdata = obj as FirmMaster;
            objdata.RecNo = this.RecNo;
            objdata.FirmName = this.FirmName;
            objdata.Add1 = this.Add1;
            objdata.Add2 = this.Add2;
            objdata.Add3 = this.Add3;
            objdata.Area = this.Area;
            objdata.City = this.City;
            objdata.PinCode = this.PinCode;
            objdata.KeyPerson = this.KeyPerson;
            objdata.PhoneNo = this.PhoneNo;
            objdata.Email = this.Email;
            objdata.VatNo = this.VatNo;
            objdata.VatDate = this.VatDate;
            objdata.CSTVatNo = this.CSTVatNo;
            objdata.CSTVatDate = this.CSTVatDate;
            objdata.DlNo1 = this.DlNo1;
            objdata.DlNo2 = this.DlNo2;
            objdata.RegKey = this.RegKey;
            objdata.DataPath = this.DataPath;
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
            this.FirmName = string.Empty;;
            this.Add1 = string.Empty;;
            this.Add2 = string.Empty;;
            this.Add3 = string.Empty;;
            this.Area = string.Empty;;
            this.City = string.Empty;;
            this.PinCode = string.Empty;;
            this.KeyPerson = string.Empty;;
            this.PhoneNo = string.Empty;;
            this.Email = string.Empty;;
            this.VatNo = string.Empty;;
            this.VatDate = new DateTime();
            this.CSTVatNo = string.Empty;;
            this.CSTVatDate = new DateTime();
            this.DlNo1 = string.Empty;;
            this.DlNo2 = string.Empty;;
            this.RegKey = string.Empty;;
            this.DataPath = string.Empty;;
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
