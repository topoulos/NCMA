CREATE TABLE [dbo].[tournament] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [Address1]    VARCHAR (255) NULL,
    [Address2]    VARCHAR (255) NULL,
    [Address3]    VARCHAR (255) NULL,
    [City]        VARCHAR (255) NULL,
    [StateID]     INT           NULL,
    [PostalCode]  VARCHAR (12)  NULL,
    [TournDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_tournament] PRIMARY KEY CLUSTERED ([ID] ASC)
);

