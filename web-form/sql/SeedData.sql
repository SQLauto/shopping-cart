-- CPUs category
declare @categoryID int;
insert into Category (Title, ImageUrl) values ('CPUs', '~/Images/CategoryCPUs.png');
set @categoryID = SCOPE_IDENTITY();

insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent)
values 
(@categoryID, 
 'R7', 
 'R7 short description...',
 'R7 long description...', 
 '~\Images\ProductR7.png',
 999.99,null);
 
insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent)
values 
(@categoryID, 
 'AMD 2000', 
 'AMD 2000 short description...',
 'AMD 2000 long description...', 
 '~\Images\ProductAMD2000.png',
 75.00,null);
 
insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent) 
values
(@categoryID, 
 'Ultra Core i9', 
 'Ultra Core i9 short description...',
 'Ultra Core i9 long description...', 
 '~\Images\ProductUltraCorei9.png', 
 499.95,null);

-- Memory category
insert into Category (Title, ImageUrl) values ('Memory', '~/Images/CategoryMemory.png');
set @categoryID = SCOPE_IDENTITY();

insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent)
values 
(@categoryID, 
 'Kingston Ultra Fury', 
 'Kingston Ultra Fury short description...',
 'Kingston Ultra Fury long description...', 
 '~\Images\ProductKingstonUltraFury.png',
 100.00,null);
 
insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent)
values 
(@categoryID, 
 'ZEDRAM', 
 'ZEDRAM short description...',
 'ZEDRAM long description...', 
 '~\Images\ProductZEDRAM.png',
 150.00,null);
 
insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent) 
values
(@categoryID, 
 'DDRZ', 
 'DDRZ short description...',
 'DDRZ long description...', 
 '~\Images\ProductDDRZ.png', 
 400.00,null);

-- Graphics Cards category
insert into Category (Title, ImageUrl) values ('Graphics Cards', '~/Images/CategoryGraphicsCards.png');
set @categoryID = SCOPE_IDENTITY();

insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent)
values 
(@categoryID, 
 'ATI 5.0 GC', 
 'ATI 5.0 GC short description...',
 'ATI 5.0 GC long description...', 
 '~\Images\ProductATI5.0GC.png',
 350.00,null);
 
insert into Product (CategoryID, Title, ShortDescription, LongDescription, ImageUrl, Price,ImageContent)
values 
(@categoryID, 
 'Nvidia Revolution X1 GFX', 
 'Nvidia Revolution X1 GFX short description...',
 'Nvidia Revolution X1 GFX long description...', 
 '~\Images\ProductNvidiaRevolutionX1GFX.png',
 700.00,null);
 