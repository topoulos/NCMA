CREATE TABLE [dbo].[tournresult] (
    [ID]                     INT IDENTITY (1, 1) NOT NULL,
    [TournamentID]           INT NULL,
    [MemberID]               INT NULL,
    [TournAcheivementTypeID] INT NULL,
    [TournDivisionID]        INT NULL,
    [TournCompTypeID]        INT NULL,
    CONSTRAINT [PK_tournresult] PRIMARY KEY CLUSTERED ([ID] ASC)
);

