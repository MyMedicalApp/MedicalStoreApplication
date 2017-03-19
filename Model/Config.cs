 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace MedicalApp.Model
{    
    public class Config : IModel,INotifyPropertyChanged
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
        private string     sDfltVariable;
        public string     DfltVariable
        {
            get { return sDfltVariable; }
            set
            {
                sDfltVariable = value;
                OnPropertyChanged("DfltVariable");
            }
        }
        private string     sDfltValue;
        public string     DfltValue
        {
            get { return sDfltValue; }
            set
            {
                sDfltValue = value;
                OnPropertyChanged("DfltValue");
            }
        }
        private long     nUSERCODE;
        public long     USERCODE
        {
            get { return nUSERCODE; }
            set
            {
                nUSERCODE = value;
                OnPropertyChanged("USERCODE");
            }
        }
        private long     nCUSER;
        public long     CUSER
        {
            get { return nCUSER; }
            set
            {
                nCUSER = value;
                OnPropertyChanged("CUSER");
            }
        }
        private DateTime     dtCDATETIME;
        public DateTime     CDATETIME
        {
            get { return dtCDATETIME; }
            set
            {
                dtCDATETIME = value;
                OnPropertyChanged("CDATETIME");
            }
        }
        private long     nEUSER;
        public long     EUSER
        {
            get { return nEUSER; }
            set
            {
                nEUSER = value;
                OnPropertyChanged("EUSER");
            }
        }
        private DateTime     dtEDATETIME;
        public DateTime     EDATETIME
        {
            get { return dtEDATETIME; }
            set
            {
                dtEDATETIME = value;
                OnPropertyChanged("EDATETIME");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DfltVariable"))){
                    this.DfltVariable = DBReader.GetString(DBReader.GetOrdinal("DfltVariable"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("DfltValue"))){
                    this.DfltValue = DBReader.GetString(DBReader.GetOrdinal("DfltValue"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("USERCODE"))){
                    this.USERCODE = DBReader.GetInt64(DBReader.GetOrdinal("USERCODE"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CUSER"))){
                    this.CUSER = DBReader.GetInt64(DBReader.GetOrdinal("CUSER"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CDATETIME"))){
                    this.CDATETIME = DBReader.GetDateTime(DBReader.GetOrdinal("CDATETIME"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EUSER"))){
                    this.EUSER = DBReader.GetInt64(DBReader.GetOrdinal("EUSER"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EDATETIME"))){
                    this.EDATETIME = DBReader.GetDateTime(DBReader.GetOrdinal("EDATETIME"));
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
            sXml.Append("<DfltVariable>" + this.DfltVariable + "</DfltVariable>");
            sXml.Append("<DfltValue>" + this.DfltValue + "</DfltValue>");
            sXml.Append("<USERCODE>" + this.USERCODE + "</USERCODE>");
            sXml.Append("<CUSER>" + this.CUSER + "</CUSER>");
            sXml.Append("<CDATETIME>" + this.CDATETIME + "</CDATETIME>");
            sXml.Append("<EUSER>" + this.EUSER + "</EUSER>");
            sXml.Append("<EDATETIME>" + this.EDATETIME + "</EDATETIME>");
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
            Config objdata = obj as Config;
            this.RecNo = objdata.RecNo;
            this.DfltVariable = objdata.DfltVariable;
            this.DfltValue = objdata.DfltValue;
            this.USERCODE = objdata.USERCODE;
            this.CUSER = objdata.CUSER;
            this.CDATETIME = objdata.CDATETIME;
            this.EUSER = objdata.EUSER;
            this.EDATETIME = objdata.EDATETIME;
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
            Config objdata = obj as Config;
            objdata.RecNo = this.RecNo;
            objdata.DfltVariable = this.DfltVariable;
            objdata.DfltValue = this.DfltValue;
            objdata.USERCODE = this.USERCODE;
            objdata.CUSER = this.CUSER;
            objdata.CDATETIME = this.CDATETIME;
            objdata.EUSER = this.EUSER;
            objdata.EDATETIME = this.EDATETIME;
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
            this.DfltVariable = string.Empty;;
            this.DfltValue = string.Empty;;
            this.USERCODE = 0;
            this.CUSER = 0;
            this.CDATETIME = new DateTime();
            this.EUSER = 0;
            this.EDATETIME = new DateTime();
            this.CreatedBy = string.Empty;;
            this.CreatedDate = new DateTime();
            this.UpdateddBy = string.Empty;;
            this.UpdatedDate = new DateTime();
            this.UpdatedCount = 0;
            this.LUT = new DateTime();
        }  

    }  
}
