CREATE PROC [dbo].[sp_dojoinstructorDelete] 
    @ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[dojoinstructor]
	WHERE  [ID] = @ID

	COMMIT