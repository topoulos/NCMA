CREATE PROC [dbo].[sp_dojoInsert] 
    @Name varchar(255),
    @Style varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[dojo] ([Name], [Style])
	SELECT @Name, @Style
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Name], [Style]
	FROM   [dbo].[dojo]
	WHERE  [ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT