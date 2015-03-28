CREATE VIEW dbo.vwInvoice
AS
SELECT     dbo.lineitem.productid, dbo.member.LastName, dbo.member.FirstName, dbo.member.MiddleName, dbo.member.Suffix, dbo.member.Address1, dbo.member.Address2,
                       dbo.member.Address3, dbo.member.City, dbo.member.PostalCode, dbo.member.HomePhone, dbo.member.CellPhone, dbo.member.Email, dbo.dojo.Name, 
                      dbo.country.Name AS country, dbo.state.StateAbbrev AS state, dbo.member.DateJoined, dbo.member.Active, dbo.member.DateLastPaid, dbo.member.DateInactive, 
                      dbo.member.Comments, dbo.invoice.InvoiceDate, dbo.invoice.MemberID, dbo.lineitem.ID AS lineitemid, dbo.lineitem.qty, dbo.lineitem.discount, dbo.lineitem.invoiceid,
                       dbo.product.productname, dbo.product.categoryid AS prodcatid, dbo.product.duration AS prodduration, dbo.product.amount AS prodamt, 
                      dbo.prodcat.prodcatname
FROM         dbo.dojo RIGHT OUTER JOIN
                      dbo.member ON dbo.dojo.ID = dbo.member.DojoID LEFT OUTER JOIN
                      dbo.country ON dbo.member.CountryID = dbo.country.ID LEFT OUTER JOIN
                      dbo.state ON dbo.member.StateID = dbo.state.ID RIGHT OUTER JOIN
                      dbo.lineitem INNER JOIN
                      dbo.product ON dbo.lineitem.productid = dbo.product.ID LEFT OUTER JOIN
                      dbo.prodcat ON dbo.product.categoryid = dbo.prodcat.ID LEFT OUTER JOIN
                      dbo.invoice ON dbo.lineitem.invoiceid = dbo.invoice.ID ON dbo.member.ID = dbo.invoice.MemberID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwInvoice';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'            TopColumn = 0
         End
         Begin Table = "member"
            Begin Extent = 
               Top = 38
               Left = 29
               Bottom = 179
               Right = 191
            End
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwInvoice';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[13] 2[20] 3) )"
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
         Begin Table = "country"
            Begin Extent = 
               Top = 247
               Left = 269
               Bottom = 336
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "invoice"
            Begin Extent = 
               Top = 13
               Left = 273
               Bottom = 120
               Right = 433
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "lineitem"
            Begin Extent = 
               Top = 4
               Left = 463
               Bottom = 144
               Right = 623
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prodcat"
            Begin Extent = 
               Top = 160
               Left = 845
               Bottom = 249
               Right = 1005
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "product"
            Begin Extent = 
               Top = 17
               Left = 667
               Bottom = 184
               Right = 827
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "state"
            Begin Extent = 
               Top = 124
               Left = 277
               Bottom = 228
               Right = 437
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dojo"
            Begin Extent = 
               Top = 212
               Left = 51
               Bottom = 316
               Right = 211
            End
            DisplayFlags = 280
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwInvoice';

