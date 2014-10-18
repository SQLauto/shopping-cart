create  procedure spDeleteProduct 
(
	@pID Int 
)
As
DELETE from Product
where ProductID=@pID;