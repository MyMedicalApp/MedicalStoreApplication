-- Store Procedures for BatchMaster Table
 
CREATE PROC [dbo].[sprocBatchMasterInsertUpdateSingleItem] 
						@BatchCode bigint = NULL,
						@ICode varchar(13) = NULL,
						@ProductCode bigint = NULL,
						@AccountCode bigint = NULL,
						@MRP money = NULL,
						@BatchNo varchar(15) = NULL,
						@Expiry datetime = NULL,
						@Inclusive varchar(3) = NULL,
						@VatOn varchar(5) = NULL,
						@Vat money = NULL,
						@AdVat money = NULL,
						@Octroi money = NULL,
						@PurRs money = NULL,
						@SaleRs money = NULL,
						@NetRate money = NULL,
						@StockPt bigint = NULL,
						@OpQty money = NULL,
						@OpQtyRs money = NULL,
						@OpFQty money = NULL,
						@OpFQtyRs money = NULL,
						@PurQty money = NULL,
						@PurQtyRs money = NULL,
						@PurFQty money = NULL,
						@PurFQtyRs money = NULL,
						@CrQty money = NULL,
						@CrQtyRs money = NULL,
						@CrFQty money = NULL,
						@CrFQtyRs money = NULL,
						@RcptQty money = NULL,
						@RcptQtyRs money = NULL,
						@SaleQty money = NULL,
						@SaleQtyRs money = NULL,
						@SaleFQty money = NULL,
						@SaleFQtyRs money = NULL,
						@IssueQty money = NULL,
						@IssueQtyRs money = NULL,
						@ClQty money = NULL,
						@ClQtyRs money = NULL,
						@ClFQty money = NULL,
						@ClFQtyRs money = NULL,
						@TQty money = NULL,
						@TQtyRs money = NULL,
						@BarSeries varchar(2) = NULL,
						@BarCode varchar(13) = NULL,
						@BatchHead varchar(10) = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@DLock varchar(3) = NULL,
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
                set @BatchCode = (select count(*) from BatchMaster)
                if @BatchCode  <> 0
                    set @BatchCode = (select max(BatchCode) from BatchMaster)
                set @BatchCode = @BatchCode + 1
 
                insert into [BatchMaster]
                (
                    [ICode],
                    [ProductCode],
                    [AccountCode],
                    [MRP],
                    [BatchNo],
                    [Expiry],
                    [Inclusive],
                    [VatOn],
                    [Vat],
                    [AdVat],
                    [Octroi],
                    [PurRs],
                    [SaleRs],
                    [NetRate],
                    [StockPt],
                    [OpQty],
                    [OpQtyRs],
                    [OpFQty],
                    [OpFQtyRs],
                    [PurQty],
                    [PurQtyRs],
                    [PurFQty],
                    [PurFQtyRs],
                    [CrQty],
                    [CrQtyRs],
                    [CrFQty],
                    [CrFQtyRs],
                    [RcptQty],
                    [RcptQtyRs],
                    [SaleQty],
                    [SaleQtyRs],
                    [SaleFQty],
                    [SaleFQtyRs],
                    [IssueQty],
                    [IssueQtyRs],
                    [ClQty],
                    [ClQtyRs],
                    [ClFQty],
                    [ClFQtyRs],
                    [TQty],
                    [TQtyRs],
                    [BarSeries],
                    [BarCode],
                    [BatchHead],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [DLock],
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
                    @ProductCode,
                    @AccountCode,
                    @MRP,
                    @BatchNo,
                    @Expiry,
                    @Inclusive,
                    @VatOn,
                    @Vat,
                    @AdVat,
                    @Octroi,
                    @PurRs,
                    @SaleRs,
                    @NetRate,
                    @StockPt,
                    @OpQty,
                    @OpQtyRs,
                    @OpFQty,
                    @OpFQtyRs,
                    @PurQty,
                    @PurQtyRs,
                    @PurFQty,
                    @PurFQtyRs,
                    @CrQty,
                    @CrQtyRs,
                    @CrFQty,
                    @CrFQtyRs,
                    @RcptQty,
                    @RcptQtyRs,
                    @SaleQty,
                    @SaleQtyRs,
                    @SaleFQty,
                    @SaleFQtyRs,
                    @IssueQty,
                    @IssueQtyRs,
                    @ClQty,
                    @ClQtyRs,
                    @ClFQty,
                    @ClFQtyRs,
                    @TQty,
                    @TQtyRs,
                    @BarSeries,
                    @BarCode,
                    @BatchHead,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @DLock,
                    @CreatedBy,
                    @CreatedDate,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount,
                    @LUT
                  )
                SET @Message=convert(varchar(20),@BatchCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [BatchMaster]
                SET
                [BatchCode] = @BatchCode,
                [ICode] = @ICode,
                [ProductCode] = @ProductCode,
                [AccountCode] = @AccountCode,
                [MRP] = @MRP,
                [BatchNo] = @BatchNo,
                [Expiry] = @Expiry,
                [Inclusive] = @Inclusive,
                [VatOn] = @VatOn,
                [Vat] = @Vat,
                [AdVat] = @AdVat,
                [Octroi] = @Octroi,
                [PurRs] = @PurRs,
                [SaleRs] = @SaleRs,
                [NetRate] = @NetRate,
                [StockPt] = @StockPt,
                [OpQty] = @OpQty,
                [OpQtyRs] = @OpQtyRs,
                [OpFQty] = @OpFQty,
                [OpFQtyRs] = @OpFQtyRs,
                [PurQty] = @PurQty,
                [PurQtyRs] = @PurQtyRs,
                [PurFQty] = @PurFQty,
                [PurFQtyRs] = @PurFQtyRs,
                [CrQty] = @CrQty,
                [CrQtyRs] = @CrQtyRs,
                [CrFQty] = @CrFQty,
                [CrFQtyRs] = @CrFQtyRs,
                [RcptQty] = @RcptQty,
                [RcptQtyRs] = @RcptQtyRs,
                [SaleQty] = @SaleQty,
                [SaleQtyRs] = @SaleQtyRs,
                [SaleFQty] = @SaleFQty,
                [SaleFQtyRs] = @SaleFQtyRs,
                [IssueQty] = @IssueQty,
                [IssueQtyRs] = @IssueQtyRs,
                [ClQty] = @ClQty,
                [ClQtyRs] = @ClQtyRs,
                [ClFQty] = @ClFQty,
                [ClFQtyRs] = @ClFQtyRs,
                [TQty] = @TQty,
                [TQtyRs] = @TQtyRs,
                [BarSeries] = @BarSeries,
                [BarCode] = @BarCode,
                [BatchHead] = @BatchHead,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [DLock] = @DLock,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount,
                [LUT] = @LUT
                                WHERE  [BatchCode] = @BatchCode
                SET @Message=convert(varchar(20),@BatchCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [BatchMaster] WHERE  [BatchCode] = @BatchCode
            SET @Message=convert(varchar(20),@BatchCode)+' Record Deleted SucessFully'
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
