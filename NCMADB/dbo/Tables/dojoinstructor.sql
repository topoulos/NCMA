CREATE TABLE [dbo].[dojoinstructor] (
    [ID]               INT IDENTITY (1, 1) NOT NULL,
    [DojoID]           INT NOT NULL,
    [InstructorID]     INT NULL,
    [InstructorTypeID] INT NULL,
    CONSTRAINT [PK_dojoinstructor] PRIMARY KEY CLUSTERED ([ID] ASC)
);

