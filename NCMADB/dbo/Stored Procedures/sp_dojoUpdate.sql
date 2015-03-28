CREATE PROC [dbo].[sp_dojoUpdate] 
    @ID int,
    @Name varchar(255),
    @Style varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[dojo]
	SET    [Name] = @Name, [Style] = @Style
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Name], [Style]
	FROM   [dbo].[dojo]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT