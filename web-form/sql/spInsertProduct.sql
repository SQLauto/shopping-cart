USE [webform_s3301108]
GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 2014/10/18 1:58:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[InsertProduct]
(
    @CategoryID int,
    @Title nvarchar(MAX),
    @ShortDescription nvarchar(MAX),
	@LongDescription nvarchar(MAX),
    @ImageUrl nvarchar(MAX),
    @Price money
)

As

Insert dbo.Product(CategoryID,Title,ShortDescription,LongDescription,ImageUrl,Price)
Values (@CategoryID,@Title,@ShortDescription,@LongDescription,@ImageUrl,@Price)