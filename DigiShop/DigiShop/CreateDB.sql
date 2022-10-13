CREATE DATABASE ShoppingCartDB
GO

USE ShoppingCartDB
GO

CREATE TABLE Customer
(
	[CustomerId] INT IDENTITY(1,1) NOT NULL,
	[customerName] VARCHAR(50) NOT NULL,
	[username] NVARCHAR(20) NOT NULL,
	[password] NVARCHAR(20) NOT NULL
	
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC))

GO

CREATE TABLE [Session]
(
	[sessionId] UNIQUEIDENTIFIER NOT NULL,
	[customerId] INT NOT NULL,
	[expiry] TIMESTAMP NOT NULL
	
    CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED ([sessionId] ASC)
    CONSTRAINT [FK_SC100] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([CustomerId]))
GO


CREATE TABLE Product
(
	[productId] INT NOT NULL,
	[productName] NVARCHAR (50),
	[productPrice] DECIMAL (10,2),
	[productDesc] NVARCHAR (300),
	[productIMG] NVARCHAR (300)
	
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([productId] ASC))
GO


CREATE TABLE [Order]
(
	[orderId] INT NOT NULL,
	[customerId] INT NOT NULL,
	[productId] INT NOT NULL,
	[orderDate] DATETIME NOT NULL,
	[productQty] INT NOT NULL
	
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC)
    CONSTRAINT [FK_SC101] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([CustomerId]),
	CONSTRAINT [FK_SC102] FOREIGN KEY ([productId]) REFERENCES [Product] ([ProductId]))
GO


CREATE TABLE ActivationCodes
(
	[activationID] UNIQUEIDENTIFIER NOT NULL,
	[orderID] INT NOT NULL
	
	CONSTRAINT [PK_ActivationCodes] PRIMARY KEY CLUSTERED ([activationID] ASC)
	CONSTRAINT [FK_SC103] FOREIGN KEY ([OrderId]) REFERENCES [Order] ([OrderId]),
)

GO

CREATE TABLE Rating
(
	[ratingId] INT IDENTITY(1,1) NOT NULL,
	[customerId] INT NOT NULL,
	[productId] INT NOT NULL,
	[ratingValue] INT NOT NULL
	
    CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED ([ratingId] ASC)
	CONSTRAINT [FK_SC104] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([customerId]),
	CONSTRAINT [FK_SC105] FOREIGN KEY ([productId]) REFERENCES [Product] ([productId]))
	
GO

CREATE TABLE Cart
(
	[cartId] INT IDENTITY(1,1) NOT NULL,
	[customerId] INT NOT NULL,
	[productId] INT NOT NULL,
	[itemCount] INT NOT NULL
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([cartId] ASC)
    CONSTRAINT [FK_SC106] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([customerId]),
	CONSTRAINT [FK_SC108] FOREIGN KEY ([productId]) REFERENCES [Product] ([productId]))


INSERT INTO dbo.[Customer] (customerName,username,password) VALUES
(N'John Tan',N'Jonjon1',N'Jonjon1'),
(N'Mary Lee',N'MerryMarry',N'MerryMarry'),
(N'Peter Mok',N'ThePetrus',N'ThePetrus')


INSERT INTO dbo.[Product](productid,productName,productPrice,productDesc,productIMG) VALUES
(N'1',N'.NET Charts',N'99',N'Brings powerful charting capabilities to your .NET applications.','/images/ChartNET.png'),
(N'2',N'.NET Paypal',N'69',N'Integrate your .NET apps with PayPal the easy way!','/images/Paypal.png'),
(N'3',N'.NET ML',N'299',N'Supercharged NET machine learning libraries.','/images/ML.png'),
(N'4',N'.NET Analytics',N'299',N'Performs data mining and analytics easily in .NET.','/images/Analytics.png'),
(N'5',N'.NET Logger',N'49',N'Logs and aggregates events easily in your NET apps.','/images/Logger.png'),
(N'6',N'.NET Numerics',N'199',N'Powerful numerical methods for your NET simulations.','/images/Math.png')

INSERT INTO dbo.[Rating](customerId,productId,ratingValue) VALUES
(N'1',N'1',N'1'),
(N'2',N'1',N'5'),
(N'3',N'1',N'5'),
(N'1',N'2',N'3'),
(N'2',N'2',N'5'),
(N'3',N'2',N'4'),
(N'1',N'3',N'3'),
(N'1',N'4',N'1')
