CREATE TABLE [dbo].[tourndivision] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NULL,
    [Description] VARCHAR (255) NULL,
    CONSTRAINT [PK_tourndivision] PRIMARY KEY CLUSTERED ([ID] ASC)
);

