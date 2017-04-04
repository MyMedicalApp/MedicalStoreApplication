-- Store Procedures for PrintFormat Table
 
CREATE PROC [dbo].[sprocPrintFormatInsertUpdateSingleItem] 
						@RecNo bigint = NULL,
						@LabelType varchar(50) = NULL,
						@OprtSys varchar(50) = NULL,
						@FormatName varchar(50) = NULL,
						@PrinterName varchar(50) = NULL,
						@TxtType varchar(50) = NULL,
						@SampleTxt varchar(200) = NULL,
						@FPrefix varchar(50) = NULL,
						@FldName varchar(50) = NULL,
						@FSufix varchar(50) = NULL,
						@PrntFormat varchar(50) = NULL,
						@PosX bigint = NULL,
						@PosY bigint = NULL,
						@PWidth bigint = NULL,
						@PHeight bigint = NULL,
						@FntName varchar(50) = NULL,
						@FntStyle varchar(50) = NULL,
						@FntBold varchar(3) = NULL,
						@FntItalic varchar(3) = NULL,
						@FntStrikout varchar(3) = NULL,
						@FntUnderLine varchar(3) = NULL,
						@FntSize bigint = NULL,
						@FntColor bigint = NULL,
						@AcrossLbl bigint = NULL,
						@PgLbl bigint = NULL,
						@DuplicateLbl varchar(3) = NULL,
						@PgTopMargin bigint = NULL,
						@PgLeftMargin bigint = NULL,
						@LblVerticalGap bigint = NULL,
						@LblHorizontalGap bigint = NULL,
						@LblWidth bigint = NULL,
						@LblHeight bigint = NULL,
						@NoOfLine bigint = NULL,
						@GapLine bigint = NULL,
						@CUser bigint = NULL,
						@CDateTime datetime = NULL,
						@EUser bigint = NULL,
						@EDateTime datetime = NULL,
						@PrintStyle varchar(50) = NULL,
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
                set @RecNo = (select count(*) from PrintFormat)
                if @RecNo  <> 0
                    set @RecNo = (select max(RecNo) from PrintFormat)
                set @RecNo = @RecNo + 1
 
                insert into [PrintFormat]
                (
                    [LabelType],
                    [OprtSys],
                    [FormatName],
                    [PrinterName],
                    [TxtType],
                    [SampleTxt],
                    [FPrefix],
                    [FldName],
                    [FSufix],
                    [PrntFormat],
                    [PosX],
                    [PosY],
                    [PWidth],
                    [PHeight],
                    [FntName],
                    [FntStyle],
                    [FntBold],
                    [FntItalic],
                    [FntStrikout],
                    [FntUnderLine],
                    [FntSize],
                    [FntColor],
                    [AcrossLbl],
                    [PgLbl],
                    [DuplicateLbl],
                    [PgTopMargin],
                    [PgLeftMargin],
                    [LblVerticalGap],
                    [LblHorizontalGap],
                    [LblWidth],
                    [LblHeight],
                    [NoOfLine],
                    [GapLine],
                    [CUser],
                    [CDateTime],
                    [EUser],
                    [EDateTime],
                    [PrintStyle],
                    [CreatedBy],
                    [CreatedDate],
                    [UpdateddBy],
                    [UpdatedDate],
                    [UpdatedCount],
                    [LUT]
                 )
                 VALUES
                 (
                    @LabelType,
                    @OprtSys,
                    @FormatName,
                    @PrinterName,
                    @TxtType,
                    @SampleTxt,
                    @FPrefix,
                    @FldName,
                    @FSufix,
                    @PrntFormat,
                    @PosX,
                    @PosY,
                    @PWidth,
                    @PHeight,
                    @FntName,
                    @FntStyle,
                    @FntBold,
                    @FntItalic,
                    @FntStrikout,
                    @FntUnderLine,
                    @FntSize,
                    @FntColor,
                    @AcrossLbl,
                    @PgLbl,
                    @DuplicateLbl,
                    @PgTopMargin,
                    @PgLeftMargin,
                    @LblVerticalGap,
                    @LblHorizontalGap,
                    @LblWidth,
                    @LblHeight,
                    @NoOfLine,
                    @GapLine,
                    @CUser,
                    @CDateTime,
                    @EUser,
                    @EDateTime,
                    @PrintStyle,
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
                UPDATE [PrintFormat]
                SET
                [RecNo] = @RecNo,
                [LabelType] = @LabelType,
                [OprtSys] = @OprtSys,
                [FormatName] = @FormatName,
                [PrinterName] = @PrinterName,
                [TxtType] = @TxtType,
                [SampleTxt] = @SampleTxt,
                [FPrefix] = @FPrefix,
                [FldName] = @FldName,
                [FSufix] = @FSufix,
                [PrntFormat] = @PrntFormat,
                [PosX] = @PosX,
                [PosY] = @PosY,
                [PWidth] = @PWidth,
                [PHeight] = @PHeight,
                [FntName] = @FntName,
                [FntStyle] = @FntStyle,
                [FntBold] = @FntBold,
                [FntItalic] = @FntItalic,
                [FntStrikout] = @FntStrikout,
                [FntUnderLine] = @FntUnderLine,
                [FntSize] = @FntSize,
                [FntColor] = @FntColor,
                [AcrossLbl] = @AcrossLbl,
                [PgLbl] = @PgLbl,
                [DuplicateLbl] = @DuplicateLbl,
                [PgTopMargin] = @PgTopMargin,
                [PgLeftMargin] = @PgLeftMargin,
                [LblVerticalGap] = @LblVerticalGap,
                [LblHorizontalGap] = @LblHorizontalGap,
                [LblWidth] = @LblWidth,
                [LblHeight] = @LblHeight,
                [NoOfLine] = @NoOfLine,
                [GapLine] = @GapLine,
                [CUser] = @CUser,
                [CDateTime] = @CDateTime,
                [EUser] = @EUser,
                [EDateTime] = @EDateTime,
                [PrintStyle] = @PrintStyle,
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
            DELETE FROM [PrintFormat] WHERE  [RecNo] = @RecNo
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
