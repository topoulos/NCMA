CREATE PROC [dbo].[sp_dojoinstructorSelect] 
    @ID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [DojoID], [InstructorID], [InstructorTypeID] 
	FROM   [dbo].[dojoinstructor] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT