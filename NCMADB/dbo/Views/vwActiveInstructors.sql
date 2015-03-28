/****** Script for SelectTopNRows command from SSMS  ******/
CREATE view vwActiveInstructors as
SELECT     m.LastName + ', ' + m.FirstName AS FullName, m.LastName AS Last, m.FirstName AS First, c.Name AS Country, d.Name AS Dojo, mt.Name AS MemType, 
                      r.Name AS Rank, st.StateAbbrev AS State, m.DateJoined, m.DateOfRank, m.Active, m.DateLastPaid, m.ID
FROM         dbo.dojo AS d RIGHT OUTER JOIN
                      dbo.membertype AS mt RIGHT OUTER JOIN
                      dbo.member AS m LEFT OUTER JOIN
                      dbo.state AS st ON m.StateID = st.ID ON mt.ID = m.MemberTypeID ON d.ID = m.DojoID LEFT OUTER JOIN
                      dbo.country AS c ON m.ID = c.ID LEFT OUTER JOIN
                      dbo.rank AS r ON m.RankID = r.ID
WHERE     (m.MemberTypeID > 2) and m.Active = 1