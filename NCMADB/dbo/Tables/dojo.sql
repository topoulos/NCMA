CREATE TABLE [dbo].[dojo] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]  VARCHAR (255) NULL,
    [Style] VARCHAR (255) NULL,
    CONSTRAINT [PK_dojo] PRIMARY KEY CLUSTERED ([ID] ASC)
);

