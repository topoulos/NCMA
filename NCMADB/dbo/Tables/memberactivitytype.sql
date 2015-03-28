CREATE TABLE [dbo].[memberactivitytype] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (255) NULL,
    CONSTRAINT [PK_memberactivitytype] PRIMARY KEY CLUSTERED ([ID] ASC)
);

