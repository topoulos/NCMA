CREATE TABLE [dbo].[invoice] (
    [ID]          INT  IDENTITY (1, 1) NOT NULL,
    [InvoiceDate] DATE NULL,
    [MemberID]    INT  NULL,
    CONSTRAINT [PK_invoice] PRIMARY KEY CLUSTERED ([ID] ASC)
);

