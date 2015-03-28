CREATE PROC [dbo].[sp_countryUpdate] 
    @ID int,
    @Name varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[country]
	SET    [Name] = @Name
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Name]
	FROM   [dbo].[country]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT