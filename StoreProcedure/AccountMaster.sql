-- Store Procedures for AccountMaster Table
 
CREATE PROC [dbo].[sprocAccountMasterInsertUpdateSingleItem] 
						@AccountCode bigint = NULL,
						@ICode varchar(13) = NULL,
						@AccountName varchar(50) = NULL,
						@Add1 varchar(50) = NULL,
						@Add2 varchar(50) = NULL,
						@Add3 varchar(50) = NULL,
						@Add4 varchar(50) = NULL,
						@CityCode bigint = NULL,
						@ContactPerson varchar(50) = NULL,
						@Phone1 varchar(50) = NULL,
						@Phone2 varchar(50) = NULL,
						@Email varchar(50) = NULL,
						@DLNo1 varchar(50) = NULL,
						@DLNo2 varchar(50) = NULL,
						@VatTin varchar(50) = NULL,
						@VatDate datetime = NULL,
						@CSTVat varchar(50) = NULL,
						@CSTVatDate datetime = NULL,
						@CashDiscount money = NULL,
						@BillSeries varchar(20) = NULL,
						@BillType varchar(20) = NULL,
						@AccountType varchar(50) = NULL,
						@GroupCode bigint = NULL,
						@VisitDay varchar(21) = NULL,
						@InfoID varchar(10) = NULL,
						@OpBalAmount money = NULL,
						@OpSetAmount money = NULL,
						@BalAmount money = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@LCode bigint = NULL,
						@DLock varchar(3) = NULL,
						@ChequeName varchar(50) = NULL,
						@LBT money = NULL,
						@LBTNo varchar(50) = NULL,
						@LBTCat varchar(50) = NULL,
						@DueDay money = NULL,
						@MailFormat varchar(50) = NULL,
						@CreatedBy varchar(50) = NULL,
						@CreatedDate datetime = NULL,
						@LUT datetime = NULL,
						@UpdateddBy varchar(50) = NULL,
						@UpdatedDate datetime = NULL,
						@UpdatedCount int = NULL,
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
                set @AccountCode = (select count(*) from AccountMaster)
                if @AccountCode  <> 0
                    set @AccountCode = (select max(AccountCode) from AccountMaster)
                set @AccountCode = @AccountCode + 1
 
                insert into [AccountMaster]
                (
                    [ICode],
                    [AccountName],
                    [Add1],
                    [Add2],
                    [Add3],
                    [Add4],
                    [CityCode],
                    [ContactPerson],
                    [Phone1],
                    [Phone2],
                    [Email],
                    [DLNo1],
                    [DLNo2],
                    [VatTin],
                    [VatDate],
                    [CSTVat],
                    [CSTVatDate],
                    [CashDiscount],
                    [BillSeries],
                    [BillType],
                    [AccountType],
                    [GroupCode],
                    [VisitDay],
                    [InfoID],
                    [OpBalAmount],
                    [OpSetAmount],
                    [BalAmount],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [LCode],
                    [DLock],
                    [ChequeName],
                    [LBT],
                    [LBTNo],
                    [LBTCat],
                    [DueDay],
                    [MailFormat],
                    [CreatedBy],
                    [CreatedDate],
                    [LUT],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount]
                 )
                 VALUES
                 (
                    @ICode,
                    @AccountName,
                    @Add1,
                    @Add2,
                    @Add3,
                    @Add4,
                    @CityCode,
                    @ContactPerson,
                    @Phone1,
                    @Phone2,
                    @Email,
                    @DLNo1,
                    @DLNo2,
                    @VatTin,
                    @VatDate,
                    @CSTVat,
                    @CSTVatDate,
                    @CashDiscount,
                    @BillSeries,
                    @BillType,
                    @AccountType,
                    @GroupCode,
                    @VisitDay,
                    @InfoID,
                    @OpBalAmount,
                    @OpSetAmount,
                    @BalAmount,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @LCode,
                    @DLock,
                    @ChequeName,
                    @LBT,
                    @LBTNo,
                    @LBTCat,
                    @DueDay,
                    @MailFormat,
                    @CreatedBy,
                    @CreatedDate,
                    @LUT,
                    @UpdateddBy,
                    @UpdatedDate,
                    @UpdatedCount
                  )
                SET @Message=convert(varchar(20),@AccountCode)+' Record Inserted SucessFully'
        END
        ELSE IF (@OperationFlag = 1)
        BEGIN
                UPDATE [AccountMaster]
                SET
                [AccountCode] = @AccountCode,
                [ICode] = @ICode,
                [AccountName] = @AccountName,
                [Add1] = @Add1,
                [Add2] = @Add2,
                [Add3] = @Add3,
                [Add4] = @Add4,
                [CityCode] = @CityCode,
                [ContactPerson] = @ContactPerson,
                [Phone1] = @Phone1,
                [Phone2] = @Phone2,
                [Email] = @Email,
                [DLNo1] = @DLNo1,
                [DLNo2] = @DLNo2,
                [VatTin] = @VatTin,
                [VatDate] = @VatDate,
                [CSTVat] = @CSTVat,
                [CSTVatDate] = @CSTVatDate,
                [CashDiscount] = @CashDiscount,
                [BillSeries] = @BillSeries,
                [BillType] = @BillType,
                [AccountType] = @AccountType,
                [GroupCode] = @GroupCode,
                [VisitDay] = @VisitDay,
                [InfoID] = @InfoID,
                [OpBalAmount] = @OpBalAmount,
                [OpSetAmount] = @OpSetAmount,
                [BalAmount] = @BalAmount,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [LCode] = @LCode,
                [DLock] = @DLock,
                [ChequeName] = @ChequeName,
                [LBT] = @LBT,
                [LBTNo] = @LBTNo,
                [LBTCat] = @LBTCat,
                [DueDay] = @DueDay,
                [MailFormat] = @MailFormat,
                [CreatedBy] = @CreatedBy,
                [CreatedDate] = @CreatedDate,
                [LUT] = @LUT,
                [UpdateddBy] = @UpdateddBy,
                [UpdatedDate] = @UpdatedDate,
                [UpdatedCount] = @UpdatedCount
                                WHERE  [AccountCode] = @AccountCode
                SET @Message=convert(varchar(20),@AccountCode)+' Record Update SucessFully'
        END
        ELSE IF (@OperationFlag = 2)
        BEGIN
            DELETE FROM [AccountMaster] WHERE  [AccountCode] = @AccountCode
            SET @Message=convert(varchar(20),@AccountCode)+' Record Deleted SucessFully'
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
