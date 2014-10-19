create procedure spUploadImage
	@pID int,
	@fileName varchar(MAX),
	@fileContent image
As
update Product 
set ImageUrl=@fileName,
	ImageContent=@fileContent
where ProductID=@pID;
