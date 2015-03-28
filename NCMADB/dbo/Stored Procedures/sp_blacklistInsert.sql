CREATE PROC [dbo].[sp_blacklistInsert] 
    @FormerMemberID int,
    @FirstName varchar(255),
    @LastName varchar(255),
    @Reason varchar(255),
    @DateListed datetime2
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[blacklist] ([FormerMemberID], [FirstName], [LastName], [Reason], [DateListed])
	SELECT @FormerMemberID, @FirstName, @LastName, @Reason, @DateListed
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [FormerMemberID], [FirstName], [LastName], [Reason], [DateListed]
	FROM   [dbo].[blacklist]
	WHERE  [ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT