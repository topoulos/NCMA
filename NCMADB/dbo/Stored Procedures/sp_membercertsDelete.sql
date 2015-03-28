CREATE PROC [dbo].[sp_membercertsDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[membercerts]
	WHERE  [ID] = @ID

	COMMIT