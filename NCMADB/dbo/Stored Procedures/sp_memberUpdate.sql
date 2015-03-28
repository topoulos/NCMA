CREATE PROC [dbo].[sp_memberUpdate] 
    @ID int,
    @LastName varchar(255),
    @FirstName varchar(255),
    @MiddleName varchar(255),
    @Suffix varchar(255),
    @Address1 varchar(255),
    @Address2 varchar(255),
    @Address3 varchar(255),
    @City varchar(255),
    @StateID int,
    @CountryID int,
    @PostalCode varchar(12),
    @HomePhone varchar(20),
    @CellPhone varchar(20),
    @Email varchar(255),
    @DOB date,
    @PlanID int,
    @DojoID int,
    @MemberTypeID int,
    @DateJoined date,
    @DateOfRank date,
    @RankID int,
    @Active int,
    @DateInactive date,
    @DateLastPaid date,
    @Comments text
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[member]
	SET    [LastName] = @LastName, [FirstName] = @FirstName, [MiddleName] = @MiddleName, [Suffix] = @Suffix, [Address1] = @Address1, [Address2] = @Address2, [Address3] = @Address3, [City] = @City, [StateID] = @StateID, [CountryID] = @CountryID, [PostalCode] = @PostalCode, [HomePhone] = @HomePhone, [CellPhone] = @CellPhone, [Email] = @Email, [DOB] = @DOB, [PlanID] = @PlanID, [DojoID] = @DojoID, [MemberTypeID] = @MemberTypeID, [DateJoined] = @DateJoined, [DateOfRank] = @DateOfRank, [RankID] = @RankID, [Active] = @Active, [DateInactive] = @DateInactive, [DateLastPaid] = @DateLastPaid, [Comments] = @Comments
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [LastName], [FirstName], [MiddleName], [Suffix], [Address1], [Address2], [Address3], [City], [StateID], [CountryID], [PostalCode], [HomePhone], [CellPhone], [Email], [DOB], [PlanID], [DojoID], [MemberTypeID], [DateJoined], [DateOfRank], [RankID], [Active], [DateInactive], [DateLastPaid], [Comments]
	FROM   [dbo].[member]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT