-- Store Procedures for AddressBook Table
 
CREATE PROC [dbo].[sprocAddressBookInsertUpdateSingleItem] 
						@AddCode bigint = NULL,
						@AddName varchar(50) = NULL,
						@ContactPerson varchar(50) = NULL,
						@Add1 varchar(50) = NULL,
						@Add2 varchar(50) = NULL,
						@Add3 varchar(50) = NULL,
						@CityName varchar(20) = NULL,
						@PinCode varchar(10) = NULL,
						@Phone1 varchar(30) = NULL,
						@Phone2 varchar(30) = NULL,
						@Fax varchar(30) = NULL,
						@Email varchar(30) = NULL,
						@Category varchar(50) = NULL,
						@RelWith varchar(50) = NULL,
						@AddNote varchar(200) = NULL,
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
                set @AddCode = (select count(*) from AddressBook)
                if @AddCode  <> 0
                    set @AddCode = (select max(AddCode) from AddressBook)
                set @AddCode = @AddCode + 1
 
                insert into [AddressBook]
                (
                    [AddName],
                    [ContactPerson],
                    [Add1],
                    [Add2],
                    [Add3],
                    [CityName],
                    [PinCode],
                    [Phone1],
                    [Phone2],
                    [Fax],
                    [Email],
                    [Category],
                    [RelWith],
                    [AddNote],
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
                    @ContactPerson,
                    @Add1,
                    @Add2,
                    @Add3,
                    @CityName,
                    @PinCode,
                    @Phone1,
                    @Phone2,
                    @Fax,
                    @Email,
                    @Category,
                    @RelWith,
                    @AddNote,
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
                SET @Message=convert(varchar(20),@AddCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [AddressBook]
                SET
                [AddCode] = @AddCode,
                [AddName] = @AddName,
                [ContactPerson] = @ContactPerson,
                [Add1] = @Add1,
                [Add2] = @Add2,
                [Add3] = @Add3,
                [CityName] = @CityName,
                [PinCode] = @PinCode,
                [Phone1] = @Phone1,
                [Phone2] = @Phone2,
                [Fax] = @Fax,
                [Email] = @Email,
                [Category] = @Category,
                [RelWith] = @RelWith,
                [AddNote] = @AddNote,
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
                                WHERE  [AddCode] = @AddCode
                SET @Message=convert(varchar(20),@AddCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [AddressBook] WHERE  [AddCode] = @AddCode
            SET @Message=convert(varchar(20),@AddCode)+' Record Deleted SucessFully'
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
