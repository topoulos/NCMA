CREATE PROC [dbo].[sp_applicantInsert] 
    @ID int,
    @LastName varchar(max),
    @FirstName varchar(max),
    @MiddleName varchar(max),
    @Suffix varchar(max),
    @Address1 varchar(max),
    @Address2 varchar(max),
    @Address3 varchar(max),
    @City varchar(max),
    @StateID int,
    @CountryID int,
    @PostalCode varchar(max),
    @HomePhone varchar(max),
    @CellPhone varchar(max),
    @Email varchar(max),
    @DOB datetime,
    @PlanID int,
    @DojoID int,
    @MemberTypeID int,
    @DateJoined datetime,
    @DateOfRank datetime,
    @RankID int,
    @Active int,
    @DateInactive datetime,
    @DateLastPaid datetime,
    @Comments varchar(max) AS 
SET NOCOUNT ON 
SET XACT_ABORT ON  

BEGIN TRAN

INSERT INTO [dbo].[member]([ID], [LastName], [FirstName], [MiddleName], [Suffix], [Address1], [Address2], [Address3], [City], [StateID], [CountryID], [PostalCode], [HomePhone], [CellPhone], [Email], [DOB], [PlanID], [DojoID], [MemberTypeID], [DateJoined], [DateOfRank], [RankID], [Active], [DateInactive], [DateLastPaid], [Comments])
SELECT @ID, @LastName, @FirstName, @MiddleName, @Suffix, @Address1, @Address2, @Address3, @City, @StateID, @CountryID, @PostalCode, @HomePhone, @CellPhone, @Email, @DOB, @PlanID, @DojoID, @MemberTypeID, @DateJoined, @DateOfRank, @RankID, @Active, @DateInactive, @DateLastPaid, @Comments

SELECT [ID], [LastName], [FirstName], [MiddleName], [Suffix], [Address1], [Address2], [Address3], [City], [StateID], [CountryID], [PostalCode], [HomePhone], [CellPhone], [Email], [DOB], [PlanID], [DojoID], [MemberTypeID], [DateJoined], [DateOfRank], [RankID], [Active], [DateInactive], [DateLastPaid], [Comments]
FROM   [dbo].[member]
WHERE  [ID] = SCOPE_IDENTITY()
               
COMMIT