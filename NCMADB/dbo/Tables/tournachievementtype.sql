CREATE TABLE [dbo].[tournachievementtype] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NULL,
    [Description] VARCHAR (255) NULL,
    CONSTRAINT [PK_tournachievementtype] PRIMARY KEY CLUSTERED ([ID] ASC)
);

