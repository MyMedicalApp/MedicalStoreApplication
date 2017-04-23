

create PROC [dbo].[sprocGetAllListProduct]
@ProductCode varchar(100)
AS 
BEGIN 
 
select pm.* from BatchMaster bm
inner join ProductMaster pm on bm.ProductCode = pm.ProductCode

END


GO


CREATE PROC [dbo].[sprocGetBatchMasterByProductCode] 
						@ProductCode varchar(100) = NULL
AS 
BEGIN 
 
select * from BatchMaster bm
inner join ProductMaster pm on bm.ProductCode = pm.ProductCode
where pm.ProductCode = @ProductCode

END

GO


