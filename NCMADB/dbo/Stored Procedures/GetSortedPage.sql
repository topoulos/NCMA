
 CREATE PROCEDURE [dbo].[GetSortedPage]( 
      @TableName VARCHAR(50), 
      @PrimaryKey VARCHAR(25), 
      @SortField VARCHAR(100), 
      @PageSize INT, 
      @PageIndex INT = 1,
      @QueryFilter VARCHAR(100) = NULL 
    ) AS 
    SET NOCOUNT ON 
    DECLARE @SizeString AS VARCHAR(5) 
    DECLARE @PrevString AS VARCHAR(5) 
    SET @SizeString = CONVERT(VARCHAR, @PageSize) 
    SET @PrevString = CONVERT(VARCHAR, @PageSize * (@PageIndex - 1)) 
    IF @QueryFilter IS NULL OR @QueryFilter = '' 
    BEGIN 
      EXEC( 
      'SELECT * FROM ' + @TableName + ' WHERE ' + @PrimaryKey + ' IN 
        (SELECT TOP ' + @SizeString + ' ' + @PrimaryKey + ' FROM ' + 
@TableName + ' WHERE ' + @PrimaryKey + ' NOT IN 
          (SELECT TOP ' + @PrevString + ' ' + @PrimaryKey + ' FROM ' + 
@TableName + ' ORDER BY ' + @SortField + ') 
        ORDER BY ' + @SortField + ') 
      ORDER BY ' + @SortField 
      ) 
      EXEC('SELECT (COUNT(*) - 1)/' + @SizeString + ' + 1 AS PageCount 
FROM ' + @TableName) 
    END 
    ELSE 
    BEGIN 
      EXEC( 
      'SELECT * FROM ' + @TableName + ' WHERE ' + @PrimaryKey + ' IN 
        (SELECT TOP ' + @SizeString + ' ' + @PrimaryKey + ' FROM ' + 
@TableName + ' WHERE ' + @QueryFilter + ' AND ' + @PrimaryKey + ' NOT 
IN 
          (SELECT TOP ' + @PrevString + ' ' + @PrimaryKey + ' FROM ' + 
@TableName + ' WHERE ' + @QueryFilter + ' ORDER BY ' + @SortField + ') 
        ORDER BY ' + @SortField + ') 
      ORDER BY ' + @SortField 
      ) 
      EXEC('SELECT (COUNT(*) - 1)/' + @SizeString + ' + 1 AS PageCount 
FROM ' + @TableName + ' WHERE ' + @QueryFilter) 
    END 
    RETURN 0