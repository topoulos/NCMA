CREATE PROC [dbo].[sp_countryInsert] 
    @Name varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[country] ([Name])
	SELECT @Name
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Name]
	FROM   [dbo].[country]
	WHERE  [ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT