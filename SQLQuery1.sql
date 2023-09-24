CREATE TABLE Customer(
	CustomerId INT PRIMARY KEY IDENTITY(1, 1),
	CustomerName VARCHAR(50) NOT NULL,
	CustomerEmail VARCHAR(50) NOT NULL,
	CustomerPassword VARCHAR(50) NOT NULL,
	CustomerGender VARCHAR(6) NOT NULL,
	CustomerAddress VARCHAR(100) NOT NULL,
	CustomerRole VARCHAR(15) NOT NULL,
)

CREATE TABLE TransactionHeader(
	TransactionId INT PRIMARY KEY IDENTITY (1, 1),
	TransactionDate DATE NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES[Customer](CustomerId),
)

CREATE TABLE Artist(
	ArtistId INT PRIMARY KEY IDENTITY(1, 1),
	ArtistName VARCHAR(50) NOT NULL,
	ArtistImage VARCHAR(50) NOT NULL,
)

CREATE TABLE Album(
	AlbumId INT PRIMARY KEY IDENTITY(1, 1),
	ArtistId INT FOREIGN KEY REFERENCES[Artist](ArtistId),
	AlbumName VARCHAR(50) NOT NULL,
	AlbumImage VARCHAR(50) NOT NULL,
	AlbumPrice INT NOT NULL,
	AlbumStock INT NOT NULL,
	AlbumDescription VARCHAR(225) NOT NULL,
)

CREATE TABLE Cart(
	CustomerId INT FOREIGN KEY REFERENCES[Customer](CustomerId),
	AlbumId INT FOREIGN KEY REFERENCES[Album](AlbumId),
	Qty INT NOT NULL,
	PRIMARY KEY(CustomerId, AlbumId)
)

CREATE TABLE TransactionDetail(
	TransactionId INT FOREIGN KEY REFERENCES[TransactionHeader](TransactionId),
	AlbumId INT FOREIGN KEY REFERENCES[Album](AlbumId),
	Qty INT NOT NULL,
	PRIMARY KEY(TransactionId, AlbumId)
)