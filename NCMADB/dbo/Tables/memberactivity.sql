CREATE TABLE [dbo].[memberactivity] (
    [ID]                  INT           IDENTITY (1, 1) NOT NULL,
    [TypeID]              INT           NULL,
    [ActivityDate]        DATETIME2 (7) NULL,
    [MemberID]            INT           NULL,
    [ActivityDescription] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_memberactivity] PRIMARY KEY CLUSTERED ([ID] ASC)
);

