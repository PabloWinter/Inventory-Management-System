--brand, returned, purchase log, location


DROP TABLE IF EXISTS TBrands
GO

CREATE TABLE TBrands (
    BrandID INT IDENTITY,
	[Name] NVARCHAR(40) NOT NULL
)
GO



DROP TABLE IF EXISTS TLocation
GO

CREATE TABLE TLocation (
	LocationID INT IDENTITY,
	[Name] NVARCHAR(40) NOT NULL,
	[Address] NVARCHAR(70) NOT NULL,
	City NVARCHAR(40) NOT NULL,
	Phone INT NOT NULL,
)
GO



DROP TABLE IF EXISTS TReturned
GO

CREATE TABLE TReturned (
	ProductID INT FOREIGN KEY REFERENCES TProductGroup(BarcodeID),
	LocationID INT FOREIGN KEY REFERENCES TLocation(LocationID),
	Quantity INT NOT NULL
)
GO



DROP TABLE IF EXISTS TPurchaseLog
GO

CREATE TABLE TPurchaseLog (
	TransactionID INT IDENTITY, 
	ProductID INT FOREIGN KEY REFERENCES TProductGroup(BarcodeID),
	LocationID INT FOREIGN KEY REFERENCES TLocation(LocationID),
	[Date] DATETIME2 NOT NULL,
	Quantity INT NOT NULL,
	TotalCost INT NOT NULL
)
GO








