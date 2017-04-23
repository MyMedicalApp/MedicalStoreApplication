using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Common
{    
    public interface IModel
    {
        DataBaseOperation OperationFlag { get; set; }

        string GetXmlString();
        void FillDataFromDB(IDataRecord DBReader);

        void Clone<T>(T obj) where T : class, IModel;
        T Copy<T>() where T : class, IModel, new();
        void ResetData();
        
        
    }

    public interface IViewDetail
    {
        //void AddData<T>(T obj) where T : class, IModel;
    }   

    public enum LogMode : short
    {
        DEBUG = 1,
        High = 2,
        Medium = 4,
        Low = 8,
        NoLog = 16
    }

    public enum DataSourceTypes : short
    {
        SalesDetailList = 1,
        SalesDetailSave,
        AreaMasterList,
        AreaMasterSave,
        oVatDetailList,
        oVatDetailSave,
        AutoSetupList,
        AutoSetupSave,
        CustomerMasterList,
        CustomerMasterSave,
        ErrorDescList,
        ErrorDescSave,
        DoctorMasterList,
        DoctorMasterSave,
        FirmMasterList,
        FirmMasterSave,
        DiseaseDetailList,
        DiseaseDetailSave,
        AdjDetailList,
        AdjDetailSave,
        ShiftMasterList,
        ShiftMasterSave,
        DiseaseMasterList,
        DiseaseMasterSave,
        CrDrDetailList,
        CrDrDetailSave,
        VatDetailList,
        VatDetailSave,
        GroupMasterList,
        GroupMasterSave,
        MapProductList,
        MapProductSave,
        OldBillMasterList,
        OldBillMasterSave,
        dtpropertiesList,
        dtpropertiesSave,
        XDetailList,
        XDetailSave,
        OrderDetailList,
        OrderDetailSave,
        DeletedDetailList,
        DeletedDetailSave,
        TallyMasterList,
        TallyMasterSave,
        OBillMasterList,
        OBillMasterSave,
        BranchStockList,
        BranchStockSave,
        XMasterList,
        XMasterSave,
        oBatchMasterList,
        oBatchMasterSave,
        AccountMasterList,
        AccountMasterSave,
        CityMasterList,
        CityMasterSave,
        OrderMasterList,
        OrderMasterSave,
        CompanyDetailList,
        CompanyDetailSave,
        MiscRcptPmtList,
        MiscRcptPmtSave,
        CategoryMasterList,
        CategoryMasterSave,
        CompanyMasterList,
        CompanyMasterSave,
        PurDetailList,
        PurDetailSave,
        ConfigList,
        ConfigSave,
        GenericMasterList,
        GenericMasterSave,
        SalesManMasterList,
        SalesManMasterSave,
        BillMasterList,
        BillMasterSave,
        ProductMasterList,
        GetAllListProduct,
        ProductMasterSave,
        OtherAddList,
        OtherAddSave,
        PatientMasterList,
        PatientMasterSave,
        BatchMasterList,
        BatchMasterListByProductCode,
        BatchMasterSave,
        PreFormatList,
        PreFormatSave,
        UserMasterList,
        UserMasterSave,
        PrintFormatList,
        PrintFormatSave,
        ReceivePaymentList,
        ReceivePaymentSave,
        AddressBookList,
        AddressBookSave

    }

    public enum DateTimeFormat : short
    {
        None,
        ShortDate,
        DateTime12Hr,
        Time12Hr,
        Time24Hr,
        LongDate
    }

    public enum DataBaseOperation : short
    {
        Save = 0,
        Update,
        Delete
    }

    public enum PrimKeyTables : short
    {
        Broker      = 1,
        Transport   = 2,
        Quality     = 3,
        Weaver      = 4,
        Checker     = 5,
        TranCash    = 6,
        TranJouranl = 7,
        TranPurchaseOrder = 8,
        TranSalesOrder = 9,
        Company     = 10
    }
}
