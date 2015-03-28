CREATE PROC [dbo].[sp_certtypeInsert] 
    @Name varchar(255),
    @Description varchar(255),
    @ValidationDurationInDays int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[certtype] ([Name], [Description], [ValidationDurationInDays])
	SELECT @Name, @Description, @ValidationDurationInDays
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Name], [Description], [ValidationDurationInDays]
	FROM   [dbo].[certtype]
	WHERE  [ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT