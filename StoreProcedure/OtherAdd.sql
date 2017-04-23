-- Store Procedures for OtherAdd Table
 
CREATE PROC [dbo].[sprocOtherAddInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@AddName varchar(50) = NULL,
						@KeyPerson varchar(50) = NULL,
						@Address1 varchar(50) = NULL,
						@Address2 varchar(50) = NULL,
						@Address3 varchar(50) = NULL,
						@City varchar(50) = NULL,
						@Mobile varchar(50) = NULL,
						@Phone1 varchar(50) = NULL,
						@Phone2 varchar(50) = NULL,
						@PhoneR varchar(50) = NULL,
						@Fax varchar(50) = NULL,
						@Email varchar(50) = NULL,
						@Category varchar(50) = NULL,
						@AddNote varchar(200) = NULL,
						@ImageName varchar(250) = NULL,
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
                set @RecNo = (select count(*) from OtherAdd)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from OtherAdd)
                set @RecNo = @RecNo + 1
 
                insert into [OtherAdd]
                (
                    [AddName],
                    [KeyPerson],
                    [Address1],
                    [Address2],
                    [Address3],
                    [City],
                    [Mobile],
                    [Phone1],
                    [Phone2],
                    [PhoneR],
                    [Fax],
                    [Email],
                    [Category],
                    [AddNote],
                    [ImageName],
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
                    @AddName,
                    @KeyPerson,
                    @Address1,
                    @Address2,
                    @Address3,
                    @City,
                    @Mobile,
                    @Phone1,
                    @Phone2,
                    @PhoneR,
                    @Fax,
                    @Email,
                    @Category,
                    @AddNote,
                    @ImageName,
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
                SET @Message=convert(varchar(20),@RecNo)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [OtherAdd]
                SET
                [RecNo] = @RecNo,
                [AddName] = @AddName,
                [KeyPerson] = @KeyPerson,
                [Address1] = @Address1,
                [Address2] = @Address2,
                [Address3] = @Address3,
                [City] = @City,
                [Mobile] = @Mobile,
                [Phone1] = @Phone1,
                [Phone2] = @Phone2,
                [PhoneR] = @PhoneR,
                [Fax] = @Fax,
                [Email] = @Email,
                [Category] = @Category,
                [AddNote] = @AddNote,
                [ImageName] = @ImageName,
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
                                WHERE  [RecNo] = @RecNo
                SET @Message=convert(varchar(20),@RecNo)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [OtherAdd] WHERE  [RecNo] = @RecNo
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
