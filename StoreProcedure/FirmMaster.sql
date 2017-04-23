-- Store Procedures for FirmMaster Table
 
CREATE PROC [dbo].[sprocFirmMasterInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@FirmName varchar(50) = NULL,
						@Add1 varchar(50) = NULL,
						@Add2 varchar(50) = NULL,
						@Add3 varchar(50) = NULL,
						@Area varchar(30) = NULL,
						@City varchar(20) = NULL,
						@PinCode varchar(10) = NULL,
						@KeyPerson varchar(50) = NULL,
						@PhoneNo varchar(35) = NULL,
						@Email varchar(50) = NULL,
						@VatNo varchar(20) = NULL,
						@VatDate datetime = NULL,
						@CSTVatNo varchar(20) = NULL,
						@CSTVatDate datetime = NULL,
						@DlNo1 varchar(50) = NULL,
						@DlNo2 varchar(50) = NULL,
						@RegKey varchar(25) = NULL,
						@DataPath varchar(8) = NULL,
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
                set @RecNo = (select count(*) from FirmMaster)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from FirmMaster)
                set @RecNo = @RecNo + 1
 
                insert into [FirmMaster]
                (
                    [FirmName],
                    [Add1],
                    [Add2],
                    [Add3],
                    [Area],
                    [City],
                    [PinCode],
                    [KeyPerson],
                    [PhoneNo],
                    [Email],
                    [VatNo],
                    [VatDate],
                    [CSTVatNo],
                    [CSTVatDate],
                    [DlNo1],
                    [DlNo2],
                    [RegKey],
                    [DataPath],
                    [CreatedBy],
                    [CreatedDate],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount],
                    [LUT]
                 )
                 VALUES
                 (
                    @FirmName,
                    @Add1,
                    @Add2,
                    @Add3,
                    @Area,
                    @City,
                    @PinCode,
                    @KeyPerson,
                    @PhoneNo,
                    @Email,
                    @VatNo,
                    @VatDate,
                    @CSTVatNo,
                    @CSTVatDate,
                    @DlNo1,
                    @DlNo2,
                    @RegKey,
                    @DataPath,
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
                UPDATE [FirmMaster]
                SET
                [RecNo] = @RecNo,
                [FirmName] = @FirmName,
                [Add1] = @Add1,
                [Add2] = @Add2,
                [Add3] = @Add3,
                [Area] = @Area,
                [City] = @City,
                [PinCode] = @PinCode,
                [KeyPerson] = @KeyPerson,
                [PhoneNo] = @PhoneNo,
                [Email] = @Email,
                [VatNo] = @VatNo,
                [VatDate] = @VatDate,
                [CSTVatNo] = @CSTVatNo,
                [CSTVatDate] = @CSTVatDate,
                [DlNo1] = @DlNo1,
                [DlNo2] = @DlNo2,
                [RegKey] = @RegKey,
                [DataPath] = @DataPath,
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
            DELETE FROM [FirmMaster] WHERE  [RecNo] = @RecNo
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
