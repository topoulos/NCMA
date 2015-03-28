CREATE TABLE [dbo].[country] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (255) NULL,
    CONSTRAINT [PK_country] PRIMARY KEY CLUSTERED ([ID] ASC)
);

