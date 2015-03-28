CREATE PROC [dbo].[sp_memberSelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [LastName], [FirstName], [MiddleName], [Suffix], [Address1], [Address2], [Address3], [City], [StateID], [CountryID], [PostalCode], [HomePhone], [CellPhone], [Email], [DOB], [PlanID], [DojoID], [MemberTypeID], [DateJoined], [DateOfRank], [RankID], [Active], [DateInactive], [DateLastPaid], [Comments] 
	FROM   [dbo].[member] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT