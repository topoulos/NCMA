
CREATE VIEW [dbo].[vwMemberLookups]
AS
SELECT     TOP (100) PERCENT ID, LastName, ISNULL(LastName, '') + ', ' + ISNULL(FirstName, '') + ' ' + ISNULL(MiddleName, '') AS FullName
FROM         dbo.member
ORDER BY LastName