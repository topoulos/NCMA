CREATE TABLE [dbo].[payment] (
    [ID]            INT             IDENTITY (1, 1) NOT NULL,
    [paymentdate]   DATE            NOT NULL,
    [invoiceid]     INT             NOT NULL,
    [paymentamount] NUMERIC (12, 2) NOT NULL,
    [description]   NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED ([ID] ASC)
);

