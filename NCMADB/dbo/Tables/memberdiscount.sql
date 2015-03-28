CREATE TABLE [dbo].[memberdiscount] (
    [ID]                       INT IDENTITY (1, 1) NOT NULL,
    [MemberDiscountPercentage] INT NULL,
    [MemberID]                 INT NULL,
    CONSTRAINT [PK_memberdiscount] PRIMARY KEY CLUSTERED ([ID] ASC)
);

