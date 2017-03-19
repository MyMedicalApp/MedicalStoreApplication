 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class PrintFormat : IModel,INotifyPropertyChanged
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
        private string     sLabelType;
        public string     LabelType
        {
            get { return sLabelType; }
            set
            {
                sLabelType = value;
                OnPropertyChanged("LabelType");
            }
        }
        private string     sOprtSys;
        public string     OprtSys
        {
            get { return sOprtSys; }
            set
            {
                sOprtSys = value;
                OnPropertyChanged("OprtSys");
            }
        }
        private string     sFormatName;
        public string     FormatName
        {
            get { return sFormatName; }
            set
            {
                sFormatName = value;
                OnPropertyChanged("FormatName");
            }
        }
        private string     sPrinterName;
        public string     PrinterName
        {
            get { return sPrinterName; }
            set
            {
                sPrinterName = value;
                OnPropertyChanged("PrinterName");
            }
        }
        private string     sTxtType;
        public string     TxtType
        {
            get { return sTxtType; }
            set
            {
                sTxtType = value;
                OnPropertyChanged("TxtType");
            }
        }
        private string     sSampleTxt;
        public string     SampleTxt
        {
            get { return sSampleTxt; }
            set
            {
                sSampleTxt = value;
                OnPropertyChanged("SampleTxt");
            }
        }
        private string     sFPrefix;
        public string     FPrefix
        {
            get { return sFPrefix; }
            set
            {
                sFPrefix = value;
                OnPropertyChanged("FPrefix");
            }
        }
        private string     sFldName;
        public string     FldName
        {
            get { return sFldName; }
            set
            {
                sFldName = value;
                OnPropertyChanged("FldName");
            }
        }
        private string     sFSufix;
        public string     FSufix
        {
            get { return sFSufix; }
            set
            {
                sFSufix = value;
                OnPropertyChanged("FSufix");
            }
        }
        private string     sPrntFormat;
        public string     PrntFormat
        {
            get { return sPrntFormat; }
            set
            {
                sPrntFormat = value;
                OnPropertyChanged("PrntFormat");
            }
        }
        private long     nPosX;
        public long     PosX
        {
            get { return nPosX; }
            set
            {
                nPosX = value;
                OnPropertyChanged("PosX");
            }
        }
        private long     nPosY;
        public long     PosY
        {
            get { return nPosY; }
            set
            {
                nPosY = value;
                OnPropertyChanged("PosY");
            }
        }
        private long     nPWidth;
        public long     PWidth
        {
            get { return nPWidth; }
            set
            {
                nPWidth = value;
                OnPropertyChanged("PWidth");
            }
        }
        private long     nPHeight;
        public long     PHeight
        {
            get { return nPHeight; }
            set
            {
                nPHeight = value;
                OnPropertyChanged("PHeight");
            }
        }
        private string     sFntName;
        public string     FntName
        {
            get { return sFntName; }
            set
            {
                sFntName = value;
                OnPropertyChanged("FntName");
            }
        }
        private string     sFntStyle;
        public string     FntStyle
        {
            get { return sFntStyle; }
            set
            {
                sFntStyle = value;
                OnPropertyChanged("FntStyle");
            }
        }
        private string     sFntBold;
        public string     FntBold
        {
            get { return sFntBold; }
            set
            {
                sFntBold = value;
                OnPropertyChanged("FntBold");
            }
        }
        private string     sFntItalic;
        public string     FntItalic
        {
            get { return sFntItalic; }
            set
            {
                sFntItalic = value;
                OnPropertyChanged("FntItalic");
            }
        }
        private string     sFntStrikout;
        public string     FntStrikout
        {
            get { return sFntStrikout; }
            set
            {
                sFntStrikout = value;
                OnPropertyChanged("FntStrikout");
            }
        }
        private string     sFntUnderLine;
        public string     FntUnderLine
        {
            get { return sFntUnderLine; }
            set
            {
                sFntUnderLine = value;
                OnPropertyChanged("FntUnderLine");
            }
        }
        private long     nFntSize;
        public long     FntSize
        {
            get { return nFntSize; }
            set
            {
                nFntSize = value;
                OnPropertyChanged("FntSize");
            }
        }
        private long     nFntColor;
        public long     FntColor
        {
            get { return nFntColor; }
            set
            {
                nFntColor = value;
                OnPropertyChanged("FntColor");
            }
        }
        private long     nAcrossLbl;
        public long     AcrossLbl
        {
            get { return nAcrossLbl; }
            set
            {
                nAcrossLbl = value;
                OnPropertyChanged("AcrossLbl");
            }
        }
        private long     nPgLbl;
        public long     PgLbl
        {
            get { return nPgLbl; }
            set
            {
                nPgLbl = value;
                OnPropertyChanged("PgLbl");
            }
        }
        private string     sDuplicateLbl;
        public string     DuplicateLbl
        {
            get { return sDuplicateLbl; }
            set
            {
                sDuplicateLbl = value;
                OnPropertyChanged("DuplicateLbl");
            }
        }
        private long     nPgTopMargin;
        public long     PgTopMargin
        {
            get { return nPgTopMargin; }
            set
            {
                nPgTopMargin = value;
                OnPropertyChanged("PgTopMargin");
            }
        }
        private long     nPgLeftMargin;
        public long     PgLeftMargin
        {
            get { return nPgLeftMargin; }
            set
            {
                nPgLeftMargin = value;
                OnPropertyChanged("PgLeftMargin");
            }
        }
        private long     nLblVerticalGap;
        public long     LblVerticalGap
        {
            get { return nLblVerticalGap; }
            set
            {
                nLblVerticalGap = value;
                OnPropertyChanged("LblVerticalGap");
            }
        }
        private long     nLblHorizontalGap;
        public long     LblHorizontalGap
        {
            get { return nLblHorizontalGap; }
            set
            {
                nLblHorizontalGap = value;
                OnPropertyChanged("LblHorizontalGap");
            }
        }
        private long     nLblWidth;
        public long     LblWidth
        {
            get { return nLblWidth; }
            set
            {
                nLblWidth = value;
                OnPropertyChanged("LblWidth");
            }
        }
        private long     nLblHeight;
        public long     LblHeight
        {
            get { return nLblHeight; }
            set
            {
                nLblHeight = value;
                OnPropertyChanged("LblHeight");
            }
        }
        private long     nNoOfLine;
        public long     NoOfLine
        {
            get { return nNoOfLine; }
            set
            {
                nNoOfLine = value;
                OnPropertyChanged("NoOfLine");
            }
        }
        private long     nGapLine;
        public long     GapLine
        {
            get { return nGapLine; }
            set
            {
                nGapLine = value;
                OnPropertyChanged("GapLine");
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
        private string     sPrintStyle;
        public string     PrintStyle
        {
            get { return sPrintStyle; }
            set
            {
                sPrintStyle = value;
                OnPropertyChanged("PrintStyle");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LabelType"))){
                    this.LabelType = DBReader.GetString(DBReader.GetOrdinal("LabelType"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OprtSys"))){
                    this.OprtSys = DBReader.GetString(DBReader.GetOrdinal("OprtSys"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FormatName"))){
                    this.FormatName = DBReader.GetString(DBReader.GetOrdinal("FormatName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PrinterName"))){
                    this.PrinterName = DBReader.GetString(DBReader.GetOrdinal("PrinterName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TxtType"))){
                    this.TxtType = DBReader.GetString(DBReader.GetOrdinal("TxtType"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SampleTxt"))){
                    this.SampleTxt = DBReader.GetString(DBReader.GetOrdinal("SampleTxt"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FPrefix"))){
                    this.FPrefix = DBReader.GetString(DBReader.GetOrdinal("FPrefix"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FldName"))){
                    this.FldName = DBReader.GetString(DBReader.GetOrdinal("FldName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FSufix"))){
                    this.FSufix = DBReader.GetString(DBReader.GetOrdinal("FSufix"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PrntFormat"))){
                    this.PrntFormat = DBReader.GetString(DBReader.GetOrdinal("PrntFormat"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PosX"))){
                    this.PosX = DBReader.GetInt64(DBReader.GetOrdinal("PosX"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PosY"))){
                    this.PosY = DBReader.GetInt64(DBReader.GetOrdinal("PosY"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PWidth"))){
                    this.PWidth = DBReader.GetInt64(DBReader.GetOrdinal("PWidth"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PHeight"))){
                    this.PHeight = DBReader.GetInt64(DBReader.GetOrdinal("PHeight"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntName"))){
                    this.FntName = DBReader.GetString(DBReader.GetOrdinal("FntName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntStyle"))){
                    this.FntStyle = DBReader.GetString(DBReader.GetOrdinal("FntStyle"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntBold"))){
                    this.FntBold = DBReader.GetString(DBReader.GetOrdinal("FntBold"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntItalic"))){
                    this.FntItalic = DBReader.GetString(DBReader.GetOrdinal("FntItalic"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntStrikout"))){
                    this.FntStrikout = DBReader.GetString(DBReader.GetOrdinal("FntStrikout"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntUnderLine"))){
                    this.FntUnderLine = DBReader.GetString(DBReader.GetOrdinal("FntUnderLine"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntSize"))){
                    this.FntSize = DBReader.GetInt64(DBReader.GetOrdinal("FntSize"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FntColor"))){
                    this.FntColor = DBReader.GetInt64(DBReader.GetOrdinal("FntColor"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AcrossLbl"))){
                    this.AcrossLbl = DBReader.GetInt64(DBReader.GetOrdinal("AcrossLbl"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PgLbl"))){
                    this.PgLbl = DBReader.GetInt64(DBReader.GetOrdinal("PgLbl"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DuplicateLbl"))){
                    this.DuplicateLbl = DBReader.GetString(DBReader.GetOrdinal("DuplicateLbl"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PgTopMargin"))){
                    this.PgTopMargin = DBReader.GetInt64(DBReader.GetOrdinal("PgTopMargin"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PgLeftMargin"))){
                    this.PgLeftMargin = DBReader.GetInt64(DBReader.GetOrdinal("PgLeftMargin"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LblVerticalGap"))){
                    this.LblVerticalGap = DBReader.GetInt64(DBReader.GetOrdinal("LblVerticalGap"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LblHorizontalGap"))){
                    this.LblHorizontalGap = DBReader.GetInt64(DBReader.GetOrdinal("LblHorizontalGap"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LblWidth"))){
                    this.LblWidth = DBReader.GetInt64(DBReader.GetOrdinal("LblWidth"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LblHeight"))){
                    this.LblHeight = DBReader.GetInt64(DBReader.GetOrdinal("LblHeight"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("NoOfLine"))){
                    this.NoOfLine = DBReader.GetInt64(DBReader.GetOrdinal("NoOfLine"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("GapLine"))){
                    this.GapLine = DBReader.GetInt64(DBReader.GetOrdinal("GapLine"));
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("PrintStyle"))){
                    this.PrintStyle = DBReader.GetString(DBReader.GetOrdinal("PrintStyle"));
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
            sXml.Append("<LabelType>" + this.LabelType + "</LabelType>");
            sXml.Append("<OprtSys>" + this.OprtSys + "</OprtSys>");
            sXml.Append("<FormatName>" + this.FormatName + "</FormatName>");
            sXml.Append("<PrinterName>" + this.PrinterName + "</PrinterName>");
            sXml.Append("<TxtType>" + this.TxtType + "</TxtType>");
            sXml.Append("<SampleTxt>" + this.SampleTxt + "</SampleTxt>");
            sXml.Append("<FPrefix>" + this.FPrefix + "</FPrefix>");
            sXml.Append("<FldName>" + this.FldName + "</FldName>");
            sXml.Append("<FSufix>" + this.FSufix + "</FSufix>");
            sXml.Append("<PrntFormat>" + this.PrntFormat + "</PrntFormat>");
            sXml.Append("<PosX>" + this.PosX + "</PosX>");
            sXml.Append("<PosY>" + this.PosY + "</PosY>");
            sXml.Append("<PWidth>" + this.PWidth + "</PWidth>");
            sXml.Append("<PHeight>" + this.PHeight + "</PHeight>");
            sXml.Append("<FntName>" + this.FntName + "</FntName>");
            sXml.Append("<FntStyle>" + this.FntStyle + "</FntStyle>");
            sXml.Append("<FntBold>" + this.FntBold + "</FntBold>");
            sXml.Append("<FntItalic>" + this.FntItalic + "</FntItalic>");
            sXml.Append("<FntStrikout>" + this.FntStrikout + "</FntStrikout>");
            sXml.Append("<FntUnderLine>" + this.FntUnderLine + "</FntUnderLine>");
            sXml.Append("<FntSize>" + this.FntSize + "</FntSize>");
            sXml.Append("<FntColor>" + this.FntColor + "</FntColor>");
            sXml.Append("<AcrossLbl>" + this.AcrossLbl + "</AcrossLbl>");
            sXml.Append("<PgLbl>" + this.PgLbl + "</PgLbl>");
            sXml.Append("<DuplicateLbl>" + this.DuplicateLbl + "</DuplicateLbl>");
            sXml.Append("<PgTopMargin>" + this.PgTopMargin + "</PgTopMargin>");
            sXml.Append("<PgLeftMargin>" + this.PgLeftMargin + "</PgLeftMargin>");
            sXml.Append("<LblVerticalGap>" + this.LblVerticalGap + "</LblVerticalGap>");
            sXml.Append("<LblHorizontalGap>" + this.LblHorizontalGap + "</LblHorizontalGap>");
            sXml.Append("<LblWidth>" + this.LblWidth + "</LblWidth>");
            sXml.Append("<LblHeight>" + this.LblHeight + "</LblHeight>");
            sXml.Append("<NoOfLine>" + this.NoOfLine + "</NoOfLine>");
            sXml.Append("<GapLine>" + this.GapLine + "</GapLine>");
            sXml.Append("<CUser>" + this.CUser + "</CUser>");
            sXml.Append("<CDateTime>" + this.CDateTime + "</CDateTime>");
            sXml.Append("<EUser>" + this.EUser + "</EUser>");
            sXml.Append("<EDateTime>" + this.EDateTime + "</EDateTime>");
            sXml.Append("<PrintStyle>" + this.PrintStyle + "</PrintStyle>");
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
            PrintFormat objdata = obj as PrintFormat;
            this.RecNo = objdata.RecNo;
            this.LabelType = objdata.LabelType;
            this.OprtSys = objdata.OprtSys;
            this.FormatName = objdata.FormatName;
            this.PrinterName = objdata.PrinterName;
            this.TxtType = objdata.TxtType;
            this.SampleTxt = objdata.SampleTxt;
            this.FPrefix = objdata.FPrefix;
            this.FldName = objdata.FldName;
            this.FSufix = objdata.FSufix;
            this.PrntFormat = objdata.PrntFormat;
            this.PosX = objdata.PosX;
            this.PosY = objdata.PosY;
            this.PWidth = objdata.PWidth;
            this.PHeight = objdata.PHeight;
            this.FntName = objdata.FntName;
            this.FntStyle = objdata.FntStyle;
            this.FntBold = objdata.FntBold;
            this.FntItalic = objdata.FntItalic;
            this.FntStrikout = objdata.FntStrikout;
            this.FntUnderLine = objdata.FntUnderLine;
            this.FntSize = objdata.FntSize;
            this.FntColor = objdata.FntColor;
            this.AcrossLbl = objdata.AcrossLbl;
            this.PgLbl = objdata.PgLbl;
            this.DuplicateLbl = objdata.DuplicateLbl;
            this.PgTopMargin = objdata.PgTopMargin;
            this.PgLeftMargin = objdata.PgLeftMargin;
            this.LblVerticalGap = objdata.LblVerticalGap;
            this.LblHorizontalGap = objdata.LblHorizontalGap;
            this.LblWidth = objdata.LblWidth;
            this.LblHeight = objdata.LblHeight;
            this.NoOfLine = objdata.NoOfLine;
            this.GapLine = objdata.GapLine;
            this.CUser = objdata.CUser;
            this.CDateTime = objdata.CDateTime;
            this.EUser = objdata.EUser;
            this.EDateTime = objdata.EDateTime;
            this.PrintStyle = objdata.PrintStyle;
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
            PrintFormat objdata = obj as PrintFormat;
            objdata.RecNo = this.RecNo;
            objdata.LabelType = this.LabelType;
            objdata.OprtSys = this.OprtSys;
            objdata.FormatName = this.FormatName;
            objdata.PrinterName = this.PrinterName;
            objdata.TxtType = this.TxtType;
            objdata.SampleTxt = this.SampleTxt;
            objdata.FPrefix = this.FPrefix;
            objdata.FldName = this.FldName;
            objdata.FSufix = this.FSufix;
            objdata.PrntFormat = this.PrntFormat;
            objdata.PosX = this.PosX;
            objdata.PosY = this.PosY;
            objdata.PWidth = this.PWidth;
            objdata.PHeight = this.PHeight;
            objdata.FntName = this.FntName;
            objdata.FntStyle = this.FntStyle;
            objdata.FntBold = this.FntBold;
            objdata.FntItalic = this.FntItalic;
            objdata.FntStrikout = this.FntStrikout;
            objdata.FntUnderLine = this.FntUnderLine;
            objdata.FntSize = this.FntSize;
            objdata.FntColor = this.FntColor;
            objdata.AcrossLbl = this.AcrossLbl;
            objdata.PgLbl = this.PgLbl;
            objdata.DuplicateLbl = this.DuplicateLbl;
            objdata.PgTopMargin = this.PgTopMargin;
            objdata.PgLeftMargin = this.PgLeftMargin;
            objdata.LblVerticalGap = this.LblVerticalGap;
            objdata.LblHorizontalGap = this.LblHorizontalGap;
            objdata.LblWidth = this.LblWidth;
            objdata.LblHeight = this.LblHeight;
            objdata.NoOfLine = this.NoOfLine;
            objdata.GapLine = this.GapLine;
            objdata.CUser = this.CUser;
            objdata.CDateTime = this.CDateTime;
            objdata.EUser = this.EUser;
            objdata.EDateTime = this.EDateTime;
            objdata.PrintStyle = this.PrintStyle;
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
            this.LabelType = string.Empty;;
            this.OprtSys = string.Empty;;
            this.FormatName = string.Empty;;
            this.PrinterName = string.Empty;;
            this.TxtType = string.Empty;;
            this.SampleTxt = string.Empty;;
            this.FPrefix = string.Empty;;
            this.FldName = string.Empty;;
            this.FSufix = string.Empty;;
            this.PrntFormat = string.Empty;;
            this.PosX = 0;
            this.PosY = 0;
            this.PWidth = 0;
            this.PHeight = 0;
            this.FntName = string.Empty;;
            this.FntStyle = string.Empty;;
            this.FntBold = string.Empty;;
            this.FntItalic = string.Empty;;
            this.FntStrikout = string.Empty;;
            this.FntUnderLine = string.Empty;;
            this.FntSize = 0;
            this.FntColor = 0;
            this.AcrossLbl = 0;
            this.PgLbl = 0;
            this.DuplicateLbl = string.Empty;;
            this.PgTopMargin = 0;
            this.PgLeftMargin = 0;
            this.LblVerticalGap = 0;
            this.LblHorizontalGap = 0;
            this.LblWidth = 0;
            this.LblHeight = 0;
            this.NoOfLine = 0;
            this.GapLine = 0;
            this.CUser = 0;
            this.CDateTime = new DateTime();
            this.EUser = 0;
            this.EDateTime = new DateTime();
            this.PrintStyle = string.Empty;;
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
