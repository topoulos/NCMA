CREATE TABLE [dbo].[issuetype] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NULL,
    [Description] VARCHAR (255) NULL,
    CONSTRAINT [PK_issuetype] PRIMARY KEY CLUSTERED ([ID] ASC)
);

