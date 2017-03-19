 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class OBillMaster : IModel,INotifyPropertyChanged
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
        private string     sPurBillNo;
        public string     PurBillNo
        {
            get { return sPurBillNo; }
            set
            {
                sPurBillNo = value;
                OnPropertyChanged("PurBillNo");
            }
        }
        private DateTime     dtPurBillDate;
        public DateTime     PurBillDate
        {
            get { return dtPurBillDate; }
            set
            {
                dtPurBillDate = value;
                OnPropertyChanged("PurBillDate");
            }
        }
        private long     nCustomerCode;
        public long     CustomerCode
        {
            get { return nCustomerCode; }
            set
            {
                nCustomerCode = value;
                OnPropertyChanged("CustomerCode");
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
        private long     nSalesmanCode;
        public long     SalesmanCode
        {
            get { return nSalesmanCode; }
            set
            {
                nSalesmanCode = value;
                OnPropertyChanged("SalesmanCode");
            }
        }
        private string     sVatInRate;
        public string     VatInRate
        {
            get { return sVatInRate; }
            set
            {
                sVatInRate = value;
                OnPropertyChanged("VatInRate");
            }
        }
        private decimal     nGrossAmount;
        public decimal     GrossAmount
        {
            get { return nGrossAmount; }
            set
            {
                nGrossAmount = value;
                OnPropertyChanged("GrossAmount");
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
        private decimal     nDiscPer;
        public decimal     DiscPer
        {
            get { return nDiscPer; }
            set
            {
                nDiscPer = value;
                OnPropertyChanged("DiscPer");
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
        private decimal     nVatPer;
        public decimal     VatPer
        {
            get { return nVatPer; }
            set
            {
                nVatPer = value;
                OnPropertyChanged("VatPer");
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
        private decimal     nAdVatPer;
        public decimal     AdVatPer
        {
            get { return nAdVatPer; }
            set
            {
                nAdVatPer = value;
                OnPropertyChanged("AdVatPer");
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
        private decimal     nCrRs;
        public decimal     CrRs
        {
            get { return nCrRs; }
            set
            {
                nCrRs = value;
                OnPropertyChanged("CrRs");
            }
        }
        private decimal     nOtherAdj;
        public decimal     OtherAdj
        {
            get { return nOtherAdj; }
            set
            {
                nOtherAdj = value;
                OnPropertyChanged("OtherAdj");
            }
        }
        private decimal     nRndOff;
        public decimal     RndOff
        {
            get { return nRndOff; }
            set
            {
                nRndOff = value;
                OnPropertyChanged("RndOff");
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
        private string     sRateTag;
        public string     RateTag
        {
            get { return sRateTag; }
            set
            {
                sRateTag = value;
                OnPropertyChanged("RateTag");
            }
        }
        private string     sOrdRef;
        public string     OrdRef
        {
            get { return sOrdRef; }
            set
            {
                sOrdRef = value;
                OnPropertyChanged("OrdRef");
            }
        }
        private string     sModOfDespatch;
        public string     ModOfDespatch
        {
            get { return sModOfDespatch; }
            set
            {
                sModOfDespatch = value;
                OnPropertyChanged("ModOfDespatch");
            }
        }
        private string     sRRNo;
        public string     RRNo
        {
            get { return sRRNo; }
            set
            {
                sRRNo = value;
                OnPropertyChanged("RRNo");
            }
        }
        private string     sNoOfPack;
        public string     NoOfPack
        {
            get { return sNoOfPack; }
            set
            {
                sNoOfPack = value;
                OnPropertyChanged("NoOfPack");
            }
        }
        private DateTime     dtDespDate;
        public DateTime     DespDate
        {
            get { return dtDespDate; }
            set
            {
                dtDespDate = value;
                OnPropertyChanged("DespDate");
            }
        }
        private string     sSplInst;
        public string     SplInst
        {
            get { return sSplInst; }
            set
            {
                sSplInst = value;
                OnPropertyChanged("SplInst");
            }
        }
        private decimal     nRcptAmount;
        public decimal     RcptAmount
        {
            get { return nRcptAmount; }
            set
            {
                nRcptAmount = value;
                OnPropertyChanged("RcptAmount");
            }
        }
        private decimal     nMiscPndAmount;
        public decimal     MiscPndAmount
        {
            get { return nMiscPndAmount; }
            set
            {
                nMiscPndAmount = value;
                OnPropertyChanged("MiscPndAmount");
            }
        }
        private string     sAdjTag;
        public string     AdjTag
        {
            get { return sAdjTag; }
            set
            {
                sAdjTag = value;
                OnPropertyChanged("AdjTag");
            }
        }
        private long     nVarifyBy;
        public long     VarifyBy
        {
            get { return nVarifyBy; }
            set
            {
                nVarifyBy = value;
                OnPropertyChanged("VarifyBy");
            }
        }
        private DateTime     dtVarifyDate;
        public DateTime     VarifyDate
        {
            get { return dtVarifyDate; }
            set
            {
                dtVarifyDate = value;
                OnPropertyChanged("VarifyDate");
            }
        }
        private string     sNodeName;
        public string     NodeName
        {
            get { return sNodeName; }
            set
            {
                sNodeName = value;
                OnPropertyChanged("NodeName");
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
        private DateTime     dtDueDate;
        public DateTime     DueDate
        {
            get { return dtDueDate; }
            set
            {
                dtDueDate = value;
                OnPropertyChanged("DueDate");
            }
        }
        private long     nDelBoyName;
        public long     DelBoyName
        {
            get { return nDelBoyName; }
            set
            {
                nDelBoyName = value;
                OnPropertyChanged("DelBoyName");
            }
        }
        private string     sNarration;
        public string     Narration
        {
            get { return sNarration; }
            set
            {
                sNarration = value;
                OnPropertyChanged("Narration");
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
        private decimal     nLBTRs;
        public decimal     LBTRs
        {
            get { return nLBTRs; }
            set
            {
                nLBTRs = value;
                OnPropertyChanged("LBTRs");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurBillNo"))){
                    this.PurBillNo = DBReader.GetString(DBReader.GetOrdinal("PurBillNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PurBillDate"))){
                    this.PurBillDate = DBReader.GetDateTime(DBReader.GetOrdinal("PurBillDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CustomerCode"))){
                    this.CustomerCode = DBReader.GetInt64(DBReader.GetOrdinal("CustomerCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DoctorCode"))){
                    this.DoctorCode = DBReader.GetInt64(DBReader.GetOrdinal("DoctorCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode"))){
                    this.AccountCode = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SalesmanCode"))){
                    this.SalesmanCode = DBReader.GetInt64(DBReader.GetOrdinal("SalesmanCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatInRate"))){
                    this.VatInRate = DBReader.GetString(DBReader.GetOrdinal("VatInRate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("GrossAmount"))){
                    this.GrossAmount = DBReader.GetDecimal(DBReader.GetOrdinal("GrossAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SchemeRs"))){
                    this.SchemeRs = DBReader.GetDecimal(DBReader.GetOrdinal("SchemeRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SplDiscRs"))){
                    this.SplDiscRs = DBReader.GetDecimal(DBReader.GetOrdinal("SplDiscRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DiscPer"))){
                    this.DiscPer = DBReader.GetDecimal(DBReader.GetOrdinal("DiscPer"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DiscRs"))){
                    this.DiscRs = DBReader.GetDecimal(DBReader.GetOrdinal("DiscRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatPer"))){
                    this.VatPer = DBReader.GetDecimal(DBReader.GetOrdinal("VatPer"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VatRs"))){
                    this.VatRs = DBReader.GetDecimal(DBReader.GetOrdinal("VatRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AdVatPer"))){
                    this.AdVatPer = DBReader.GetDecimal(DBReader.GetOrdinal("AdVatPer"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AdVatRs"))){
                    this.AdVatRs = DBReader.GetDecimal(DBReader.GetOrdinal("AdVatRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CrRs"))){
                    this.CrRs = DBReader.GetDecimal(DBReader.GetOrdinal("CrRs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OtherAdj"))){
                    this.OtherAdj = DBReader.GetDecimal(DBReader.GetOrdinal("OtherAdj"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RndOff"))){
                    this.RndOff = DBReader.GetDecimal(DBReader.GetOrdinal("RndOff"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NetAmount"))){
                    this.NetAmount = DBReader.GetDecimal(DBReader.GetOrdinal("NetAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RateTag"))){
                    this.RateTag = DBReader.GetString(DBReader.GetOrdinal("RateTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OrdRef"))){
                    this.OrdRef = DBReader.GetString(DBReader.GetOrdinal("OrdRef"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ModOfDespatch"))){
                    this.ModOfDespatch = DBReader.GetString(DBReader.GetOrdinal("ModOfDespatch"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RRNo"))){
                    this.RRNo = DBReader.GetString(DBReader.GetOrdinal("RRNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NoOfPack"))){
                    this.NoOfPack = DBReader.GetString(DBReader.GetOrdinal("NoOfPack"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DespDate"))){
                    this.DespDate = DBReader.GetDateTime(DBReader.GetOrdinal("DespDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SplInst"))){
                    this.SplInst = DBReader.GetString(DBReader.GetOrdinal("SplInst"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RcptAmount"))){
                    this.RcptAmount = DBReader.GetDecimal(DBReader.GetOrdinal("RcptAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MiscPndAmount"))){
                    this.MiscPndAmount = DBReader.GetDecimal(DBReader.GetOrdinal("MiscPndAmount"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AdjTag"))){
                    this.AdjTag = DBReader.GetString(DBReader.GetOrdinal("AdjTag"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VarifyBy"))){
                    this.VarifyBy = DBReader.GetInt64(DBReader.GetOrdinal("VarifyBy"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VarifyDate"))){
                    this.VarifyDate = DBReader.GetDateTime(DBReader.GetOrdinal("VarifyDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NodeName"))){
                    this.NodeName = DBReader.GetString(DBReader.GetOrdinal("NodeName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ShiftNo"))){
                    this.ShiftNo = DBReader.GetInt64(DBReader.GetOrdinal("ShiftNo"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DueDate"))){
                    this.DueDate = DBReader.GetDateTime(DBReader.GetOrdinal("DueDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DelBoyName"))){
                    this.DelBoyName = DBReader.GetInt64(DBReader.GetOrdinal("DelBoyName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Narration"))){
                    this.Narration = DBReader.GetString(DBReader.GetOrdinal("Narration"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LBT"))){
                    this.LBT = DBReader.GetDecimal(DBReader.GetOrdinal("LBT"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LBTRs"))){
                    this.LBTRs = DBReader.GetDecimal(DBReader.GetOrdinal("LBTRs"));
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
            sXml.Append("<PurBillNo>" + this.PurBillNo + "</PurBillNo>");
            sXml.Append("<PurBillDate>" + this.PurBillDate + "</PurBillDate>");
            sXml.Append("<CustomerCode>" + this.CustomerCode + "</CustomerCode>");
            sXml.Append("<DoctorCode>" + this.DoctorCode + "</DoctorCode>");
            sXml.Append("<AccountCode>" + this.AccountCode + "</AccountCode>");
            sXml.Append("<SalesmanCode>" + this.SalesmanCode + "</SalesmanCode>");
            sXml.Append("<VatInRate>" + this.VatInRate + "</VatInRate>");
            sXml.Append("<GrossAmount>" + this.GrossAmount + "</GrossAmount>");
            sXml.Append("<SchemeRs>" + this.SchemeRs + "</SchemeRs>");
            sXml.Append("<SplDiscRs>" + this.SplDiscRs + "</SplDiscRs>");
            sXml.Append("<DiscPer>" + this.DiscPer + "</DiscPer>");
            sXml.Append("<DiscRs>" + this.DiscRs + "</DiscRs>");
            sXml.Append("<VatPer>" + this.VatPer + "</VatPer>");
            sXml.Append("<VatRs>" + this.VatRs + "</VatRs>");
            sXml.Append("<AdVatPer>" + this.AdVatPer + "</AdVatPer>");
            sXml.Append("<AdVatRs>" + this.AdVatRs + "</AdVatRs>");
            sXml.Append("<CrRs>" + this.CrRs + "</CrRs>");
            sXml.Append("<OtherAdj>" + this.OtherAdj + "</OtherAdj>");
            sXml.Append("<RndOff>" + this.RndOff + "</RndOff>");
            sXml.Append("<NetAmount>" + this.NetAmount + "</NetAmount>");
            sXml.Append("<RateTag>" + this.RateTag + "</RateTag>");
            sXml.Append("<OrdRef>" + this.OrdRef + "</OrdRef>");
            sXml.Append("<ModOfDespatch>" + this.ModOfDespatch + "</ModOfDespatch>");
            sXml.Append("<RRNo>" + this.RRNo + "</RRNo>");
            sXml.Append("<NoOfPack>" + this.NoOfPack + "</NoOfPack>");
            sXml.Append("<DespDate>" + this.DespDate + "</DespDate>");
            sXml.Append("<SplInst>" + this.SplInst + "</SplInst>");
            sXml.Append("<RcptAmount>" + this.RcptAmount + "</RcptAmount>");
            sXml.Append("<MiscPndAmount>" + this.MiscPndAmount + "</MiscPndAmount>");
            sXml.Append("<AdjTag>" + this.AdjTag + "</AdjTag>");
            sXml.Append("<VarifyBy>" + this.VarifyBy + "</VarifyBy>");
            sXml.Append("<VarifyDate>" + this.VarifyDate + "</VarifyDate>");
            sXml.Append("<NodeName>" + this.NodeName + "</NodeName>");
            sXml.Append("<ShiftNo>" + this.ShiftNo + "</ShiftNo>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
            sXml.Append("<DueDate>" + this.DueDate + "</DueDate>");
            sXml.Append("<DelBoyName>" + this.DelBoyName + "</DelBoyName>");
            sXml.Append("<Narration>" + this.Narration + "</Narration>");
            sXml.Append("<LBT>" + this.LBT + "</LBT>");
            sXml.Append("<LBTRs>" + this.LBTRs + "</LBTRs>");
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
            OBillMaster objdata = obj as OBillMaster;
            this.RecNo = objdata.RecNo;
            this.BillTag = objdata.BillTag;
            this.BillType = objdata.BillType;
            this.BillCredit = objdata.BillCredit;
            this.BillSeries = objdata.BillSeries;
            this.BillNo = objdata.BillNo;
            this.BillDate = objdata.BillDate;
            this.PurBillNo = objdata.PurBillNo;
            this.PurBillDate = objdata.PurBillDate;
            this.CustomerCode = objdata.CustomerCode;
            this.DoctorCode = objdata.DoctorCode;
            this.AccountCode = objdata.AccountCode;
            this.SalesmanCode = objdata.SalesmanCode;
            this.VatInRate = objdata.VatInRate;
            this.GrossAmount = objdata.GrossAmount;
            this.SchemeRs = objdata.SchemeRs;
            this.SplDiscRs = objdata.SplDiscRs;
            this.DiscPer = objdata.DiscPer;
            this.DiscRs = objdata.DiscRs;
            this.VatPer = objdata.VatPer;
            this.VatRs = objdata.VatRs;
            this.AdVatPer = objdata.AdVatPer;
            this.AdVatRs = objdata.AdVatRs;
            this.CrRs = objdata.CrRs;
            this.OtherAdj = objdata.OtherAdj;
            this.RndOff = objdata.RndOff;
            this.NetAmount = objdata.NetAmount;
            this.RateTag = objdata.RateTag;
            this.OrdRef = objdata.OrdRef;
            this.ModOfDespatch = objdata.ModOfDespatch;
            this.RRNo = objdata.RRNo;
            this.NoOfPack = objdata.NoOfPack;
            this.DespDate = objdata.DespDate;
            this.SplInst = objdata.SplInst;
            this.RcptAmount = objdata.RcptAmount;
            this.MiscPndAmount = objdata.MiscPndAmount;
            this.AdjTag = objdata.AdjTag;
            this.VarifyBy = objdata.VarifyBy;
            this.VarifyDate = objdata.VarifyDate;
            this.NodeName = objdata.NodeName;
            this.ShiftNo = objdata.ShiftNo;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
            this.DueDate = objdata.DueDate;
            this.DelBoyName = objdata.DelBoyName;
            this.Narration = objdata.Narration;
            this.LBT = objdata.LBT;
            this.LBTRs = objdata.LBTRs;
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
            OBillMaster objdata = obj as OBillMaster;
            objdata.RecNo = this.RecNo;
            objdata.BillTag = this.BillTag;
            objdata.BillType = this.BillType;
            objdata.BillCredit = this.BillCredit;
            objdata.BillSeries = this.BillSeries;
            objdata.BillNo = this.BillNo;
            objdata.BillDate = this.BillDate;
            objdata.PurBillNo = this.PurBillNo;
            objdata.PurBillDate = this.PurBillDate;
            objdata.CustomerCode = this.CustomerCode;
            objdata.DoctorCode = this.DoctorCode;
            objdata.AccountCode = this.AccountCode;
            objdata.SalesmanCode = this.SalesmanCode;
            objdata.VatInRate = this.VatInRate;
            objdata.GrossAmount = this.GrossAmount;
            objdata.SchemeRs = this.SchemeRs;
            objdata.SplDiscRs = this.SplDiscRs;
            objdata.DiscPer = this.DiscPer;
            objdata.DiscRs = this.DiscRs;
            objdata.VatPer = this.VatPer;
            objdata.VatRs = this.VatRs;
            objdata.AdVatPer = this.AdVatPer;
            objdata.AdVatRs = this.AdVatRs;
            objdata.CrRs = this.CrRs;
            objdata.OtherAdj = this.OtherAdj;
            objdata.RndOff = this.RndOff;
            objdata.NetAmount = this.NetAmount;
            objdata.RateTag = this.RateTag;
            objdata.OrdRef = this.OrdRef;
            objdata.ModOfDespatch = this.ModOfDespatch;
            objdata.RRNo = this.RRNo;
            objdata.NoOfPack = this.NoOfPack;
            objdata.DespDate = this.DespDate;
            objdata.SplInst = this.SplInst;
            objdata.RcptAmount = this.RcptAmount;
            objdata.MiscPndAmount = this.MiscPndAmount;
            objdata.AdjTag = this.AdjTag;
            objdata.VarifyBy = this.VarifyBy;
            objdata.VarifyDate = this.VarifyDate;
            objdata.NodeName = this.NodeName;
            objdata.ShiftNo = this.ShiftNo;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
            objdata.DueDate = this.DueDate;
            objdata.DelBoyName = this.DelBoyName;
            objdata.Narration = this.Narration;
            objdata.LBT = this.LBT;
            objdata.LBTRs = this.LBTRs;
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
            this.PurBillNo = string.Empty;;
            this.PurBillDate = new DateTime();
            this.CustomerCode = 0;
            this.DoctorCode = 0;
            this.AccountCode = 0;
            this.SalesmanCode = 0;
            this.VatInRate = string.Empty;;
            this.GrossAmount = 0;
            this.SchemeRs = 0;
            this.SplDiscRs = 0;
            this.DiscPer = 0;
            this.DiscRs = 0;
            this.VatPer = 0;
            this.VatRs = 0;
            this.AdVatPer = 0;
            this.AdVatRs = 0;
            this.CrRs = 0;
            this.OtherAdj = 0;
            this.RndOff = 0;
            this.NetAmount = 0;
            this.RateTag = string.Empty;;
            this.OrdRef = string.Empty;;
            this.ModOfDespatch = string.Empty;;
            this.RRNo = string.Empty;;
            this.NoOfPack = string.Empty;;
            this.DespDate = new DateTime();
            this.SplInst = string.Empty;;
            this.RcptAmount = 0;
            this.MiscPndAmount = 0;
            this.AdjTag = string.Empty;;
            this.VarifyBy = 0;
            this.VarifyDate = new DateTime();
            this.NodeName = string.Empty;;
            this.ShiftNo = 0;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.DueDate = new DateTime();
            this.DelBoyName = 0;
            this.Narration = string.Empty;;
            this.LBT = 0;
            this.LBTRs = 0;
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
