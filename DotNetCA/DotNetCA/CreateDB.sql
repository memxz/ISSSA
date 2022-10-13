CREATE DATABASE ShoppingCartDB
GO

USE ShoppingCartDB
GO

CREATE TABLE Customer
(
	[CustomerId] INT IDENTITY(1,1) NOT NULL,
	[customerName] VARCHAR(50) NOT NULL,
	[username] VARCHAR(20) NOT NULL,
	[password] VARCHAR(20) NOT NULL
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC))

GO

CREATE TABLE [Session]
(
	[sessionId] UNIQUEIDENTIFIER NOT NULL,
	[customerId] INT NOT NULL,
	[timestamp] BIGINT NOT NULL
    CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED ([sessionId] ASC)
    CONSTRAINT [FK_SC100] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([CustomerId]))
GO


CREATE TABLE Product
(
	[productId] INT IDENTITY(1,1) NOT NULL,
	[productName] VARCHAR (50) NOT NULL,
	[productPrice] DECIMAL (5,2) NOT NULL,
	[productDesc] VARCHAR (300) NOT NULL
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([productId] ASC))
GO


CREATE TABLE [Order]
(
	[orderId] INT IDENTITY(1,1) NOT NULL,
	[customerId] INT NOT NULL,
	[orderDate] DATE NOT NULL
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC)
    CONSTRAINT [FK_SC101] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([CustomerId]))
GO


CREATE TABLE OrderDetails
(
	[orderDetailsId] INT IDENTITY(1,1) NOT NULL,
	[orderId] INT NOT NULL,
	[productId] INT NOT NULL,
	[itemCount] INT NOT NULL 
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED ([orderDetailsId] ASC)
    CONSTRAINT [FK_SC102] FOREIGN KEY ([orderId]) REFERENCES [Order] ([orderId]),
    CONSTRAINT [FK_SC103] FOREIGN KEY ([productId]) REFERENCES [Product] ([productId]))
GO

CREATE TABLE Rating
(
	[ratingId] INT IDENTITY(1,1) NOT NULL,
	[productId] INT NOT NULL,
	[ratingValue] INT NOT NULL
    CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED ([ratingId] ASC)
    CONSTRAINT [FK_SC104] FOREIGN KEY ([productId]) REFERENCES [Product] ([productId]))
GO

CREATE TABLE Cart
(
	[cartId] INT IDENTITY(1,1) NOT NULL,
	[customerId] INT NOT NULL
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([cartId] ASC)
    CONSTRAINT [FK_SC105] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([CustomerId]))
	
GO

CREATE TABLE CartDetails
(
	[cartDetailsId] INT IDENTITY(1,1) NOT NULL,
	[cartId] INT NOT NULL,
	[productId] INT NOT NULL,
	[itemCount] INT NOT NULL
    CONSTRAINT [PK_CartDetail] PRIMARY KEY CLUSTERED ([cartDetailsId] ASC)
    CONSTRAINT [FK_SC106] FOREIGN KEY ([cartId]) REFERENCES [Cart] ([cartId]),
    CONSTRAINT [FK_SC107] FOREIGN KEY ([productId]) REFERENCES [Product] ([productId]))
	
GO

CREATE TABLE ActivationCode
(
	[codeId] UNIQUEIDENTIFIER NOT NULL,
	[productId] INT NOT NULL,
	[customerId] INT NOT NULL
    CONSTRAINT [PK_ActivationCode] PRIMARY KEY CLUSTERED ([codeId] ASC)
    CONSTRAINT [FK_SC108] FOREIGN KEY ([customerId]) REFERENCES [Customer] ([customerId]),
    CONSTRAINT [FK_SC109] FOREIGN KEY ([productId]) REFERENCES [Product] ([productId])	
)

GO


INSERT INTO dbo.[Customer] (customerName,username,password) VALUES
(N'John Tan',N'Jonjon1',N'Jonjon1'),
(N'Mary Lee',N'MerryMarry',N'MerryMarry'),
(N'Peter Mok',N'ThePetrus',N'ThePetrus')

INSERT INTO dbo.[Product](productName,productPrice,productDesc) VALUES
(N'.NET Charts',N'99',N'Brings powerful charting capabilities to your .NET applications.'),
(N'.NET Paypal',N'69',N'Integrate your .NET apps with PayPal the easy way!'),
(N'.NET ML',N'299',N'Supercharged NET machine learning libraries.'),
(N'.NET Analytics',N'299',N'Performs data mining and analytics easily in .NET.'),
(N'.NET Logger',N'49',N'Logs and aggregates events easily in your NET apps.'),
(N'.NET Numerics',N'199',N'Powerful numerical methods for your NET simulations.')
