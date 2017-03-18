 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class AccountMaster : IModel,INotifyPropertyChanged
    {
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
        private string     sAccountName;
        public string     AccountName
        {
            get { return sAccountName; }
            set
            {
                sAccountName = value;
                OnPropertyChanged("AccountName");
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
        private string     sAdd4;
        public string     Add4
        {
            get { return sAdd4; }
            set
            {
                sAdd4 = value;
                OnPropertyChanged("Add4");
            }
        }
        private long     nCityCode;
        public long     CityCode
        {
            get { return nCityCode; }
            set
            {
                nCityCode = value;
                OnPropertyChanged("CityCode");
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
        private string     sDLNo1;
        public string     DLNo1
        {
            get { return sDLNo1; }
            set
            {
                sDLNo1 = value;
                OnPropertyChanged("DLNo1");
            }
        }
        private string     sDLNo2;
        public string     DLNo2
        {
            get { return sDLNo2; }
            set
            {
                sDLNo2 = value;
                OnPropertyChanged("DLNo2");
            }
        }
        private string     sVatTin;
        public string     VatTin
        {
            get { return sVatTin; }
            set
            {
                sVatTin = value;
                OnPropertyChanged("VatTin");
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
        private string     sCSTVat;
        public string     CSTVat
        {
            get { return sCSTVat; }
            set
            {
                sCSTVat = value;
                OnPropertyChanged("CSTVat");
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
        private decimal     nCashDiscount;
        public decimal     CashDiscount
        {
            get { return nCashDiscount; }
            set
            {
                nCashDiscount = value;
                OnPropertyChanged("CashDiscount");
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
        private string     sAccountType;
        public string     AccountType
        {
            get { return sAccountType; }
            set
            {
                sAccountType = value;
                OnPropertyChanged("AccountType");
            }
        }
        private long     nGroupCode;
        public long     GroupCode
        {
            get { return nGroupCode; }
            set
            {
                nGroupCode = value;
                OnPropertyChanged("GroupCode");
            }
        }
        private string     sVisitDay;
        public string     VisitDay
        {
            get { return sVisitDay; }
            set
            {
                sVisitDay = value;
                OnPropertyChanged("VisitDay");
            }
        }
        private string     sInfoID;
        public string     InfoID
        {
            get { return sInfoID; }
            set
            {
                sInfoID = value;
                OnPropertyChanged("InfoID");
            }
        }
        private decimal     nOpBalAmount;
        public decimal     OpBalAmount
        {
            get { return nOpBalAmount; }
            set
            {
                nOpBalAmount = value;
                OnPropertyChanged("OpBalAmount");
            }
        }
        private decimal     nOpSetAmount;
        public decimal     OpSetAmount
        {
            get { return nOpSetAmount; }
            set
            {
                nOpSetAmount = value;
                OnPropertyChanged("OpSetAmount");
            }
        }
        private decimal     nBalAmount;
        public decimal     BalAmount
        {
            get { return nBalAmount; }
            set
            {
                nBalAmount = value;
                OnPropertyChanged("BalAmount");
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
        private string     sChequeName;
        public string     ChequeName
        {
            get { return sChequeName; }
            set
            {
                sChequeName = value;
                OnPropertyChanged("ChequeName");
            }
        }
        private decimal     nLBT;
        public decimal     LBT
        {
            get { return nLBT; }
            set
            {
                nLBT = value;
                OnPropertyChanged("LBT");
            }
        }
        private string     sLBTNo;
        public string     LBTNo
        {
            get { return sLBTNo; }
            set
            {
                sLBTNo = value;
                OnPropertyChanged("LBTNo");
            }
        }
        private string     sLBTCat;
        public string     LBTCat
        {
            get { return sLBTCat; }
            set
            {
                sLBTCat = value;
                OnPropertyChanged("LBTCat");
            }
        }
        private decimal     nDueDay;
        public decimal     DueDay
        {
            get { return nDueDay; }
            set
            {
                nDueDay = value;
                OnPropertyChanged("DueDay");
            }
        }
        private string     sMailFormat;
        public string     MailFormat
        {
            get { return sMailFormat; }
            set
            {
                sMailFormat = value;
                OnPropertyChanged("MailFormat");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode"))){
                    this.AccountCode = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ICode"))){
                    this.ICode = DBReader.GetString(DBReader.GetOrdinal("ICode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountName"))){
                    this.AccountName = DBReader.GetString(DBReader.GetOrdinal("AccountName"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add4"))){
                    this.Add4 = DBReader.GetString(DBReader.GetOrdinal("Add4"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CityCode"))){
                    this.CityCode = DBReader.GetInt64(DBReader.GetOrdinal("CityCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ContactPerson"))){
                    this.ContactPerson = DBReader.GetString(DBReader.GetOrdinal("ContactPerson"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone1"))){
                    this.Phone1 = DBReader.GetString(DBReader.GetOrdinal("Phone1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Phone2"))){
                    this.Phone2 = DBReader.GetString(DBReader.GetOrdinal("Phone2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Email"))){
                    this.Email = DBReader.GetString(DBReader.GetOrdinal("Email"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DLNo1"))){
                    this.DLNo1 = DBReader.GetString(DBReader.GetOrdinal("DLNo1"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DLNo2"))){
                    this.DLNo2 = DBReader.GetString(DBReader.GetOrdinal("DLNo2"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatTin"))){
                    this.VatTin = DBReader.GetString(DBReader.GetOrdinal("VatTin"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatDate"))){
                    this.VatDate = DBReader.GetDateTime(DBReader.GetOrdinal("VatDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CSTVat"))){
                    this.CSTVat = DBReader.GetString(DBReader.GetOrdinal("CSTVat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CSTVatDate"))){
                    this.CSTVatDate = DBReader.GetDateTime(DBReader.GetOrdinal("CSTVatDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CashDiscount"))){
                    this.CashDiscount = DBReader.GetDecimal(DBReader.GetOrdinal("CashDiscount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillSeries"))){
                    this.BillSeries = DBReader.GetString(DBReader.GetOrdinal("BillSeries"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BillType"))){
                    this.BillType = DBReader.GetString(DBReader.GetOrdinal("BillType"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountType"))){
                    this.AccountType = DBReader.GetString(DBReader.GetOrdinal("AccountType"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("GroupCode"))){
                    this.GroupCode = DBReader.GetInt64(DBReader.GetOrdinal("GroupCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VisitDay"))){
                    this.VisitDay = DBReader.GetString(DBReader.GetOrdinal("VisitDay"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("InfoID"))){
                    this.InfoID = DBReader.GetString(DBReader.GetOrdinal("InfoID"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpBalAmount"))){
                    this.OpBalAmount = DBReader.GetDecimal(DBReader.GetOrdinal("OpBalAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpSetAmount"))){
                    this.OpSetAmount = DBReader.GetDecimal(DBReader.GetOrdinal("OpSetAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BalAmount"))){
                    this.BalAmount = DBReader.GetDecimal(DBReader.GetOrdinal("BalAmount"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DLock"))){
                    this.DLock = DBReader.GetString(DBReader.GetOrdinal("DLock"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ChequeName"))){
                    this.ChequeName = DBReader.GetString(DBReader.GetOrdinal("ChequeName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LBT"))){
                    this.LBT = DBReader.GetDecimal(DBReader.GetOrdinal("LBT"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LBTNo"))){
                    this.LBTNo = DBReader.GetString(DBReader.GetOrdinal("LBTNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LBTCat"))){
                    this.LBTCat = DBReader.GetString(DBReader.GetOrdinal("LBTCat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DueDay"))){
                    this.DueDay = DBReader.GetDecimal(DBReader.GetOrdinal("DueDay"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MailFormat"))){
                    this.MailFormat = DBReader.GetString(DBReader.GetOrdinal("MailFormat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreatedBy"))){
                    this.CreatedBy = DBReader.GetString(DBReader.GetOrdinal("CreatedBy"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreatedDate"))){
                    this.CreatedDate = DBReader.GetDateTime(DBReader.GetOrdinal("CreatedDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT"))){
                    this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
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
            }
        #endregion
  
        public string GetXmlString()
        {  
            StringBuilder sXml = new StringBuilder();  
            sXml.Append("<data>");
            sXml.Append("<AccountCode>" + this.AccountCode + "</AccountCode>");
            sXml.Append("<ICode>" + this.ICode + "</ICode>");
            sXml.Append("<AccountName>" + this.AccountName + "</AccountName>");
            sXml.Append("<Add1>" + this.Add1 + "</Add1>");
            sXml.Append("<Add2>" + this.Add2 + "</Add2>");
            sXml.Append("<Add3>" + this.Add3 + "</Add3>");
            sXml.Append("<Add4>" + this.Add4 + "</Add4>");
            sXml.Append("<CityCode>" + this.CityCode + "</CityCode>");
            sXml.Append("<ContactPerson>" + this.ContactPerson + "</ContactPerson>");
            sXml.Append("<Phone1>" + this.Phone1 + "</Phone1>");
            sXml.Append("<Phone2>" + this.Phone2 + "</Phone2>");
            sXml.Append("<Email>" + this.Email + "</Email>");
            sXml.Append("<DLNo1>" + this.DLNo1 + "</DLNo1>");
            sXml.Append("<DLNo2>" + this.DLNo2 + "</DLNo2>");
            sXml.Append("<VatTin>" + this.VatTin + "</VatTin>");
            sXml.Append("<VatDate>" + this.VatDate + "</VatDate>");
            sXml.Append("<CSTVat>" + this.CSTVat + "</CSTVat>");
            sXml.Append("<CSTVatDate>" + this.CSTVatDate + "</CSTVatDate>");
            sXml.Append("<CashDiscount>" + this.CashDiscount + "</CashDiscount>");
            sXml.Append("<BillSeries>" + this.BillSeries + "</BillSeries>");
            sXml.Append("<BillType>" + this.BillType + "</BillType>");
            sXml.Append("<AccountType>" + this.AccountType + "</AccountType>");
            sXml.Append("<GroupCode>" + this.GroupCode + "</GroupCode>");
            sXml.Append("<VisitDay>" + this.VisitDay + "</VisitDay>");
            sXml.Append("<InfoID>" + this.InfoID + "</InfoID>");
            sXml.Append("<OpBalAmount>" + this.OpBalAmount + "</OpBalAmount>");
            sXml.Append("<OpSetAmount>" + this.OpSetAmount + "</OpSetAmount>");
            sXml.Append("<BalAmount>" + this.BalAmount + "</BalAmount>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
            sXml.Append("<LCode>" + this.LCode + "</LCode>");
            sXml.Append("<DLock>" + this.DLock + "</DLock>");
            sXml.Append("<ChequeName>" + this.ChequeName + "</ChequeName>");
            sXml.Append("<LBT>" + this.LBT + "</LBT>");
            sXml.Append("<LBTNo>" + this.LBTNo + "</LBTNo>");
            sXml.Append("<LBTCat>" + this.LBTCat + "</LBTCat>");
            sXml.Append("<DueDay>" + this.DueDay + "</DueDay>");
            sXml.Append("<MailFormat>" + this.MailFormat + "</MailFormat>");
            sXml.Append("<CreatedBy>" + this.CreatedBy + "</CreatedBy>");
            sXml.Append("<CreatedDate>" + this.CreatedDate + "</CreatedDate>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("<UpdateddBy>" + this.UpdateddBy + "</UpdateddBy>");
            sXml.Append("<UpdatedDate>" + this.UpdatedDate + "</UpdatedDate>");
            sXml.Append("<UpdatedCount>" + this.UpdatedCount + "</UpdatedCount>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            AccountMaster objdata = obj as AccountMaster;
            this.AccountCode = objdata.AccountCode;
            this.ICode = objdata.ICode;
            this.AccountName = objdata.AccountName;
            this.Add1 = objdata.Add1;
            this.Add2 = objdata.Add2;
            this.Add3 = objdata.Add3;
            this.Add4 = objdata.Add4;
            this.CityCode = objdata.CityCode;
            this.ContactPerson = objdata.ContactPerson;
            this.Phone1 = objdata.Phone1;
            this.Phone2 = objdata.Phone2;
            this.Email = objdata.Email;
            this.DLNo1 = objdata.DLNo1;
            this.DLNo2 = objdata.DLNo2;
            this.VatTin = objdata.VatTin;
            this.VatDate = objdata.VatDate;
            this.CSTVat = objdata.CSTVat;
            this.CSTVatDate = objdata.CSTVatDate;
            this.CashDiscount = objdata.CashDiscount;
            this.BillSeries = objdata.BillSeries;
            this.BillType = objdata.BillType;
            this.AccountType = objdata.AccountType;
            this.GroupCode = objdata.GroupCode;
            this.VisitDay = objdata.VisitDay;
            this.InfoID = objdata.InfoID;
            this.OpBalAmount = objdata.OpBalAmount;
            this.OpSetAmount = objdata.OpSetAmount;
            this.BalAmount = objdata.BalAmount;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
            this.LCode = objdata.LCode;
            this.DLock = objdata.DLock;
            this.ChequeName = objdata.ChequeName;
            this.LBT = objdata.LBT;
            this.LBTNo = objdata.LBTNo;
            this.LBTCat = objdata.LBTCat;
            this.DueDay = objdata.DueDay;
            this.MailFormat = objdata.MailFormat;
            this.CreatedBy = objdata.CreatedBy;
            this.CreatedDate = objdata.CreatedDate;
            this.LUT = objdata.LUT;
            this.UpdateddBy = objdata.UpdateddBy;
            this.UpdatedDate = objdata.UpdatedDate;
            this.UpdatedCount = objdata.UpdatedCount;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            AccountMaster objdata = obj as AccountMaster;
            objdata.AccountCode = this.AccountCode;
            objdata.ICode = this.ICode;
            objdata.AccountName = this.AccountName;
            objdata.Add1 = this.Add1;
            objdata.Add2 = this.Add2;
            objdata.Add3 = this.Add3;
            objdata.Add4 = this.Add4;
            objdata.CityCode = this.CityCode;
            objdata.ContactPerson = this.ContactPerson;
            objdata.Phone1 = this.Phone1;
            objdata.Phone2 = this.Phone2;
            objdata.Email = this.Email;
            objdata.DLNo1 = this.DLNo1;
            objdata.DLNo2 = this.DLNo2;
            objdata.VatTin = this.VatTin;
            objdata.VatDate = this.VatDate;
            objdata.CSTVat = this.CSTVat;
            objdata.CSTVatDate = this.CSTVatDate;
            objdata.CashDiscount = this.CashDiscount;
            objdata.BillSeries = this.BillSeries;
            objdata.BillType = this.BillType;
            objdata.AccountType = this.AccountType;
            objdata.GroupCode = this.GroupCode;
            objdata.VisitDay = this.VisitDay;
            objdata.InfoID = this.InfoID;
            objdata.OpBalAmount = this.OpBalAmount;
            objdata.OpSetAmount = this.OpSetAmount;
            objdata.BalAmount = this.BalAmount;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
            objdata.LCode = this.LCode;
            objdata.DLock = this.DLock;
            objdata.ChequeName = this.ChequeName;
            objdata.LBT = this.LBT;
            objdata.LBTNo = this.LBTNo;
            objdata.LBTCat = this.LBTCat;
            objdata.DueDay = this.DueDay;
            objdata.MailFormat = this.MailFormat;
            objdata.CreatedBy = this.CreatedBy;
            objdata.CreatedDate = this.CreatedDate;
            objdata.LUT = this.LUT;
            objdata.UpdateddBy = this.UpdateddBy;
            objdata.UpdatedDate = this.UpdatedDate;
            objdata.UpdatedCount = this.UpdatedCount;
            return obj; 
        }  

        public void ResetData()
        {  
            this.AccountCode = 0;
            this.ICode = string.Empty;;
            this.AccountName = string.Empty;;
            this.Add1 = string.Empty;;
            this.Add2 = string.Empty;;
            this.Add3 = string.Empty;;
            this.Add4 = string.Empty;;
            this.CityCode = 0;
            this.ContactPerson = string.Empty;;
            this.Phone1 = string.Empty;;
            this.Phone2 = string.Empty;;
            this.Email = string.Empty;;
            this.DLNo1 = string.Empty;;
            this.DLNo2 = string.Empty;;
            this.VatTin = string.Empty;;
            this.VatDate = new DateTime();
            this.CSTVat = string.Empty;;
            this.CSTVatDate = new DateTime();
            this.CashDiscount = 0;
            this.BillSeries = string.Empty;;
            this.BillType = string.Empty;;
            this.AccountType = string.Empty;;
            this.GroupCode = 0;
            this.VisitDay = string.Empty;;
            this.InfoID = string.Empty;;
            this.OpBalAmount = 0;
            this.OpSetAmount = 0;
            this.BalAmount = 0;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.LCode = 0;
            this.DLock = string.Empty;;
            this.ChequeName = string.Empty;;
            this.LBT = 0;
            this.LBTNo = string.Empty;;
            this.LBTCat = string.Empty;;
            this.DueDay = 0;
            this.MailFormat = string.Empty;;
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.LUT = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
        }  

    }  
}
