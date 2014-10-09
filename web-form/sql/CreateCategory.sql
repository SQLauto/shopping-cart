create table [dbo].[Category]
(
	[CategoryID] [int] not null identity primary key,
	[Title] [nvarchar](max) not null,
	[ImageUrl] [nvarchar](max) null
);
