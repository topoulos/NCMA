CREATE PROC [dbo].[sp_blacklistSelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [FormerMemberID], [FirstName], [LastName], [Reason], [DateListed] 
	FROM   [dbo].[blacklist] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT