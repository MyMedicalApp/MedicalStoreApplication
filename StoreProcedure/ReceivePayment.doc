-- Store Procedures for ReceivePayment Table
 
CREATE PROC [dbo].[sprocReceivePaymentInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@EntryTag varchar(30) = NULL,
						@RefNo bigint = NULL,
						@EntryDate datetime = NULL,
						@ChequeNo varchar(10) = NULL,
						@ChequeDate datetime = NULL,
						@AccountCode1 bigint = NULL,
						@AccountCode2 bigint = NULL,
						@Amount money = NULL,
						@RcptMess varchar(100) = NULL,
						@ReconDate datetime = NULL,
						@ShiftNo bigint = NULL,
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
                set @RecNo = (select count(*) from ReceivePayment)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from ReceivePayment)
                set @RecNo = @RecNo + 1
 
                insert into [ReceivePayment]
                (
                    [EntryTag],
                    [RefNo],
                    [EntryDate],
                    [ChequeNo],
                    [ChequeDate],
                    [AccountCode1],
                    [AccountCode2],
                    [Amount],
                    [RcptMess],
                    [ReconDate],
                    [ShiftNo],
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
                    @EntryTag,
                    @RefNo,
                    @EntryDate,
                    @ChequeNo,
                    @ChequeDate,
                    @AccountCode1,
                    @AccountCode2,
                    @Amount,
                    @RcptMess,
                    @ReconDate,
                    @ShiftNo,
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
                UPDATE [ReceivePayment]
                SET
                [RecNo] = @RecNo,
                [EntryTag] = @EntryTag,
                [RefNo] = @RefNo,
                [EntryDate] = @EntryDate,
                [ChequeNo] = @ChequeNo,
                [ChequeDate] = @ChequeDate,
                [AccountCode1] = @AccountCode1,
                [AccountCode2] = @AccountCode2,
                [Amount] = @Amount,
                [RcptMess] = @RcptMess,
                [ReconDate] = @ReconDate,
                [ShiftNo] = @ShiftNo,
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
            DELETE FROM [ReceivePayment] WHERE  [RecNo] = @RecNo
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
