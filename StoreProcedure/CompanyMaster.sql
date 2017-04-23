-- Store Procedures for CompanyMaster Table
 
CREATE PROC [dbo].[sprocCompanyMasterInsertUpdateSingleItem] 
						@CompanyCode bigint = NULL,
						@ICode varchar(13) = NULL,
						@CompanyName varchar(50) = NULL,
						@CompanyTag varchar(10) = NULL,
						@Add1 varchar(50) = NULL,
						@Add2 varchar(50) = NULL,
						@Add3 varchar(50) = NULL,
						@CutExp varchar(3) = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@LCode bigint = NULL,
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
                set @CompanyCode = (select count(*) from CompanyMaster)
                if @CompanyCode  <> 0
                    set @CompanyCode = (select max(CompanyCode) from CompanyMaster)
                set @CompanyCode = @CompanyCode + 1
 
                insert into [CompanyMaster]
                (
                    [ICode],
                    [CompanyName],
                    [CompanyTag],
                    [Add1],
                    [Add2],
                    [Add3],
                    [CutExp],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [LCode],
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
                    @CompanyName,
                    @CompanyTag,
                    @Add1,
                    @Add2,
                    @Add3,
                    @CutExp,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @LCode,
                    @DLock,
                    @CreatedBy,
                    @CreatedDate,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount,
                    @LUT
                  )
                SET @Message=convert(varchar(20),@CompanyCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [CompanyMaster]
                SET
                [CompanyCode] = @CompanyCode,
                [ICode] = @ICode,
                [CompanyName] = @CompanyName,
                [CompanyTag] = @CompanyTag,
                [Add1] = @Add1,
                [Add2] = @Add2,
                [Add3] = @Add3,
                [CutExp] = @CutExp,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [LCode] = @LCode,
                [DLock] = @DLock,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount,
                [LUT] = @LUT
                                WHERE  [CompanyCode] = @CompanyCode
                SET @Message=convert(varchar(20),@CompanyCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [CompanyMaster] WHERE  [CompanyCode] = @CompanyCode
            SET @Message=convert(varchar(20),@CompanyCode)+' Record Deleted SucessFully'
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
