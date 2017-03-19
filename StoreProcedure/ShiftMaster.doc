-- Store Procedures for ShiftMaster Table
 
CREATE PROC [dbo].[sprocShiftMasterInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@ShiftName varchar(50) = NULL,
						@ShiftNo bigint = NULL,
						@ShiftDate datetime = NULL,
						@OpCash money = NULL,
						@CashReceipt money = NULL,
						@ReceiptVoucher money = NULL,
						@CashReturn money = NULL,
						@CashPayment money = NULL,
						@PaymentVoucher money = NULL,
						@ExtraAmount money = NULL,
						@Amount money = NULL,
						@ShiftMess varchar(100) = NULL,
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
                set @RecNo = (select count(*) from ShiftMaster)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from ShiftMaster)
                set @RecNo = @RecNo + 1
 
                insert into [ShiftMaster]
                (
                    [ShiftName],
                    [ShiftNo],
                    [ShiftDate],
                    [OpCash],
                    [CashReceipt],
                    [ReceiptVoucher],
                    [CashReturn],
                    [CashPayment],
                    [PaymentVoucher],
                    [ExtraAmount],
                    [Amount],
                    [ShiftMess],
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
                    @ShiftName,
                    @ShiftNo,
                    @ShiftDate,
                    @OpCash,
                    @CashReceipt,
                    @ReceiptVoucher,
                    @CashReturn,
                    @CashPayment,
                    @PaymentVoucher,
                    @ExtraAmount,
                    @Amount,
                    @ShiftMess,
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
                UPDATE [ShiftMaster]
                SET
                [RecNo] = @RecNo,
                [ShiftName] = @ShiftName,
                [ShiftNo] = @ShiftNo,
                [ShiftDate] = @ShiftDate,
                [OpCash] = @OpCash,
                [CashReceipt] = @CashReceipt,
                [ReceiptVoucher] = @ReceiptVoucher,
                [CashReturn] = @CashReturn,
                [CashPayment] = @CashPayment,
                [PaymentVoucher] = @PaymentVoucher,
                [ExtraAmount] = @ExtraAmount,
                [Amount] = @Amount,
                [ShiftMess] = @ShiftMess,
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
            DELETE FROM [ShiftMaster] WHERE  [RecNo] = @RecNo
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
