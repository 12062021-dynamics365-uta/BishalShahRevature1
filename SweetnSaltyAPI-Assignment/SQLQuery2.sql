CREATE DATABASE SweetnSaltyAPI;


CREATE TABLE Person
(
personID INT PRIMARY KEY,
firstName nvarchar(100) NOT NULL,
lastName nvarchar(100) NOT NULL
);

CREATE TABLE Flavors
(
flavorID INT PRIMARY KEY IDENTITY,
flavorName nvarchar(100) NOT NUll
);

CREATE TABLE PersonFlavorJunction
(
personID INT FOREIGN KEY REFERENCES Person(personID) ON DELETE CASCADE,
flavorID INT FOREIGN KEY REFERENCES Flavors(flavorID) ON DELETE CASCADE
);

