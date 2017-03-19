 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class ShiftMaster : IModel,INotifyPropertyChanged
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
        private string     sShiftName;
        public string     ShiftName
        {
            get { return sShiftName; }
            set
            {
                sShiftName = value;
                OnPropertyChanged("ShiftName");
            }
        }
        private long     nShiftNo;
        public long     ShiftNo
        {
            get { return nShiftNo; }
            set
            {
                nShiftNo = value;
                OnPropertyChanged("ShiftNo");
            }
        }
        private DateTime     dtShiftDate;
        public DateTime     ShiftDate
        {
            get { return dtShiftDate; }
            set
            {
                dtShiftDate = value;
                OnPropertyChanged("ShiftDate");
            }
        }
        private decimal     nOpCash;
        public decimal     OpCash
        {
            get { return nOpCash; }
            set
            {
                nOpCash = value;
                OnPropertyChanged("OpCash");
            }
        }
        private decimal     nCashReceipt;
        public decimal     CashReceipt
        {
            get { return nCashReceipt; }
            set
            {
                nCashReceipt = value;
                OnPropertyChanged("CashReceipt");
            }
        }
        private decimal     nReceiptVoucher;
        public decimal     ReceiptVoucher
        {
            get { return nReceiptVoucher; }
            set
            {
                nReceiptVoucher = value;
                OnPropertyChanged("ReceiptVoucher");
            }
        }
        private decimal     nCashReturn;
        public decimal     CashReturn
        {
            get { return nCashReturn; }
            set
            {
                nCashReturn = value;
                OnPropertyChanged("CashReturn");
            }
        }
        private decimal     nCashPayment;
        public decimal     CashPayment
        {
            get { return nCashPayment; }
            set
            {
                nCashPayment = value;
                OnPropertyChanged("CashPayment");
            }
        }
        private decimal     nPaymentVoucher;
        public decimal     PaymentVoucher
        {
            get { return nPaymentVoucher; }
            set
            {
                nPaymentVoucher = value;
                OnPropertyChanged("PaymentVoucher");
            }
        }
        private decimal     nExtraAmount;
        public decimal     ExtraAmount
        {
            get { return nExtraAmount; }
            set
            {
                nExtraAmount = value;
                OnPropertyChanged("ExtraAmount");
            }
        }
        private decimal     nAmount;
        public decimal     Amount
        {
            get { return nAmount; }
            set
            {
                nAmount = value;
                OnPropertyChanged("Amount");
            }
        }
        private string     sShiftMess;
        public string     ShiftMess
        {
            get { return sShiftMess; }
            set
            {
                sShiftMess = value;
                OnPropertyChanged("ShiftMess");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ShiftName"))){
                    this.ShiftName = DBReader.GetString(DBReader.GetOrdinal("ShiftName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ShiftNo"))){
                    this.ShiftNo = DBReader.GetInt64(DBReader.GetOrdinal("ShiftNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ShiftDate"))){
                    this.ShiftDate = DBReader.GetDateTime(DBReader.GetOrdinal("ShiftDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpCash"))){
                    this.OpCash = DBReader.GetDecimal(DBReader.GetOrdinal("OpCash"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CashReceipt"))){
                    this.CashReceipt = DBReader.GetDecimal(DBReader.GetOrdinal("CashReceipt"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ReceiptVoucher"))){
                    this.ReceiptVoucher = DBReader.GetDecimal(DBReader.GetOrdinal("ReceiptVoucher"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CashReturn"))){
                    this.CashReturn = DBReader.GetDecimal(DBReader.GetOrdinal("CashReturn"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CashPayment"))){
                    this.CashPayment = DBReader.GetDecimal(DBReader.GetOrdinal("CashPayment"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PaymentVoucher"))){
                    this.PaymentVoucher = DBReader.GetDecimal(DBReader.GetOrdinal("PaymentVoucher"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ExtraAmount"))){
                    this.ExtraAmount = DBReader.GetDecimal(DBReader.GetOrdinal("ExtraAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Amount"))){
                    this.Amount = DBReader.GetDecimal(DBReader.GetOrdinal("Amount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ShiftMess"))){
                    this.ShiftMess = DBReader.GetString(DBReader.GetOrdinal("ShiftMess"));
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
            sXml.Append("<ShiftName>" + this.ShiftName + "</ShiftName>");
            sXml.Append("<ShiftNo>" + this.ShiftNo + "</ShiftNo>");
            sXml.Append("<ShiftDate>" + this.ShiftDate + "</ShiftDate>");
            sXml.Append("<OpCash>" + this.OpCash + "</OpCash>");
            sXml.Append("<CashReceipt>" + this.CashReceipt + "</CashReceipt>");
            sXml.Append("<ReceiptVoucher>" + this.ReceiptVoucher + "</ReceiptVoucher>");
            sXml.Append("<CashReturn>" + this.CashReturn + "</CashReturn>");
            sXml.Append("<CashPayment>" + this.CashPayment + "</CashPayment>");
            sXml.Append("<PaymentVoucher>" + this.PaymentVoucher + "</PaymentVoucher>");
            sXml.Append("<ExtraAmount>" + this.ExtraAmount + "</ExtraAmount>");
            sXml.Append("<Amount>" + this.Amount + "</Amount>");
            sXml.Append("<ShiftMess>" + this.ShiftMess + "</ShiftMess>");
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
            ShiftMaster objdata = obj as ShiftMaster;
            this.RecNo = objdata.RecNo;
            this.ShiftName = objdata.ShiftName;
            this.ShiftNo = objdata.ShiftNo;
            this.ShiftDate = objdata.ShiftDate;
            this.OpCash = objdata.OpCash;
            this.CashReceipt = objdata.CashReceipt;
            this.ReceiptVoucher = objdata.ReceiptVoucher;
            this.CashReturn = objdata.CashReturn;
            this.CashPayment = objdata.CashPayment;
            this.PaymentVoucher = objdata.PaymentVoucher;
            this.ExtraAmount = objdata.ExtraAmount;
            this.Amount = objdata.Amount;
            this.ShiftMess = objdata.ShiftMess;
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
            ShiftMaster objdata = obj as ShiftMaster;
            objdata.RecNo = this.RecNo;
            objdata.ShiftName = this.ShiftName;
            objdata.ShiftNo = this.ShiftNo;
            objdata.ShiftDate = this.ShiftDate;
            objdata.OpCash = this.OpCash;
            objdata.CashReceipt = this.CashReceipt;
            objdata.ReceiptVoucher = this.ReceiptVoucher;
            objdata.CashReturn = this.CashReturn;
            objdata.CashPayment = this.CashPayment;
            objdata.PaymentVoucher = this.PaymentVoucher;
            objdata.ExtraAmount = this.ExtraAmount;
            objdata.Amount = this.Amount;
            objdata.ShiftMess = this.ShiftMess;
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
            this.ShiftName = string.Empty;;
            this.ShiftNo = 0;
            this.ShiftDate = new DateTime();
            this.OpCash = 0;
            this.CashReceipt = 0;
            this.ReceiptVoucher = 0;
            this.CashReturn = 0;
            this.CashPayment = 0;
            this.PaymentVoucher = 0;
            this.ExtraAmount = 0;
            this.Amount = 0;
            this.ShiftMess = string.Empty;;
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
