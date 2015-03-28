CREATE PROC [dbo].[sp_blacklistDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[blacklist]
	WHERE  [ID] = @ID

	COMMIT