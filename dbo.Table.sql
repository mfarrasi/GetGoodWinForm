CREATE TABLE [dbo].[Table] (
    [Id]         INT DEFAULT ((5)) NOT NULL,
    [Points]     INT NOT NULL,
    [Dragon]     BIT DEFAULT ((0)) NOT NULL,
    [Cat]        BIT DEFAULT ((0)) NOT NULL,
    [Dog]        BIT DEFAULT ((0)) NOT NULL,
    [Golem]      BIT DEFAULT ((0)) NOT NULL,
    [AnakMiskin] BIT DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

