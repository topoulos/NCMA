CREATE VIEW dbo.vwTournResult
AS
SELECT     dbo.tournresult.MemberID, dbo.tournresult.ID AS tournresultid, dbo.tournresult.TournamentID, dbo.tournresult.TournAcheivementTypeID, 
                      dbo.tournresult.TournDivisionID, dbo.tournresult.TournCompTypeID, dbo.tournament.Description, dbo.tournament.TournDate, dbo.tournament.City, 
                      dbo.vwMemberGridLookup.FullName, dbo.vwMemberGridLookup.Last, dbo.vwMemberGridLookup.First, dbo.vwMemberGridLookup.Country, 
                      dbo.vwMemberGridLookup.Dojo, dbo.vwMemberGridLookup.MemType, dbo.vwMemberGridLookup.Rank, dbo.vwMemberGridLookup.State, 
                      dbo.vwMemberGridLookup.DateJoined, dbo.vwMemberGridLookup.DateOfRank, dbo.vwMemberGridLookup.Active, dbo.vwMemberGridLookup.DateLastPaid, 
                      dbo.tourncomptype.Name AS tourncomptypename, dbo.state.StateAbbrev AS tournstate, dbo.tournachievementtype.Name AS tournachievementtypename, 
                      dbo.tournachievementtype.Description AS tournachievementtypedesc, dbo.tourndivision.Name AS tourndivisionname, 
                      dbo.tourndivision.Description AS tourndivisiondesc, dbo.tourncomptype.Description AS tourncomptypedesc
FROM         dbo.state RIGHT OUTER JOIN
                      dbo.tournament ON dbo.state.ID = dbo.tournament.StateID RIGHT OUTER JOIN
                      dbo.tournresult LEFT OUTER JOIN
                      dbo.vwMemberGridLookup ON dbo.tournresult.MemberID = dbo.vwMemberGridLookup.ID LEFT OUTER JOIN
                      dbo.tourndivision ON dbo.tournresult.TournDivisionID = dbo.tourndivision.ID LEFT OUTER JOIN
                      dbo.tourncomptype ON dbo.tournresult.TournDivisionID = dbo.tourncomptype.ID LEFT OUTER JOIN
                      dbo.tournachievementtype ON dbo.tournresult.TournAcheivementTypeID = dbo.tournachievementtype.ID ON dbo.tournament.ID = dbo.tournresult.TournamentID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwTournResult';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwTournResult';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[56] 4[5] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tournachievementtype"
            Begin Extent = 
               Top = 191
               Left = 590
               Bottom = 295
               Right = 750
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tournament"
            Begin Extent = 
               Top = 0
               Left = 595
               Bottom = 196
               Right = 755
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "tourncomptype"
            Begin Extent = 
               Top = 273
               Left = 21
               Bottom = 377
               Right = 181
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tourndivision"
            Begin Extent = 
               Top = 291
               Left = 584
               Bottom = 395
               Right = 744
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tournresult"
            Begin Extent = 
               Top = 1
               Left = 271
               Bottom = 120
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwMemberGridLookup"
            Begin Extent = 
               Top = 53
               Left = 22
               Bottom = 241
               Right = 182
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "state"
            Begin Extent = 
               Top = 56
               Left = 822
               Bottom = 160
               Right = 982
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwTournResult';

