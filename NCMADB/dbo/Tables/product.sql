CREATE TABLE [dbo].[product] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [productname] VARCHAR (255)   NULL,
    [categoryid]  INT             NOT NULL,
    [duration]    INT             NULL,
    [amount]      NUMERIC (12, 2) NOT NULL,
    CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED ([ID] ASC)
);

