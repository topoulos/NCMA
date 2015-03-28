CREATE TABLE [dbo].[lineitem] (
    [ID]        INT IDENTITY (1, 1) NOT NULL,
    [productid] INT NOT NULL,
    [qty]       INT NOT NULL,
    [discount]  INT NOT NULL,
    [invoiceid] INT NOT NULL,
    CONSTRAINT [PK_lineitem] PRIMARY KEY CLUSTERED ([ID] ASC)
);

