-- Store Procedures for MiscRcptPmt Table
 
CREATE PROC [dbo].[sprocMiscRcptPmtInsertUpdateSingleItem] 
						@RcptCode bigint = NULL,
						@EntryDate datetime = NULL,
						@EntryTag varchar(5) = NULL,
						@BillTag varchar(20) = NULL,
						@BillType varchar(20) = NULL,
						@BillCredit varchar(10) = NULL,
						@BillSeries varchar(1) = NULL,
						@BillNo bigint = NULL,
						@TotAmount money = NULL,
						@RcptAmount money = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@ARecNo bigint = NULL,
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
                set @RcptCode = (select count(*) from MiscRcptPmt)
                if @RcptCode  <> 0
                    set @RcptCode = (select max(RcptCode) from MiscRcptPmt)
                set @RcptCode = @RcptCode + 1
 
                insert into [MiscRcptPmt]
                (
                    [EntryDate],
                    [EntryTag],
                    [BillTag],
                    [BillType],
                    [BillCredit],
                    [BillSeries],
                    [BillNo],
                    [TotAmount],
                    [RcptAmount],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [ARecNo],
                    [CreatedBy],
                    [CreatedDate],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount],
                    [LUT]
                 )
                 VALUES
                 (
                    @EntryDate,
                    @EntryTag,
                    @BillTag,
                    @BillType,
                    @BillCredit,
                    @BillSeries,
                    @BillNo,
                    @TotAmount,
                    @RcptAmount,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @ARecNo,
                    @CreatedBy,
                    @CreatedDate,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount,
                    @LUT
                  )
                SET @Message=convert(varchar(20),@RcptCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [MiscRcptPmt]
                SET
                [RcptCode] = @RcptCode,
                [EntryDate] = @EntryDate,
                [EntryTag] = @EntryTag,
                [BillTag] = @BillTag,
                [BillType] = @BillType,
                [BillCredit] = @BillCredit,
                [BillSeries] = @BillSeries,
                [BillNo] = @BillNo,
                [TotAmount] = @TotAmount,
                [RcptAmount] = @RcptAmount,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [ARecNo] = @ARecNo,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount,
                [LUT] = @LUT
                                WHERE  [RcptCode] = @RcptCode
                SET @Message=convert(varchar(20),@RcptCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [MiscRcptPmt] WHERE  [RcptCode] = @RcptCode
            SET @Message=convert(varchar(20),@RcptCode)+' Record Deleted SucessFully'
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
