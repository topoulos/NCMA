CREATE PROC [dbo].[sp_dojoDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[dojo]
	WHERE  [ID] = @ID

	COMMIT