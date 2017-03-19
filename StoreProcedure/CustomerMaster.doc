-- Store Procedures for CustomerMaster Table
 
CREATE PROC [dbo].[sprocCustomerMasterInsertUpdateSingleItem] 
						@CustomerCode bigint = NULL,
						@ICode varchar(13) = NULL,
						@CustomerName varchar(50) = NULL,
						@Add1 varchar(50) = NULL,
						@Phone1 varchar(50) = NULL,
						@Email varchar(50) = NULL,
						@DoctorCode bigint = NULL,
						@MemberCode varchar(20) = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@LCode bigint = NULL,
						@DLock varchar(3) = NULL,
						@CashDiscount money = NULL,
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
                set @CustomerCode = (select count(*) from CustomerMaster)
                if @CustomerCode  <> 0
                    set @CustomerCode = (select max(CustomerCode) from CustomerMaster)
                set @CustomerCode = @CustomerCode + 1
 
                insert into [CustomerMaster]
                (
                    [ICode],
                    [CustomerName],
                    [Add1],
                    [Phone1],
                    [Email],
                    [DoctorCode],
                    [MemberCode],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [LCode],
                    [DLock],
                    [CashDiscount],
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
                    @CustomerName,
                    @Add1,
                    @Phone1,
                    @Email,
                    @DoctorCode,
                    @MemberCode,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @LCode,
                    @DLock,
                    @CashDiscount,
                    @CreatedBy,
                    @CreatedDate,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount,
                    @LUT
                  )
                SET @Message=convert(varchar(20),@CustomerCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [CustomerMaster]
                SET
                [CustomerCode] = @CustomerCode,
                [ICode] = @ICode,
                [CustomerName] = @CustomerName,
                [Add1] = @Add1,
                [Phone1] = @Phone1,
                [Email] = @Email,
                [DoctorCode] = @DoctorCode,
                [MemberCode] = @MemberCode,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [LCode] = @LCode,
                [DLock] = @DLock,
                [CashDiscount] = @CashDiscount,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount,
                [LUT] = @LUT
                                WHERE  [CustomerCode] = @CustomerCode
                SET @Message=convert(varchar(20),@CustomerCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [CustomerMaster] WHERE  [CustomerCode] = @CustomerCode
            SET @Message=convert(varchar(20),@CustomerCode)+' Record Deleted SucessFully'
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
