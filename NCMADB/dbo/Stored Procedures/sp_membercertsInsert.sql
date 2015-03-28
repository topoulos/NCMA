CREATE PROC [dbo].[sp_membercertsInsert] 
    @MemberID int,
    @DojoID int,
    @CertificateTypeID int,
    @RankText nvarchar(MAX),
    @InstructorID int,
    @InstructorTypeID int,
    @FromDate datetime,
    @ThruDate datetime,
    @Completed bit,
    @TourneyID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[membercerts] ([MemberID], [DojoID], [CertificateTypeID], [RankText], [InstructorID], [InstructorTypeID], [FromDate], [ThruDate], [Completed], [TourneyID])
	SELECT @MemberID, @DojoID, @CertificateTypeID, @RankText, @InstructorID, @InstructorTypeID, @FromDate, @ThruDate, @Completed, @TourneyID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [MemberID], [DojoID], [CertificateTypeID], [RankText], [InstructorID], [InstructorTypeID], [FromDate], [ThruDate], [Completed], [TourneyID]
	FROM   [dbo].[membercerts]
	WHERE  [ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT