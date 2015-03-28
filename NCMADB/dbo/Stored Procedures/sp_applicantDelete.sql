CREATE PROC [dbo].[sp_applicantDelete] 
    @id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[applicant]
	WHERE  [id] = @id

	COMMIT