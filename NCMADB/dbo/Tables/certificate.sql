CREATE TABLE [dbo].[certificate] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [MemberID]       INT            NULL,
    [CertType]       VARCHAR (50)   NULL,
    [FromDate]       DATE           NULL,
    [ThruDate]       DATE           NULL,
    [RankText]       NVARCHAR (800) NULL,
    [InstructorType] NVARCHAR (100) NULL,
    CONSTRAINT [PK_certificate] PRIMARY KEY CLUSTERED ([id] ASC)
);

