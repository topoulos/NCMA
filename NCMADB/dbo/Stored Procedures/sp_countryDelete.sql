CREATE PROC [dbo].[sp_countryDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[country]
	WHERE  [ID] = @ID

	COMMIT