CREATE TABLE [dbo].[membercerts] (
    [ID]                INT            IDENTITY (1, 1) NOT NULL,
    [MemberID]          INT            NULL,
    [DojoID]            INT            NULL,
    [CertificateTypeID] INT            NULL,
    [RankText]          NVARCHAR (MAX) NULL,
    [InstructorID]      INT            NULL,
    [InstructorTypeID]  INT            NULL,
    [FromDate]          DATETIME       NULL,
    [ThruDate]          DATETIME       NULL,
    [Completed]         BIT            NULL,
    [TourneyID]         INT            NULL,
    CONSTRAINT [PK_certificates] PRIMARY KEY CLUSTERED ([ID] ASC)
);

