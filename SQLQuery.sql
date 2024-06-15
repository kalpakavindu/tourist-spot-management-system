CREATE TABLE [dbo].[SpotsTable]
(
	[id] INT NOT NULL IDENTITY (1, 1),
	[name] VARCHAR(50) NOT NULL,
	[description] VARCHAR(255) NOT NULL,
	[location] VARCHAR(255) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
)
GO

CREATE TABLE [dbo].[UsersTable]
(
	[id] INT NOT NULL IDENTITY (1, 1),
	[email] VARCHAR(255) NOT NULL UNIQUE,
	[password] VARCHAR(255) NOT NULL,
	[first_name] VARCHAR(20) NOT NULL,
	[last_name] VARCHAR(20) NOT NULL,
	[dob] DATE,
	[gender] VARCHAR(10),
	[contact] VARCHAR (20),
	PRIMARY KEY CLUSTERED ([id] ASC)
)
GO

CREATE TABLE [dbo].[ReviewsTable]
(
	[id] INT NOT NULL IDENTITY (1, 1),
	[message] VARCHAR(255) NOT NULL,
	[status] VARCHAR(255) NOT NULL,
	[rating] INT NOT NULL,
	[user_id] INT NOT NULL,
	[spot_id] INT NOT NULL
	PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_UsersTable_ToReviewsTable] FOREIGN KEY ([user_id]) REFERENCES [dbo].[UsersTable] ([id]),
	CONSTRAINT [FK_SpotsTable_ToReviewsTable] FOREIGN KEY ([spot_id]) REFERENCES [dbo].[SpotsTable] ([id])
)
GO

CREATE TABLE [dbo].[FavouritesTable]
(
	[id] INT NOT NULL IDENTITY (1, 1),
	[spot_id] INT NOT NULL,
	[user_id] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_UsersTable_ToFavouritesTable] FOREIGN KEY ([user_id]) REFERENCES [dbo].[UsersTable] ([id]),
	CONSTRAINT [FK_SpotsTable_ToFavouritesTable] FOREIGN KEY ([spot_id]) REFERENCES [dbo].[SpotsTable] ([id])
)
GO