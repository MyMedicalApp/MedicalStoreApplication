-- Store Procedures for OrderDetail Table
 
CREATE PROC [dbo].[sprocOrderDetailInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@BillTag varchar(20) = NULL,
						@BillType varchar(20) = NULL,
						@BillCredit varchar(10) = NULL,
						@BillSeries varchar(1) = NULL,
						@BillNo bigint = NULL,
						@BillDate datetime = NULL,
						@AccountCode bigint = NULL,
						@ChallanNo bigint = NULL,
						@ChallanDate datetime = NULL,
						@EntryTag varchar(8) = NULL,
						@ProductCode bigint = NULL,
						@CompanyCode bigint = NULL,
						@BatchCode bigint = NULL,
						@MRP money = NULL,
						@BatchNo varchar(15) = NULL,
						@Expiry datetime = NULL,
						@Qty money = NULL,
						@FQty money = NULL,
						@ConversionUnit money = NULL,
						@Rate money = NULL,
						@HalfScheme varchar(3) = NULL,
						@Scheme money = NULL,
						@SchemeRs money = NULL,
						@SplDisc money = NULL,
						@SplDiscRs money = NULL,
						@Disc money = NULL,
						@DiscRs money = NULL,
						@Inclusive varchar(3) = NULL,
						@VatOn varchar(5) = NULL,
						@Vat money = NULL,
						@VatRs money = NULL,
						@AdVat money = NULL,
						@AdVatRs money = NULL,
						@NetRate money = NULL,
						@VatOnFree varchar(3) = NULL,
						@NetCostRate money = NULL,
						@NetAmount money = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
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
                set @RecNo = (select count(*) from OrderDetail)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from OrderDetail)
                set @RecNo = @RecNo + 1
 
                insert into [OrderDetail]
                (
                    [BillTag],
                    [BillType],
                    [BillCredit],
                    [BillSeries],
                    [BillNo],
                    [BillDate],
                    [AccountCode],
                    [ChallanNo],
                    [ChallanDate],
                    [EntryTag],
                    [ProductCode],
                    [CompanyCode],
                    [BatchCode],
                    [MRP],
                    [BatchNo],
                    [Expiry],
                    [Qty],
                    [FQty],
                    [ConversionUnit],
                    [Rate],
                    [HalfScheme],
                    [Scheme],
                    [SchemeRs],
                    [SplDisc],
                    [SplDiscRs],
                    [Disc],
                    [DiscRs],
                    [Inclusive],
                    [VatOn],
                    [Vat],
                    [VatRs],
                    [AdVat],
                    [AdVatRs],
                    [NetRate],
                    [VatOnFree],
                    [NetCostRate],
                    [NetAmount],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [CreatedBy],
                    [CreatedDate],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount],
                    [LUT]
                 )
                 VALUES
                 (
                    @BillTag,
                    @BillType,
                    @BillCredit,
                    @BillSeries,
                    @BillNo,
                    @BillDate,
                    @AccountCode,
                    @ChallanNo,
                    @ChallanDate,
                    @EntryTag,
                    @ProductCode,
                    @CompanyCode,
                    @BatchCode,
                    @MRP,
                    @BatchNo,
                    @Expiry,
                    @Qty,
                    @FQty,
                    @ConversionUnit,
                    @Rate,
                    @HalfScheme,
                    @Scheme,
                    @SchemeRs,
                    @SplDisc,
                    @SplDiscRs,
                    @Disc,
                    @DiscRs,
                    @Inclusive,
                    @VatOn,
                    @Vat,
                    @VatRs,
                    @AdVat,
                    @AdVatRs,
                    @NetRate,
                    @VatOnFree,
                    @NetCostRate,
                    @NetAmount,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @CreatedBy,
                    @CreatedDate,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount,
                    @LUT
                  )
                SET @Message=convert(varchar(20),@RecNo)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [OrderDetail]
                SET
                [RecNo] = @RecNo,
                [BillTag] = @BillTag,
                [BillType] = @BillType,
                [BillCredit] = @BillCredit,
                [BillSeries] = @BillSeries,
                [BillNo] = @BillNo,
                [BillDate] = @BillDate,
                [AccountCode] = @AccountCode,
                [ChallanNo] = @ChallanNo,
                [ChallanDate] = @ChallanDate,
                [EntryTag] = @EntryTag,
                [ProductCode] = @ProductCode,
                [CompanyCode] = @CompanyCode,
                [BatchCode] = @BatchCode,
                [MRP] = @MRP,
                [BatchNo] = @BatchNo,
                [Expiry] = @Expiry,
                [Qty] = @Qty,
                [FQty] = @FQty,
                [ConversionUnit] = @ConversionUnit,
                [Rate] = @Rate,
                [HalfScheme] = @HalfScheme,
                [Scheme] = @Scheme,
                [SchemeRs] = @SchemeRs,
                [SplDisc] = @SplDisc,
                [SplDiscRs] = @SplDiscRs,
                [Disc] = @Disc,
                [DiscRs] = @DiscRs,
                [Inclusive] = @Inclusive,
                [VatOn] = @VatOn,
                [Vat] = @Vat,
                [VatRs] = @VatRs,
                [AdVat] = @AdVat,
                [AdVatRs] = @AdVatRs,
                [NetRate] = @NetRate,
                [VatOnFree] = @VatOnFree,
                [NetCostRate] = @NetCostRate,
                [NetAmount] = @NetAmount,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount,
                [LUT] = @LUT
                                WHERE  [RecNo] = @RecNo
                SET @Message=convert(varchar(20),@RecNo)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [OrderDetail] WHERE  [RecNo] = @RecNo
            SET @Message=convert(varchar(20),@RecNo)+' Record Deleted SucessFully'
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
