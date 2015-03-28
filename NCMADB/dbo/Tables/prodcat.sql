CREATE TABLE [dbo].[prodcat] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [prodcatname] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_prodcat] PRIMARY KEY CLUSTERED ([ID] ASC)
);

