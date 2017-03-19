-- Store Procedures for T_ErrorDesc Table
 
CREATE PROC [dbo].[sprocErrorDescInsertUpdateSingleItem] 
						@ErrorId int = NULL,
						@CategoryID int = NULL,
						@PageCode int = NULL,
						@MethodCode int = NULL,
						@EventCode int = NULL,
						@ErrorLineNo int = NULL,
						@MethodTrace varchar(100) = NULL,
						@EmpNo varchar(50) = NULL,
						@ClientIpAddress varchar(30) = NULL,
						@PageName varchar(100) = NULL,
						@MethodName varchar(100) = NULL,
						@ErrorMsg varchar(1000) = NULL,
						@ErrorDate datetime = NULL,
						@ErrorData varchar(max) = NULL,
						@ErrorType varchar(100) = NULL,
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
                set @ErrorId = (select count(*) from T_ErrorDesc)
                if @ErrorId  <> 0
                    set @ErrorId = (select max(ErrorId) from T_ErrorDesc)
                set @ErrorId = @ErrorId + 1
 
                insert into [T_ErrorDesc]
                (
                    [CategoryID],
                    [PageCode],
                    [MethodCode],
                    [EventCode],
                    [ErrorLineNo],
                    [MethodTrace],
                    [EmpNo],
                    [ClientIpAddress],
                    [PageName],
                    [MethodName],
                    [ErrorMsg],
                    [ErrorDate],
                    [ErrorData],
                    [ErrorType]
                 )
                 VALUES
                 (
                    @CategoryID,
                    @PageCode,
                    @MethodCode,
                    @EventCode,
                    @ErrorLineNo,
                    @MethodTrace,
                    @EmpNo,
                    @ClientIpAddress,
                    @PageName,
                    @MethodName,
                    @ErrorMsg,
                    @ErrorDate,
                    @ErrorData,
                    @ErrorType
                  )
                SET @Message=convert(varchar(20),@ErrorId)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [T_ErrorDesc]
                SET
                [CategoryID] = @CategoryID,
                [PageCode] = @PageCode,
                [MethodCode] = @MethodCode,
                [EventCode] = @EventCode,
                [ErrorLineNo] = @ErrorLineNo,
                [MethodTrace] = @MethodTrace,
                [EmpNo] = @EmpNo,
                [ClientIpAddress] = @ClientIpAddress,
                [PageName] = @PageName,
                [MethodName] = @MethodName,
                [ErrorMsg] = @ErrorMsg,
                [ErrorDate] = @ErrorDate,
                [ErrorData] = @ErrorData,
                [ErrorType] = @ErrorType
                                WHERE  [ErrorId] = @ErrorId
                SET @Message=convert(varchar(20),@ErrorId)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [T_ErrorDesc] WHERE  [ErrorId] = @ErrorId
            SET @Message=convert(varchar(20),@ErrorId)+' Record Deleted SucessFully'
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
    END CATCH
    ENDPROC:
    print @Message
END
