CREATE PROC [dbo].[sp_dojoSelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Name], [Style] 
	FROM   [dbo].[dojo] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT