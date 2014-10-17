Create procedure [dbo].[InsertProduct]
(
	@ProductID int,
    @CategoryID int,
    @Title nvarchar(MAX),
    @ShortDescription nvarchar(MAX),
	@LongDescription nvarchar(MAX),
    @ImageUrl nvarchar(MAX),
    @Price money
)

As

Insert dbo.Product(ProductID,CategoryID,Title,ShortDescription,LongDescription,ImageUrl,Price)
Values (@ProductID,@CategoryID,@Title,@ShortDescription,@LongDescription,@ImageUrl,@Price)