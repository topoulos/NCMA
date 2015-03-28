CREATE PROC [dbo].[sp_dojoinstructorUpdate] 
    @ID int,
    @DojoID int,
    @InstructorID int,
    @InstructorTypeID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[dojoinstructor]
	SET    [DojoID] = @DojoID, [InstructorID] = @InstructorID, [InstructorTypeID] = @InstructorTypeID
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [DojoID], [InstructorID], [InstructorTypeID]
	FROM   [dbo].[dojoinstructor]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT