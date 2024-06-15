CREATE TABLE [dbo].[SpotsTable] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (50)  NOT NULL,
    [description] VARCHAR (255) NOT NULL,
    [location]    VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)
GO

CREATE TABLE [dbo].[UsersTable] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [email]      VARCHAR (255) NOT NULL,
    [password]   VARCHAR (255) NOT NULL,
    [first_name] VARCHAR (20)  NOT NULL,
    [last_name]  VARCHAR (20)  NOT NULL,
    [dob]        VARCHAR (20)  NULL,
    [gender]     VARCHAR (10)  NULL,
    [contact]    VARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
)
GO

CREATE TABLE [dbo].[ReviewsTable] (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [message] VARCHAR (255) NOT NULL,
    [status]  INT           DEFAULT ((0)) NOT NULL,
    [rating]  VARCHAR (2)   NOT NULL,
    [user_id] INT           NOT NULL,
    [spot_id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_UsersTable_ToReviewsTable] FOREIGN KEY ([user_id]) REFERENCES [dbo].[UsersTable] ([id]),
    CONSTRAINT [FK_SpotsTable_ToReviewsTable] FOREIGN KEY ([spot_id]) REFERENCES [dbo].[SpotsTable] ([id])
)
GO

CREATE TABLE [dbo].[FavouritesTable] (
    [id]      INT IDENTITY (1, 1) NOT NULL,
    [spot_id] INT NOT NULL,
    [user_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_UsersTable_ToFavouritesTable] FOREIGN KEY ([user_id]) REFERENCES [dbo].[UsersTable] ([id]),
    CONSTRAINT [FK_SpotsTable_ToFavouritesTable] FOREIGN KEY ([spot_id]) REFERENCES [dbo].[SpotsTable] ([id])
)
GO