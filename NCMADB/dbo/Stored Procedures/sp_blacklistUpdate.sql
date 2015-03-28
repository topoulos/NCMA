CREATE PROC [dbo].[sp_blacklistUpdate] 
    @ID int,
    @FormerMemberID int,
    @FirstName varchar(255),
    @LastName varchar(255),
    @Reason varchar(255),
    @DateListed datetime2
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[blacklist]
	SET    [FormerMemberID] = @FormerMemberID, [FirstName] = @FirstName, [LastName] = @LastName, [Reason] = @Reason, [DateListed] = @DateListed
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [FormerMemberID], [FirstName], [LastName], [Reason], [DateListed]
	FROM   [dbo].[blacklist]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT