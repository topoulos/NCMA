CREATE TABLE [dbo].[state] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [StateName]   VARCHAR (255) NULL,
    [StateAbbrev] VARCHAR (2)   NULL,
    CONSTRAINT [PK_state] PRIMARY KEY CLUSTERED ([ID] ASC)
);

