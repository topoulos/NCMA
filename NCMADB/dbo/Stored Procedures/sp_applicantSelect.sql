CREATE PROC [dbo].[sp_applicantSelect] 
    @id INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [id], [LastName], [FirstName], [MiddleName], [Suffix], [Address1], [Address2], [Address3], [City], [StateID], [CountryID], [PostalCode], [HomePhone], [CellPhone], [Email], [DOB], [PlanID], [About], [Style], [Approved], [InputIntoNCMA], [ApprovedDate], [SubmitDate], [InputIntoNCMADate], [DojoName] 
	FROM   [dbo].[applicant] 
	WHERE  ([id] = @id OR @id IS NULL) 

	COMMIT