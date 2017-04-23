-- Store Procedures for ProductMaster Table
 
CREATE PROC [dbo].[sprocProductMasterInsertUpdateSingleItem] 
						@ProductCode bigint = NULL,
						@ICode varchar(50) = NULL,
						@ProductName varchar(50) = NULL,
						@Packing varchar(50) = NULL,
						@PackingType varchar(50) = NULL,
						@ConversionUnit money = NULL,
						@CompanyTag varchar(50) = NULL,
						@CompanyCode bigint = NULL,
						@CategoryCode bigint = NULL,
						@GenericCode bigint = NULL,
						@Rate money = NULL,
						@SplRate money = NULL,
						@DiscYN varchar(50) = NULL,
						@Discount money = NULL,
						@Inclusive varchar(50) = NULL,
						@VatOn varchar(50) = NULL,
						@Vat money = NULL,
						@AdVat money = NULL,
						@CST money = NULL,
						@BarPrint varchar(50) = NULL,
						@BarCode varchar(13) = NULL,
						@MinQty money = NULL,
						@MaxQty money = NULL,
						@ReOrderQty money = NULL,
						@RackID varchar(50) = NULL,
						@TStk money = NULL,
						@LPurRs money = NULL,
						@ImageName varchar(50) = NULL,
						@Scheme money = NULL,
						@SQty money = NULL,
						@SFQty money = NULL,
						@NDRX varchar(3) = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@LCode bigint = NULL,
						@SaleCatCode bigint = NULL,
						@OldProductCode bigint = NULL,
						@DoctorCode bigint = NULL,
						@DLock varchar(3) = NULL,
						@SchDrg varchar(10) = NULL,
						@Note1 varchar(200) = NULL,
						@Fav varchar(3) = NULL,
						@CreatedBy varchar(50) = NULL,
						@CreatedDate datetime = NULL,
						@UpdateddBy varchar(50) = NULL,
						@UpdatedDate datetime = NULL,
						@UpdatedCount int = NULL,
						@LUT datetime = NULL,
						@OperationFlag int = NULL,
						@Message varchar(300) output,
						@ErrorCode int output
AS 
BEGIN 
 
    /* Declare Error Id For Track Internal Errors*/
    set @ErrorCode = 0
 
 
    BEGIN TRY
        BEGIN TRANSACTION
        IF (@OperationFlag = 0)
        BEGIN
                set @ProductCode = (select count(*) from ProductMaster)
                if @ProductCode  <> 0
                    set @ProductCode = (select max(ProductCode) from ProductMaster)
                set @ProductCode = @ProductCode + 1
 
                insert into [ProductMaster]
                (
                    [ICode],
                    [ProductName],
                    [Packing],
                    [PackingType],
                    [ConversionUnit],
                    [CompanyTag],
                    [CompanyCode],
                    [CategoryCode],
                    [GenericCode],
                    [Rate],
                    [SplRate],
                    [DiscYN],
                    [Discount],
                    [Inclusive],
                    [VatOn],
                    [Vat],
                    [AdVat],
                    [CST],
                    [BarPrint],
                    [BarCode],
                    [MinQty],
                    [MaxQty],
                    [ReOrderQty],
                    [RackID],
                    [TStk],
                    [LPurRs],
                    [ImageName],
                    [Scheme],
                    [SQty],
                    [SFQty],
                    [NDRX],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [LCode],
                    [SaleCatCode],
                    [OldProductCode],
                    [DoctorCode],
                    [DLock],
                    [SchDrg],
                    [Note1],
                    [Fav],
                    [CreatedBy],
                    [CreatedDate],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount],
                    [LUT]
                 )
                 VALUES
                 (
                    @ICode,
                    @ProductName,
                    @Packing,
                    @PackingType,
                    @ConversionUnit,
                    @CompanyTag,
                    @CompanyCode,
                    @CategoryCode,
                    @GenericCode,
                    @Rate,
                    @SplRate,
                    @DiscYN,
                    @Discount,
                    @Inclusive,
                    @VatOn,
                    @Vat,
                    @AdVat,
                    @CST,
                    @BarPrint,
                    @BarCode,
                    @MinQty,
                    @MaxQty,
                    @ReOrderQty,
                    @RackID,
                    @TStk,
                    @LPurRs,
                    @ImageName,
                    @Scheme,
                    @SQty,
                    @SFQty,
                    @NDRX,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @LCode,
                    @SaleCatCode,
                    @OldProductCode,
                    @DoctorCode,
                    @DLock,
                    @SchDrg,
                    @Note1,
                    @Fav,
                    @CreatedBy,
                    @CreatedDate,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount,
                    @LUT
                  )
                SET @Message=convert(varchar(20),@ProductCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [ProductMaster]
                SET
                [ProductCode] = @ProductCode,
                [ICode] = @ICode,
                [ProductName] = @ProductName,
                [Packing] = @Packing,
                [PackingType] = @PackingType,
                [ConversionUnit] = @ConversionUnit,
                [CompanyTag] = @CompanyTag,
                [CompanyCode] = @CompanyCode,
                [CategoryCode] = @CategoryCode,
                [GenericCode] = @GenericCode,
                [Rate] = @Rate,
                [SplRate] = @SplRate,
                [DiscYN] = @DiscYN,
                [Discount] = @Discount,
                [Inclusive] = @Inclusive,
                [VatOn] = @VatOn,
                [Vat] = @Vat,
                [AdVat] = @AdVat,
                [CST] = @CST,
                [BarPrint] = @BarPrint,
                [BarCode] = @BarCode,
                [MinQty] = @MinQty,
                [MaxQty] = @MaxQty,
                [ReOrderQty] = @ReOrderQty,
                [RackID] = @RackID,
                [TStk] = @TStk,
                [LPurRs] = @LPurRs,
                [ImageName] = @ImageName,
                [Scheme] = @Scheme,
                [SQty] = @SQty,
                [SFQty] = @SFQty,
                [NDRX] = @NDRX,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [LCode] = @LCode,
                [SaleCatCode] = @SaleCatCode,
                [OldProductCode] = @OldProductCode,
                [DoctorCode] = @DoctorCode,
                [DLock] = @DLock,
                [SchDrg] = @SchDrg,
                [Note1] = @Note1,
                [Fav] = @Fav,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount,
                [LUT] = @LUT
                                WHERE  [ProductCode] = @ProductCode
                SET @Message=convert(varchar(20),@ProductCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [ProductMaster] WHERE  [ProductCode] = @ProductCode
            SET @Message=convert(varchar(20),@ProductCode)+' Record Deleted SucessFully'
        END
        COMMIT TRANSACTION
    END TRY
 
    BEGIN CATCH	
        set @ErrorCode = @@ERROR
        ROLLBACK TRANSACTION
        if @ErrorCode = 1205
        BEGIN
                set @Message = 'Deadlock recovery attempt.'
                WAITFOR DELAY '00:00:10'
        END
        ELSE
        BEGIN
                SET @Message = error_message()
        END
        declare @dt datetime,@error_LineNo int
        select @dt = GETDATE(), @error_LineNo = ERROR_LINE()
        exec   sprocErrorDescInsertUpdateSingleItem  0								--@CategoryId int = NULL,
                                                    ,0								--@PageCode int = NULL,
                                                    ,0								--@MethodCode int = NULL,
                                                    ,0								--@EventCode int = NULL,
                                                    ,@error_LineNo					--@ErrorLineNo int = NULL,
                                                    ,''								--@MethodTrace varchar(1000) = NULL,
                                                    ,''								--@EmpNo varchar(50) = NULL,
                                                    ,''								--@ClientIPAddress varchar(30) = NULL,
                                                    ,''								--@PageName varchar(50) = NULL,
                                                    ,'GetOrderCustomerMstList'		--@MethodName varchar(50) = NULL,
                                                    ,@Message						--@ErrorMsg varchar(1000) = NULL,
                                                    ,'Database log error'			--@ErrorType varchar(50) = NULL,
                                                    ,@dt							--@ErrorDate datetime = NULL,
                                                    ,''								--@ErrorData varchar(MAX) = NULL,
                                                    ,0								--@OperationFlag int = NULL,
                                                    ,@Message output				--@Message varchar(300) output,
                                                    ,@ErrorCode output				--@ErrorCode int output
    END CATCH
    ENDPROC:
    print @Message
END
