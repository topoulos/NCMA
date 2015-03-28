CREATE PROC [dbo].[sp_certtypeSelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Name], [Description], [ValidationDurationInDays] 
	FROM   [dbo].[certtype] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT