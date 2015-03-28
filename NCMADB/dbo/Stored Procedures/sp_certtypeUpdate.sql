CREATE PROC [dbo].[sp_certtypeUpdate] 
    @ID int,
    @Name varchar(255),
    @Description varchar(255),
    @ValidationDurationInDays int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[certtype]
	SET    [Name] = @Name, [Description] = @Description, [ValidationDurationInDays] = @ValidationDurationInDays
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Name], [Description], [ValidationDurationInDays]
	FROM   [dbo].[certtype]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT