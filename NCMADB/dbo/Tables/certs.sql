CREATE TABLE [dbo].[certs] (
    [ID]               INT           IDENTITY (1, 1) NOT NULL,
    [MemberID]         INT           NULL,
    [InstructorID]     INT           NULL,
    [CertTypeID]       INT           NULL,
    [Completed]        BIT           NULL,
    [MemberActivityID] INT           NULL,
    [CertDate]         DATETIME2 (7) NULL,
    [EndDate]          DATETIME2 (7) NULL,
    [TourneyID]        INT           NULL,
    CONSTRAINT [PK_certs] PRIMARY KEY CLUSTERED ([ID] ASC)
);

