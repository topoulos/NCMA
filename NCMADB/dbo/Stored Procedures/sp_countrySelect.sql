CREATE PROC [dbo].[sp_countrySelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Name] 
	FROM   [dbo].[country] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT