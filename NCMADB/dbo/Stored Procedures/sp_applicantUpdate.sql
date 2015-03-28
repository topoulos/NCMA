CREATE PROC [dbo].[sp_applicantUpdate] 
    @id int,
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
    @DOB datetime2,
    @PlanID int,
    @About text,
    @Style varchar(255),
    @Approved bit,
    @InputIntoNCMA bit,
    @ApprovedDate datetime2,
    @SubmitDate datetime2,
    @InputIntoNCMADate datetime2,
    @DojoName varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[applicant]
	SET    [LastName] = @LastName, [FirstName] = @FirstName, [MiddleName] = @MiddleName, [Suffix] = @Suffix, [Address1] = @Address1, [Address2] = @Address2, [Address3] = @Address3, [City] = @City, [StateID] = @StateID, [CountryID] = @CountryID, [PostalCode] = @PostalCode, [HomePhone] = @HomePhone, [CellPhone] = @CellPhone, [Email] = @Email, [DOB] = @DOB, [PlanID] = @PlanID, [About] = @About, [Style] = @Style, [Approved] = @Approved, [InputIntoNCMA] = @InputIntoNCMA, [ApprovedDate] = @ApprovedDate, [SubmitDate] = @SubmitDate, [InputIntoNCMADate] = @InputIntoNCMADate, [DojoName] = @DojoName
	WHERE  [id] = @id
	
	-- Begin Return Select <- do not remove
	SELECT [id], [LastName], [FirstName], [MiddleName], [Suffix], [Address1], [Address2], [Address3], [City], [StateID], [CountryID], [PostalCode], [HomePhone], [CellPhone], [Email], [DOB], [PlanID], [About], [Style], [Approved], [InputIntoNCMA], [ApprovedDate], [SubmitDate], [InputIntoNCMADate], [DojoName]
	FROM   [dbo].[applicant]
	WHERE  [id] = @id	
	-- End Return Select <- do not remove

	COMMIT