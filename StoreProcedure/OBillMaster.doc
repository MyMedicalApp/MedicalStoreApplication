-- Store Procedures for OBillMaster Table
 
CREATE PROC [dbo].[sprocOBillMasterInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@BillTag varchar(20) = NULL,
						@BillType varchar(20) = NULL,
						@BillCredit varchar(10) = NULL,
						@BillSeries varchar(1) = NULL,
						@BillNo bigint = NULL,
						@BillDate datetime = NULL,
						@PurBillNo varchar(10) = NULL,
						@PurBillDate datetime = NULL,
						@CustomerCode bigint = NULL,
						@DoctorCode bigint = NULL,
						@AccountCode bigint = NULL,
						@SalesmanCode bigint = NULL,
						@VatInRate varchar(3) = NULL,
						@GrossAmount money = NULL,
						@SchemeRs money = NULL,
						@SplDiscRs money = NULL,
						@DiscPer money = NULL,
						@DiscRs money = NULL,
						@VatPer money = NULL,
						@VatRs money = NULL,
						@AdVatPer money = NULL,
						@AdVatRs money = NULL,
						@CrRs money = NULL,
						@OtherAdj money = NULL,
						@RndOff money = NULL,
						@NetAmount money = NULL,
						@RateTag varchar(10) = NULL,
						@OrdRef varchar(20) = NULL,
						@ModOfDespatch varchar(20) = NULL,
						@RRNo varchar(20) = NULL,
						@NoOfPack varchar(20) = NULL,
						@DespDate datetime = NULL,
						@SplInst varchar(50) = NULL,
						@RcptAmount money = NULL,
						@MiscPndAmount money = NULL,
						@AdjTag varchar(2) = NULL,
						@VarifyBy bigint = NULL,
						@VarifyDate datetime = NULL,
						@NodeName varchar(8) = NULL,
						@ShiftNo bigint = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@DueDate datetime = NULL,
						@DelBoyName bigint = NULL,
						@Narration varchar(50) = NULL,
						@LBT money = NULL,
						@LBTRs money = NULL,
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
                set @RecNo = (select count(*) from OBillMaster)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from OBillMaster)
                set @RecNo = @RecNo + 1
 
                insert into [OBillMaster]
                (
                    [BillTag],
                    [BillType],
                    [BillCredit],
                    [BillSeries],
                    [BillNo],
                    [BillDate],
                    [PurBillNo],
                    [PurBillDate],
                    [CustomerCode],
                    [DoctorCode],
                    [AccountCode],
                    [SalesmanCode],
                    [VatInRate],
                    [GrossAmount],
                    [SchemeRs],
                    [SplDiscRs],
                    [DiscPer],
                    [DiscRs],
                    [VatPer],
                    [VatRs],
                    [AdVatPer],
                    [AdVatRs],
                    [CrRs],
                    [OtherAdj],
                    [RndOff],
                    [NetAmount],
                    [RateTag],
                    [OrdRef],
                    [ModOfDespatch],
                    [RRNo],
                    [NoOfPack],
                    [DespDate],
                    [SplInst],
                    [RcptAmount],
                    [MiscPndAmount],
                    [AdjTag],
                    [VarifyBy],
                    [VarifyDate],
                    [NodeName],
                    [ShiftNo],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [DueDate],
                    [DelBoyName],
                    [Narration],
                    [LBT],
                    [LBTRs],
                    [CreatedBy],
                    [CreatedDate],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount],
                    [LUT]
                 )
                 VALUES
                 (
                    @BillTag,
                    @BillType,
                    @BillCredit,
                    @BillSeries,
                    @BillNo,
                    @BillDate,
                    @PurBillNo,
                    @PurBillDate,
                    @CustomerCode,
                    @DoctorCode,
                    @AccountCode,
                    @SalesmanCode,
                    @VatInRate,
                    @GrossAmount,
                    @SchemeRs,
                    @SplDiscRs,
                    @DiscPer,
                    @DiscRs,
                    @VatPer,
                    @VatRs,
                    @AdVatPer,
                    @AdVatRs,
                    @CrRs,
                    @OtherAdj,
                    @RndOff,
                    @NetAmount,
                    @RateTag,
                    @OrdRef,
                    @ModOfDespatch,
                    @RRNo,
                    @NoOfPack,
                    @DespDate,
                    @SplInst,
                    @RcptAmount,
                    @MiscPndAmount,
                    @AdjTag,
                    @VarifyBy,
                    @VarifyDate,
                    @NodeName,
                    @ShiftNo,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @DueDate,
                    @DelBoyName,
                    @Narration,
                    @LBT,
                    @LBTRs,
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
                UPDATE [OBillMaster]
                SET
                [RecNo] = @RecNo,
                [BillTag] = @BillTag,
                [BillType] = @BillType,
                [BillCredit] = @BillCredit,
                [BillSeries] = @BillSeries,
                [BillNo] = @BillNo,
                [BillDate] = @BillDate,
                [PurBillNo] = @PurBillNo,
                [PurBillDate] = @PurBillDate,
                [CustomerCode] = @CustomerCode,
                [DoctorCode] = @DoctorCode,
                [AccountCode] = @AccountCode,
                [SalesmanCode] = @SalesmanCode,
                [VatInRate] = @VatInRate,
                [GrossAmount] = @GrossAmount,
                [SchemeRs] = @SchemeRs,
                [SplDiscRs] = @SplDiscRs,
                [DiscPer] = @DiscPer,
                [DiscRs] = @DiscRs,
                [VatPer] = @VatPer,
                [VatRs] = @VatRs,
                [AdVatPer] = @AdVatPer,
                [AdVatRs] = @AdVatRs,
                [CrRs] = @CrRs,
                [OtherAdj] = @OtherAdj,
                [RndOff] = @RndOff,
                [NetAmount] = @NetAmount,
                [RateTag] = @RateTag,
                [OrdRef] = @OrdRef,
                [ModOfDespatch] = @ModOfDespatch,
                [RRNo] = @RRNo,
                [NoOfPack] = @NoOfPack,
                [DespDate] = @DespDate,
                [SplInst] = @SplInst,
                [RcptAmount] = @RcptAmount,
                [MiscPndAmount] = @MiscPndAmount,
                [AdjTag] = @AdjTag,
                [VarifyBy] = @VarifyBy,
                [VarifyDate] = @VarifyDate,
                [NodeName] = @NodeName,
                [ShiftNo] = @ShiftNo,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [DueDate] = @DueDate,
                [DelBoyName] = @DelBoyName,
                [Narration] = @Narration,
                [LBT] = @LBT,
                [LBTRs] = @LBTRs,
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
            DELETE FROM [OBillMaster] WHERE  [RecNo] = @RecNo
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
