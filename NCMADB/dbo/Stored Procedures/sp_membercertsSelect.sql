CREATE PROC [dbo].[sp_membercertsSelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [MemberID], [DojoID], [CertificateTypeID], [RankText], [InstructorID], [InstructorTypeID], [FromDate], [ThruDate], [Completed], [TourneyID] 
	FROM   [dbo].[membercerts] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT