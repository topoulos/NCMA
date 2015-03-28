CREATE TABLE [dbo].[blacklist] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [FormerMemberID] INT           NULL,
    [FirstName]      VARCHAR (255) NULL,
    [LastName]       VARCHAR (255) NULL,
    [Reason]         VARCHAR (255) NULL,
    [DateListed]     DATETIME2 (7) NULL,
    CONSTRAINT [PK_blacklist] PRIMARY KEY CLUSTERED ([ID] ASC)
);

