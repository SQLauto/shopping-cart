create  procedure spUpdateProduct 
(
	@pID Int, 
	@cID Int, 
	@title nvarchar(MAX), 
	@ShortDescription nvarchar(MAX) ,
	@LongDescription nvarchar(MAX),
	@ImageUrl nvarchar(MAX),
	@Price money
)
As
UPDATE [Product]
Set CategoryID=@cID,
	Title=@title,
	ShortDescription=@ShortDescription,
	LongDescription=@LongDescription,
	ImageUrl=@ImageUrl,
    Price=@Price
where ProductID=@pID;