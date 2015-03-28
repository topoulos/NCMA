CREATE TABLE [dbo].[memberissue] (
    [ID]        INT           NOT NULL,
    [MemberID]  INT           NULL,
    [IssueID]   INT           NULL,
    [Notes]     VARCHAR (255) NULL,
    [IssueDate] DATETIME2 (7) NULL
);

