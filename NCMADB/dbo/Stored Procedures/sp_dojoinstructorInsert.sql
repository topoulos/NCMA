CREATE PROC [dbo].[sp_dojoinstructorInsert] 
    @DojoID int,
    @InstructorID int,
    @InstructorTypeID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[dojoinstructor] ([DojoID], [InstructorID], [InstructorTypeID])
	SELECT @DojoID, @InstructorID, @InstructorTypeID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [DojoID], [InstructorID], [InstructorTypeID]
	FROM   [dbo].[dojoinstructor]
	WHERE  [ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT