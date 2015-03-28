CREATE VIEW dbo.vwCertificates
AS
SELECT     ISNULL(m.FirstName, '') + ' ' + ISNULL(m.MiddleName, '') + ' ' + ISNULL(m.LastName, '') + ' ' + ISNULL(m.Suffix, '') AS FullName, ISNULL(m2.FirstName, '') 
                      + ' ' + ISNULL(m2.MiddleName, '') + ' ' + ISNULL(m2.LastName, '') + ' ' + ISNULL(m2.Suffix, '') AS InstructorsName, d.Name AS Dojo, mc.RankText, 
                      it.InstructorTypeName AS InstructorType, ct.Name AS CertType, tn.TournDate AS TournamentDate, mc.FromDate, mc.ThruDate, mc.ID, mc.Completed, 
                      mc.InstructorTypeID, tn.ID AS TournamentID, m.ID AS MemberID, d.ID AS DojoID, m2.ID AS InstructorID, ct.ID AS CertificateTypeID
FROM         dbo.membercerts AS mc LEFT OUTER JOIN
                      dbo.certtype AS ct ON mc.CertificateTypeID = ct.ID LEFT OUTER JOIN
                      dbo.dojo AS d ON mc.DojoID = d.ID LEFT OUTER JOIN
                      dbo.member AS m ON mc.MemberID = m.ID LEFT OUTER JOIN
                      dbo.instructortype AS it ON mc.InstructorTypeID = it.ID LEFT OUTER JOIN
                      dbo.member AS m2 ON mc.InstructorID = m2.ID LEFT OUTER JOIN
                      dbo.tournament AS tn ON mc.TourneyID = tn.ID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCertificates';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'nd
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 19
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCertificates';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[56] 4[6] 2[20] 3) )"
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
         Begin Table = "mc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "ct"
            Begin Extent = 
               Top = 246
               Left = 236
               Bottom = 365
               Right = 446
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 3
               Left = 719
               Bottom = 107
               Right = 879
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 18
               Left = 475
               Bottom = 137
               Right = 637
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "it"
            Begin Extent = 
               Top = 132
               Left = 550
               Bottom = 221
               Right = 738
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m2"
            Begin Extent = 
               Top = 236
               Left = 558
               Bottom = 355
               Right = 720
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tn"
            Begin Extent = 
               Top = 212
               Left = 39
               Bottom = 331
               Right = 199
            End
            DisplayFlags = 280
            TopColumn = 0
         E', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCertificates';

