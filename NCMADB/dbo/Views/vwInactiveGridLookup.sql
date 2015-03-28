CREATE view vwInactiveGridLookup as

SELECT     ISNULL(m.FirstName, '') + ' ' + ISNULL(m.MiddleName, '') + ' ' + ISNULL(m.LastName, '') + ' ' + ISNULL(m.Suffix, '') AS FullName, m.LastName AS Last, 
                      m.FirstName AS First, c.Name AS Country, d.Name AS Dojo, mt.Name AS MemType, st.StateAbbrev AS State, m.DateJoined, m.DateOfRank, m.Active, m.DateLastPaid, 
                      m.ID, m.RankText
FROM         dbo.dojo AS d RIGHT OUTER JOIN
                      dbo.membertype AS mt RIGHT OUTER JOIN
                      dbo.inactivemember AS m LEFT OUTER JOIN
                      dbo.state AS st ON m.StateID = st.ID ON mt.ID = m.MemberTypeID ON d.ID = m.DojoID LEFT OUTER JOIN
                      dbo.country AS c ON m.ID = c.ID