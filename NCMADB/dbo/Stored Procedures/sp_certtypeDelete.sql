CREATE PROC [dbo].[sp_certtypeDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[certtype]
	WHERE  [ID] = @ID

	COMMIT