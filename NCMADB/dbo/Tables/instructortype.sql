CREATE TABLE [dbo].[instructortype] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [InstructorTypeName] VARCHAR (255) NULL,
    CONSTRAINT [PK_instructortype] PRIMARY KEY CLUSTERED ([ID] ASC)
);

