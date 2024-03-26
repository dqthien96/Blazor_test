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


async + await đặt hàm cho chuẩn có đuôi async
đặt tên entity phải đặt theo số ít
Kiến trúc dự án phần mềm (tìm hiểu thêm)
Nghiên cứu thên EF core:
khái niệm: .net identity framwork (công cụ quản lý user)
tìm hiểu sâu hơn EF Core:
    + Reach Responsitory
    + Unit of Work
tìm hiểu khái niệm Mapping object (Automapper)

Blazor: viết component to be re-Used
.NET:
    + Dependence Injection
    + Reflection