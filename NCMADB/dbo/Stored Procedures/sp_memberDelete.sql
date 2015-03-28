CREATE PROC [dbo].[sp_memberDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[member]
	WHERE  [ID] = @ID

	COMMIT