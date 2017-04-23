-- Store Procedures for dtproperties Table
 
CREATE PROC [dbo].[sprocdtpropertiesInsertUpdateSingleItem] 
						@id int = NULL,
						@objectid int = NULL,
						@property varchar(64) = NULL,
						@value varchar(255) = NULL,
						@uvalue nvarchar = NULL,
						@lvalue image = NULL,
						@version int = NULL,
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
                set @id = (select count(*) from dtproperties)
                if @id  <> 0
                    set @id = (select max(id) from dtproperties)
                set @id = @id + 1
 
                insert into [dtproperties]
                (
                    [objectid],
                    [property],
                    [value],
                    [uvalue],
                    [lvalue],
                    [version]
                 )
                 VALUES
                 (
                    @objectid,
                    @property,
                    @value,
                    @uvalue,
                    @lvalue,
                    @version
                  )
                SET @Message=convert(varchar(20),@id)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [dtproperties]
                SET
                [id] = @id,
                [objectid] = @objectid,
                [value] = @value,
                [uvalue] = @uvalue,
                [lvalue] = @lvalue,
                [version] = @version
                                WHERE  [id] = @id
                SET @Message=convert(varchar(20),@id)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [dtproperties] WHERE  [id] = @id
            SET @Message=convert(varchar(20),@id)+' Record Deleted SucessFully'
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
