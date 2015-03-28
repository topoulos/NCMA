CREATE PROC [dbo].[sp_membercertsUpdate] 
    @ID int,
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

	UPDATE [dbo].[membercerts]
	SET    [MemberID] = @MemberID, [DojoID] = @DojoID, [CertificateTypeID] = @CertificateTypeID, [RankText] = @RankText, [InstructorID] = @InstructorID, [InstructorTypeID] = @InstructorTypeID, [FromDate] = @FromDate, [ThruDate] = @ThruDate, [Completed] = @Completed, [TourneyID] = @TourneyID
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [MemberID], [DojoID], [CertificateTypeID], [RankText], [InstructorID], [InstructorTypeID], [FromDate], [ThruDate], [Completed], [TourneyID]
	FROM   [dbo].[membercerts]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT