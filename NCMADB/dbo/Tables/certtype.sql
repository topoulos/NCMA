CREATE TABLE [dbo].[certtype] (
    [ID]                       INT           IDENTITY (1, 1) NOT NULL,
    [Name]                     VARCHAR (255) NULL,
    [Description]              VARCHAR (255) NULL,
    [ValidationDurationInDays] INT           NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

