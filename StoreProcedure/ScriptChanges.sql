

CREATE PROC [dbo].[sprocGetBatchMasterByProductCode] 
						@ProductCode varchar(100) = NULL
AS 
BEGIN 
 
select * from BatchMaster bm
inner join ProductMaster pm on bm.ProductCode = pm.ProductCode
where pm.ProductCode = '22209'

END

GO


CREATE PROC [dbo].[sprocGetAllListProduct]
@ProductCode varchar(100)
AS 
BEGIN 
 
select top 100 * from ProductMaster 

END

GO


