CREATE TABLE Books (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    Publisher NVARCHAR(100),
    PublishedDate DATE,
    Category NVARCHAR(50),
    Description NVARCHAR(MAX),
    Available BIT
);

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50),
    Password NVARCHAR(100),
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Role NVARCHAR(50)
);

CREATE TABLE BorrowingRecords (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT,
    BookId INT,
    BorrowedDate DATE,
    DueDate DATE,
    ReturnedDate DATE,
	Status NVARCHAR(50),
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (BookId) REFERENCES Books(Id)
);

CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50)
);