create table [dbo].[Product]
(
	[ProductID] [int] not null identity primary key,
    [CategoryID] [int] not null foreign key references Category (CategoryID),
	[Title] [nvarchar](max) not null,
	[ShortDescription] [nvarchar](max) not null,
	[LongDescription] [nvarchar](max) not null,
	[ImageUrl] [nvarchar](max) null,
	[Price] [money] not null,
);
