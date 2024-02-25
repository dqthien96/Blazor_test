CREATE TABLE Books (
    Id INT PRIMARY KEY,
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    Publisher NVARCHAR(100),
    PublishedDate DATE,
    Category NVARCHAR(50),
    Description NVARCHAR(MAX),
    Available BIT
);

CREATE TABLE Users (
    Id INT PRIMARY KEY,
    Username NVARCHAR(50),
    Password NVARCHAR(100),
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Role NVARCHAR(50)
);

CREATE TABLE BorrowingRecords (
    Id INT PRIMARY KEY,
    UserId INT,
    BookId INT,
    BorrowedDate DATE,
    DueDate DATE,
    ReturnedDate DATE,
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (BookId) REFERENCES Books(Id)
);

CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50)
);