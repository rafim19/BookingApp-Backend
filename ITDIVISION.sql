CREATE DATABASE ProjectAkhirITDiv
USE ProjectAkhirITDiv
-- DROP DATABASE ProjectAkhirITDiv

BEGIN TRAN
CREATE TABLE msCustomer (
	CustomerID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Gender CHAR(6) CHECK(Gender IN('MALE','FEMALE'))NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) UNIQUE NOT NULL,
	DateOfBirth DATE,
	Stsrc CHAR(1) NOT NULL,
	UserIn VARCHAR(50) NOT NULL,
	UserUp VARCHAR(50) NULL,
	DateIn DATETIME NOT NULL,
	DateUp DATETIME NULL
)
-- DROP TABLE msCustomer

CREATE TABLE msHotel (
	HotelID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	HotelName VARCHAR (50) NOT NULL,
	HotelDescription VARCHAR (50) NOT NULL,
	PhoneNumber VARCHAR (50) UNIQUE NOT NULL,
	Email VARCHAR (50) UNIQUE NOT NULL,
	[Address] VARCHAR (50) NOT NULL,
	[Rating] FLOAT NOT NULL,
	[Image] VARCHAR (50) NOT NULL,
	Stsrc CHAR(1) NOT NULL,
	UserIn VARCHAR(50) NOT NULL,
	UserUp VARCHAR(50) NULL,
	DateIn DATETIME NOT NULL,
	DateUp DATETIME NULL
)
-- DROP TABLE msHotel

CREATE TABLE msRoom (
	RoomID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	HotelID INT FOREIGN KEY REFERENCES msHotel(HotelID) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
	RoomDescription VARCHAR(50) NOT NULL,
	Price INT NOT NULL,
	RoomAvailable VARCHAR(15) NOT NULL,
	RoomType VARCHAR(15) NOT NULL,
	RoomBook VARCHAR (15) NOT NULL,
	[Image] VARCHAR(50) NOT NULL,
	Stsrc CHAR(1) NOT NULL,
	UserIn VARCHAR(50) NOT NULL,
	UserUp VARCHAR(50) NULL,
	DateIn DATETIME NOT NULL,
	DateUp DATETIME NULL
)
-- DROP TABLE msRoom

CREATE TABLE trCustomerBooking (
	BookingID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	CustomerID INT REFERENCES msCustomer(CustomerID) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
	RoomID INT REFERENCES msRoom(RoomID) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
	BookingDate DATE NOT NULL,
	TotalPrice INT NOT NULL,
	BookingStatus VARCHAR(50) NOT NULL,
	CheckInDate DATETIME NOT NULL,
	CheckOutDate DATETIME NOT NULL,
	TotalNights VARCHAR (10) NOT NULL,
	Stsrc CHAR(1) NOT NULL,
	UserIn VARCHAR(50) NOT NULL,
	UserUp VARCHAR(50) NULL,
	DateIn DATETIME NOT NULL,
	DateUp DATETIME NULL
)
-- DROP TABLE trCustomerBooking

CREATE TABLE trCustomerPayment (
	PaymentID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	BookingID INT REFERENCES trCustomerBooking(BookingID) ON UPDATE CASCADE ON DELETE CASCADE,
	CustomerID INT REFERENCES msCustomer(CustomerID) ON UPDATE CASCADE ON DELETE CASCADE,
	PaymentMethod VARCHAR(50) NOT NULL,
	PaymentAmount INT NOT NULL,
	PaymentDate DATE NOT NULL,
	Stsrc CHAR(1) NOT NULL,
	UserIn VARCHAR(50) NOT NULL,
	UserUp VARCHAR(50) NULL,
	DateIn DATETIME NOT NULL,
	DateUp DATETIME NULL
)
-- DROP TABLE trCustomerPayment

--INSERT DATA

INSERT INTO msCustomer (
	FirstName, 
	LastName, 
	Gender, 
	Email, 
	[Password], 
	Phone, 
	DateOfBirth, 
	Stsrc, UserIn, 
	DateIn) 
VALUES
(
	'Jessica', 'Jane', 'FEMALE', 'jessicajane@gmail.com', 
	'jj123', '08788901929', '1999-02-19', 'A', ORIGINAL_LOGIN(), GETDATE()
);

INSERT INTO msHotel (
	HotelName,
	HotelDescription,
	PhoneNumber,
	Email,
	[Address],
	Rating,
	[Image],
	Stsrc,
	UserIn,
	DateIn
)
VALUES
(
	'Royal Safari Garden', 'Description', '02518253000', 'reservation@royalsafari.com', 
	'Cisarua', '90', 'LinkImage', 'A', ORIGINAL_LOGIN(), GETDATE()
);

INSERT INTO msRoom (
	HotelID,
	RoomDescription,
	Price,
	RoomAvailable,
	RoomType,
	RoomBook,
	[Image],
	Stsrc,
	UserIn,
	DateIn
)
VALUES
(
	'1', '', '1000000', '10', 'Deluxe', '5', 'LinkImage', 'A', ORIGINAL_LOGIN(), GETDATE()
);

INSERT INTO trCustomerBooking (
	CustomerID,
	RoomID,
	BookingDate,
	TotalPrice,
	BookingStatus,
	CheckInDate,
	CheckOutDate,
	TotalNights,
	Stsrc,
	UserIn,
	DateIn
)
VALUES
(
	'1', '1', '2021-04-20', '2000000', 'BOOKED', '2021-04-22 13:17:17', 
	'2021-04-24 13:00:05', '2', 'A', ORIGINAL_LOGIN(), GETDATE()
);

INSERT INTO trCustomerPayment (
	BookingID,
	CustomerID,
	PaymentMethod,
	PaymentAmount,
	PaymentDate,
	Stsrc,
	UserIn,
	DateIn
)
VALUES
(
	'1', '1', 'BCA Transfer', '2000000', '2021-04-20', 'A', ORIGINAL_LOGIN(), GETDATE()
);

ROLLBACK
SELECT * FROM msCustomer
SELECT * FROM trCustomerBooking
SELECT * FROM msRoom
SELECT * FROM msHotel
SELECT * FROM trCustomerPayment