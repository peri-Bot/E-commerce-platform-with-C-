create login newUser1User with password='student'

create user newUser1User for login newUser1

exec sp_addrolemember 'db_datareader','newUser1User'

create schema newUser1User

CREATE DATABASE plutusDB
use plutusDB

SELECT * FROM UserInfo
SELECT * FROM Shopping_Session
SELECT * from AddressInfo
select * from Product
SELECT CURRENT_TIMESTAMP



CREATE TABLE UserInfo( 
    ID INT PRIMARY KEY IDENTITY, 
    userName VARCHAR(12) NOT NULL, 
    passw VARCHAR(15) not NULL, 
    firstName VARCHAR(10) NOT NULL, 
    lastName VARCHAR(10) NOT NULL, 
    email VARCHAR(50) NOT NULL,
    telephone INT,
    UserType var 
) 
 
--     3   PROCEDURE
GO
CREATE PROC [dbo].[SP_Insert_User] --INSERT User
@varUserName VARCHAR(12),@varFirstName VARCHAR(10) ,@varLastName VARCHAR(12),@varPassw VARCHAR(10),@varEmail VARCHAR(50),@varTelephone INT
AS
    BEGIN
        INSERT INTO UserInfo VALUES(@varUserName,@varPassw,@varFirstName,@varLastName,@varEmail,@varTelephone)
    END
GO



GO
CREATE PROCEDURE [dbo].[SP_Validate_User] --Validate user for login
      @varEmail NVARCHAR(50),
      @varPassw NVARCHAR(15)
AS
BEGIN
      SET NOCOUNT ON;
      DECLARE @UserId INT, @LastLoginDate DATETIME
     
      SELECT @UserId = ID 
      FROM UserInfo 
      WHERE email = @varEmail AND [passw] = @varPassw
     
      IF @UserId IS NOT NULL
      BEGIN
          
                  SELECT @UserId [UserId] -- User Valid
            
      END
      ELSE
        BEGIN
            SELECT -1 -- User invalid.
         END
END
GO

GO
CREATE PROC [SP_get_user]
AS 
    BEGIN
        DECLARE @lastID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')

        SELECT userName,passw,firstName,lastName,telephone,email 
        FROM UserInfo
        JOIN Shopping_Session ON Shopping_Session.userID = UserInfo.ID
        WHERE Shopping_Session.ID = @lastID
    END
GO
--PROCEDURE

--TABLE
CREATE TABLE AddressInfo( 
    ID INT PRIMARY KEY IDENTITY, 
    userID INT FOREIGN KEY REFERENCES UserInfo(ID), 
    addressLine VARCHAR(10) NOT NULL, 
    city VARCHAR(10) NOT NULL, 
    postalCode VARCHAR(10) NOT NULL, 
    zipCode INT
     
) 
--TABLE

--   2     PROCEDURE
GO
CREATE PROC [SP_Insert_Address](
@varUserName VARCHAR(12),@varAddressLine VARCHAR(10),@varCity VARCHAR(10),@varPostalCode VARCHAR(10),@varZipCode INT)
AS
    BEGIN
        DECLARE @varUserID INT
        SELECT @varUserID = ID FROM UserInfo
        WHERE userName = @varUserName

        INSERT INTO AddressInfo VALUES(@varUserID,@varAddressLine,@varCity,@varPostalCode,@varZipCode)
    END
GO

GO
CREATE PROC [SP_get_Address]
AS 
    BEGIN
        DECLARE @lastID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')

        SELECT addressLine,city,postalCode,zipCode 
        FROM UserInfo
        JOIN AddressInfo ON AddressInfo.userID = UserInfo.ID
        JOIN Shopping_Session ON Shopping_Session.userID = UserInfo.ID
        WHERE Shopping_Session.ID = @lastID
    END
GO

--PROCEDURE

--TABLE
CREATE TABLE Payment( 
    ID INT PRIMARY KEY IDENTITY, 
    userID INT FOREIGN KEY REFERENCES UserInfo(ID), 
    paymentType VARCHAR(10) NOT NULL, 
    pprovider VARCHAR(10) NOT NULL 
)
--TABLE

--PROCEDURE
GO
CREATE PROC [SP_insert_into_payment]
@varPaymentType VARCHAR(10),@var
AS  
    BEGIN
        INSERT INTO Payment

--PROCEDURE

--TABLE
CREATE TABLE Shopping_Session( 
    ID INT PRIMARY KEY IDENTITY, 
    userID INT FOREIGN KEY REFERENCES UserInfo(ID), 
    total DECIMAL DEFAULT 0.00, 
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    modifyedAt DATETIME
) 
--TABLE

--   2  PROCEDURE
GO
CREATE PROC [SP_start_shopping_session]
@varEmail VARCHAR(50)
AS
    BEGIN
        DECLARE @UserId INT
        SELECT @UserId = ID FROM UserInfo
                         WHERE email = @varEmail
        INSERT INTO Shopping_Session (userID) VALUES (@UserId)

    END
GO

GO
CREATE PROCEDURE [SP_end_shopping_session]
AS
    BEGIN 
        DECLARE @lastID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')
       
        UPDATE Shopping_Session
        SET modifyedAt = CURRENT_TIMESTAMP
        WHERE ID = @lastID
    END
GO

--PROCEDURE

--TABLE 
CREATE TABLE CartItem( 
    ID INT PRIMARY KEY IDENTITY, 
    sessionID INT FOREIGN KEY REFERENCES Shopping_Session(ID), 
    productID INT, 
    quantity INT,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    modifyedAt DATETIME
) 
--TABLE

--    4   PROCEDURE
GO
CREATE PROC [SP_insert_into_cartItem]
@varProductName VARCHAR(15),@varQuantity INT
AS
    BEGIN
        DECLARE @lastID INT,@productID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')

        SELECT @productID = ID FROM Product
        WHERE pname = @varProductName

        INSERT into CartItem (sessionID,productID,quantity) VALUES(@lastID,@productID,@varQuantity) 
    END
GO

GO
CREATE PROC [SP_update_cartItem]
@varProductName VARCHAR(15),@varQuantity INT
AS
    BEGIN
        DECLARE @productID INT
        SELECT @productID = ID FROM Product
        WHERE pname = @varProductName

        IF(@varQuantity != (SELECT quantity FROM CartItem
                            WHERE productID = @productID))  
            BEGIN
                UPDATE CartItem
                SET quantity = @varQuantity
                WHERE productID = @productID
            END
    END
GO

GO
CREATE PROC [SP_remove_cartItem]
@varProductName VARCHAR(15)
AS
    BEGIN
        DECLARE @productID INT
        SELECT @productID = ID FROM Product
        WHERE pname = @varProductName

        -- Delete rows from table '[CartItem]' in schema '[dbo]'
        DELETE FROM [dbo].[CartItem]
        WHERE productID = @varProductName
    END
GO

Go 
Create PROC [SP_get_cart_item]
As 
    BEGIN
        SELECT PName,pdesc,pimage,price,vendor,discount,quantity 
        FROM Product
        JOIN CartItem ON CartItem.ProductID = Product.ID
        WHERE Product.ID = CartItem.productID
    END
GO
--PROCEDURE


--TABLE 
CREATE TABLE Product( 
    ID INT PRIMARY KEY IDENTITY, 
    PName VARCHAR(20) NOT NULL, 
    pdesc text,
    pimage IMAGE, 
    catagoryID INT, 
    inventoryID INT, 
    price FLOAT NOT NULL,
    vendor VARCHAR(15),
    discount FLOAT,
    createdAT DATETIME DEFAULT CURRENT_TIMESTAMP,
    modifyedAT DATETIME,
    deletedAT DATETIME
) 
--TABLE
GO
--   5   PROCEDURE
GO
alter PROCEDURE [SP_insert_into_product]
@varPname VARCHAR(20),@varPdesc text,@varCatagoryName INT,@varInventoryID INT,@varPrice INT,@varDiscount FLOAT,@varVendor VARCHAR(15),@varPimage IMAGE
AS
    BEGIN
        DECLARE @catID INT
        SELECT @catID = ID FROM ProductCatagory
        WHERE pcname = @varCatagoryName

        INSERT INTO Product (PName,pdesc,pimage,catagoryID,inventoryID,price,vendor,discount) VALUES(@varPname,@varPdesc,@varPimage,@catID,@varInventoryID,@varPrice,@varVendor,@varDiscount)
    END
GO

GO
CREATE PROCEDURE [SP_get_product_by_cat_name]
@varCatagoryName VARCHAR(15)
AS
    BEGIN
        DECLARE @catID INT,@varInventory
        SELECT @catID = ID FROM ProductCatagory
        WHERE pcname = @varCatagoryName
        

        SELECT PName,pdesc,pimage,price,vendor,discount FROM Product
        WHERE catagoryID = @catId
    END
GO

GO
CREATE PROC [SP_get_product_by_name]
@varProductName VARCHAR(15)
AS
    BEGIN
        SELECT PName,pdesc,pimage,price,vendor,discount FROM Product
        WHERE PName = @varProductName
    END
GO

GO
CREATE PROCEDURE [SP_get_product_number_cat]
@varCatagoryName VARCHAR(15),@pCount INT OUTPUT
AS
    BEGIN
        DECLARE @catID INT

        SELECT @catID = ID FROM [dbo].[ProductCatagory]
        WHERE pcname = @varCatagoryName

        SELECT @pCount = COUNT(ID) FROM Product
        WHERE catagoryID = @catID

         
    END
GO

GO
CREATE PROCEDURE [SP_get_product_inventory]
@varProductName VARCHAR(15)
AS
    BEGIN
        DECLARE @varProductInvitoryID INT
        SELECT @varProductInvitoryID =  inventoryID FROM Product
        WHERE pname = @varProductName

       EXEC [SP_get_invitory]@varProductInvitoryID
    END
GO


 
--TABLE 
CREATE TABLE ProductCatagory( 
    ID INT PRIMARY KEY IDENTITY, 
    pcname VARCHAR(15), 
    pcdesc text,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    modifyedAt DATETIME,
    deletedAt DATETIME
) 
--TABLE
 
--PROCEDURE
GO
ALTER PROC [SP_insert_product_catagory] --Insert Product Catagory
@varPcName VARCHAR(15),@varPcDesc text
AS  
    BEGIN
        INSERT INTO ProductCatagory (pcname,pcdesc) VALUES (@varPcName,@varPcDesc)
    END
GO

Go
CREATE PROC [SP_update_product_catagory_name]
@varID INT,@varPcName VARCHAR(15)
AS
    BEGIN
        UPDATE ProductCatagory
        SET pcname = @varPcName,modifyedAt = CURRENT_TIMESTAMP
        WHERE ID = @varID
    END
GO

GO
CREATE PROC [SP_update_product_catagory_desc]
@varID INT,@varPcDesc text
AS
    BEGIN
        UPDATE ProductCatagory
        SET pcdesc = @varPcDesc,modifyedAt = CURRENT_TIMESTAMP
        WHERE ID = @varID


    END
GO

GO
CREATE PROC [SP_search_product_catagory_by_name]
@varPcName VARCHAR(15)
AS
    BEGIN
        SELECT * FROM ProductCatagory
        WHERE pcname = @varPcName
    END
GO



--PROCEDURE

--TABLE
CREATE TABLE ProductInvitory( 
    ID INT PRIMARY KEY IDENTITY, 
    quantity INT,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    modifyedAt DATETIME,
    deletedAt DATETIME
) 
--TABLE
--PROCEDURE
Go
CREATE PROCEDURE [SP_insert_into_product_invitory]
@varQuantity INT
AS
    BEGIN
        INSERT INTO ProductInvitory (quantity) VALUES (@varQuantity)
    END
GO

GO
CREATE PROCEDURE [SP_get_invitory]
@varProductInvitoryID INT,@varQuantity INT OUTPUT
AS
    BEGIN
        SELECT @varQuantity = quantity FROM ProductInvitory
        WHERE ID = @varProductInvitoryID

        RETURN @varQuantity
    END
GO

--PROCEDURE
 
 --TABLE
CREATE TABLE OrderDetails( 
    ID INT PRIMARY KEY IDENTITY, 
    userID INT FOREIGN KEY REFERENCES UserInfo(ID), 
    paymentID INT, 
    total INT, 
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    modifyedAT DATETIME 
) 
--TABLE
--PROCEDURE

GO
CREATE PROC [SP_insert_into_oreder_details]
@varTotal INT
AS  
    BEGIN
        DECLARE @lastID INT,@userID INT,@varPaymentID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')

        SELECT @userID = ID FROM Shopping_Session
        WHERE ID = @lastID

        SELECT @varPaymentID = ID FROM userPayment
        WHERE userID = @userID

        INSERT into OrderDetails (userID,paymentID,total) VALUES (@userID,@varPaymentID,@varTotal)
    END
GO

--PROCEDURE

 
CREATE TABLE OrderItems( 
    ID INT PRIMARY KEY IDENTITY, 
    quantity INT, 
    paymentID INT, 
    orderID INT, 
    createdAt TIMESTAMP 
) 
 
 
CREATE TABLE PaymentDetails( 
    ID INT PRIMARY KEY IDENTITY, 
    orderID INT FOREIGN KEY REFERENCES OrderItems(ID), 
    passw VARCHAR not NULL, 
    firstName VARCHAR(10) NOT NULL, 
) 

 --TABLE
 CREATE TABLE userPayment(
     ID INT PRIMARY KEY IDENTITY,
     userID INT FOREIGN KEY REFERENCES UserInfo(ID),
     paymentType VARCHAR(15),
     provider VARCHAR(20),
     accoutnNo BIGINT,
     expiry DATE
 )
 --TABLE

 --PROCEDURE
 GO
 CREATE PROC [SP_insert_into_user_payment]
 @varPaymentType VARCHAR(15),@varProvider VARCHAR(20),@varAccountNO BIGINT,@varExpiry DATE
 AS
    BEGIN
        DECLARE @lastID INT,@varUserID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')

        SELECT @varUserID = useriD FROM Shopping_Session
        WHERE ID = @lastID

        INSERT INTO userPayment VALUES(@varUserID,@varPaymentType,@varProvider,@varAccountNO,@varExpiry)
    END
GO
 
GO 
create proc [SP_get_user_payment]
AS
    BEGIN
        DECLARE @lastID INT,@varUserID INT
        SET @lastID = IDENT_CURRENT('dbo.Shopping_Session')
        
        SELECT @varUserID = useriD FROM Shopping_Session
        WHERE ID = @lastID

        SELECT 

       -- SELECT PaymentType 

ALTER TABLE CartItem 
    ADD CONSTRAINT pfk 
    FOREIGN KEY(productID)REFERENCES Product(ID) 

 
 
ALTER TABLE Product 
    ADD CONSTRAINT cfk 
    FOREIGN KEY(catagoryID)REFERENCES ProductCatagory(ID) 
ALTER TABLE Product 
    ADD CONSTRAINT ifk 
    FOREIGN KEY(inventoryID)REFERENCES ProductInvitory(ID) 
 
 
ALTER TABLE OrderItems 
    ADD CONSTRAINT paymentFK 
    FOREIGN KEY (paymentID) REFERENCES PaymentDetails(ID) 
ALTER TABLE OrderItems 
    ADD CONSTRAINT ORDERFK 
    FOREIGN KEY (orderID) REFERENCES OrderDetails(ID) 
 
 
ALTER TABLE OrderDetails 
    ADD CONSTRAINT ORDERDFK 
    FOREIGN KEY (paymentID) REFERENCES PaymentDetails(ID)

	--------------triggers----------------

create table insertpersonfile(
 userid int primary key identity,
 userName VARCHAR(100) , 
    passw VARCHAR(100) , 
    firstName VARCHAR(100) , 
    lastName VARCHAR(100), 
    email VARCHAR(100),
    telephone INT 
	)
	go
	-------------------1
create trigger insertPerson on
UserInfo
for insert
as
          declare @firstname varchar(50)
		  declare @userName  varchar(100)
          declare @lastname varchar(50)
          declare @email VARCHAR(100)
          declare @telephone int
		  declare @passw varchar(100)
 
          select @userName  = userName from inserted ;
          select @firstname = firstname from inserted ;
          select @lastname = lastname from inserted ;
          select @email = email from inserted ;
		   select @telephone = telephone  from inserted ;
        
          insert into insertpersonfile ( firstname, lastname, userName, email,telephone,passw)
                values(@firstname,@userName,@lastname,@email,@telephone,@passw)
 
go
---------------------------------------------------------------2

  alter trigger insertedproduct on product
	for insert
         as
		 begin
		  declare @pname varchar(90), @price FLOAT,@vendor VARCHAR(20),@discount FLOAT                                                          
		  select @pname=PName,@price=price,@vendor=vendor from inserted
        print 'NEW VALUES IS ADDED TO PRODUCTTABLE'+@pname+' '+cast(@price as varchar(90))+ ' '+cast(@vendor as varchar(90))
		end
		 ---------------------------------------------------- -----3
		  create trigger deleteorupdate on OrderDetails
		   for update
		   as
		   begin
		   select * from inserted
		   select * from deleted
		   end
		  --------------------------------------------------------- ------------- 4
		   create trigger deletepayment on PaymentDetails
		   for delete
		   as
		   begin 
		   select * from deleted
		  end
		-----------------------------------------------------------  ------------- 5
		  create trigger insteadderss on Shopping_Session
		    instead of insert
			as
			begin
			select * from inserted
			select * from deleted
			end

 insert into Shopping_Session(userID,total)values(1,12)
			--------------------functions-----------------------
	
alter FUNCTION funcInventory(@ID int)  -- 1  Returns the number of qunitity.
 RETURNS  int  
AS
BEGIN  
    DECLARE @ret int;  
    SELECT @ret = SUM(ID)   
    FROM UserInfo u
    WHERE ID = @ID   
    RETURN @ret;  
END
select * from funcInventory(1)
 CREATE FUNCTION funcuserByorder (@uId int) ------2 returns username and also  OrderDetails 
RETURNS TABLE
AS
RETURN
(
SELECT u.userName,o.total
FROM UserInfo AS u
JOIN  OrderDetails AS o
ON u.ID=o.userID
WHERE u.ID = @uId
)
select * from funcuserByorder(1)

create function getaddresinfo(@id int)   --------------3 returns table 
returns  table
as
return (select * from AddressInfo where ID=@id)


 ---------------------------------------------------- 4
create function viewall()
returns @tbl Table(
uname varchar(max),
pasww varchar(90),
firstname varchar(90),
lastname varchar(90),
email varchar(90),
telephone int)
as
begin
insert into @tbl 
select   userName,passw, firstName,lastName, email ,telephone  from UserInfo
return 
end
select * from viewall() where  uname='blen12'


 
alter FUNCTION viewproandorderitem (@pId int) ------5 returns all the product and also  payment to
RETURNS TABLE
AS
RETURN
(
SELECT *
FROM  Product join Payment on Product.ID= Payment.ID
WHERE Product.ID = @pId
)