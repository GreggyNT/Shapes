CREATE DATABASE ProductDatabase;
GO

USE ProductDatabase;
GO

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductID INT NOT NULL,
    CategoryID INT NOT NULL,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Products (ProductName) VALUES
	('p1'),
	('p2'),
	('p3')

INSERT INTO Categories (CategoryName) VALUES
	('c1'),
	('c2')

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
    (1, 1),
    (1, 2), 
    (2, 1); 

SELECT
    p.ProductName,
    c.CategoryName
FROM
    Products p
LEFT JOIN
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN
    Categories c ON pc.CategoryID = c.CategoryID;
