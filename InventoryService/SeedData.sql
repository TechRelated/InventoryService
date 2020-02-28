USE [Inventory]
GO

Insert Into UsersInfo(FirstName, LastName, UserName, Email, Password, CreatedDate) 
Values ('Inventory', 'Admin', 'InventoryAdmin', 'InventoryAdmin@abc.com', '$admin@2017', GETDATE())

INSERT INTO [dbo].[Products]
           ([Name] ,[Category],[Color],[UnitPrice],[AvailableQuantity])
SELECT 'Product Item 1','Category ABC','Red', 1000,50
UNION
SELECT 'Product Item 2','Category ABC','Red', 1000,50
UNION
SELECT 'Product Item 3','Category A','Yellow', 1000,0

--select * from [dbo].[Products]

/*
https://localhost:5001/api/token
Body : 
{
	
	"Email" : "InventoryAdmin@abc.com",
	"Password" : "$admin@2017",
	"FirstName" : "Inventory",
	"LastName" : "Admin",
	"UserName" : "InventoryAdmin"
}

Jwt Token : Bearer 


https://localhost:5001/api/products
Headers :
Key
Authorization 

Value : Bearer /*jwt token*/


*/


