USE [Library_data]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (1, N'The Great Gatsby', N'F. Scott Fitzgerald', N'Charles Scribner''s Sons', CAST(N'1925-04-10' AS Date), N'Fiction', N'A novel depicting the glamorous and decadent lifestyle of the wealthy during the Jazz Age in America.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (2, N'To Kill a Mockingbird', N'Harper Lee', N'J.B. Lippincott & Co.', CAST(N'1960-07-11' AS Date), N'Fiction', N'A novel set in the American South during the 1930s, addressing racial injustice and moral growth.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (3, N'1984', N'George Orwell', N'Secker & Warburg', CAST(N'1949-06-08' AS Date), N'Science Fiction', N'A dystopian novel depicting a totalitarian regime where individualism is suppressed and reality is controlled by the government.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (4, N'Pride and Prejudice', N'Jane Austen', N'T. Egerton, Whitehall', CAST(N'1813-01-28' AS Date), N'Fiction', N'A classic romance novel revolving around the lives of the Bennet sisters and their pursuit of love and marriage in early 19th-century England.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (5, N'The Catcher in the Rye', N'J.D. Salinger', N'Little, Brown and Company', CAST(N'1951-07-16' AS Date), N'Fiction', N'A coming-of-age novel narrated by Holden Caulfield, a disillusioned teenager who struggles with conformity and phoniness in society.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (6, N'Animal Farm', N'George Orwell', N'Secker & Warburg', CAST(N'1945-08-17' AS Date), N'Fiction', N'A political allegory depicting the events leading up to the Russian Revolution and the subsequent rise of Stalinism.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (7, N'The Hobbit', N'J.R.R. Tolkien', N'George Allen & Unwin', CAST(N'1937-09-21' AS Date), N'Fantasy', N'A fantasy novel following the journey of Bilbo Baggins as he embarks on an epic quest to reclaim the Lonely Mountain and its treasure from the dragon Smaug.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (8, N'Brave New World', N'Aldous Huxley', N'Chatto & Windus', CAST(N'1932-10-07' AS Date), N'Science Fiction', N'A dystopian novel set in a futuristic World State where genetic engineering, psychological conditioning, and recreational drug use are used to maintain social stability.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (9, N'Lord of the Flies', N'William Golding', N'Faber and Faber', CAST(N'1954-09-17' AS Date), N'Fiction', N'A novel exploring the dark side of human nature as a group of British boys stranded on a deserted island descend into savagery and violence.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (10, N'The Lord of the Rings', N'J.R.R. Tolkien', N'George Allen & Unwin', CAST(N'1954-07-29' AS Date), N'Fantasy', N'An epic high fantasy trilogy following the quest to destroy the One Ring and defeat the Dark Lord Sauron.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (11, N'The Da Vinci Code', N'Dan Brown', N'Doubleday', CAST(N'2003-03-18' AS Date), N'Thriller', N'A mystery thriller novel following symbologist Robert Langdon as he investigates a murder in the Louvre Museum and unravels a secret society and a hidden message within Leonardo da Vinci''s works.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (12, N'Harry Potter and the Philosopher''s Stone', N'J.K. Rowling', N'Bloomsbury', CAST(N'1997-06-26' AS Date), N'Fantasy', N'The first book in the Harry Potter series, following the young wizard Harry Potter as he discovers his magical heritage and attends Hogwarts School of Witchcraft and Wizardry.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (13, N'The Road', N'Cormac McCarthy', N'Alfred A. Knopf', CAST(N'2006-09-26' AS Date), N'Fiction', N'A post-apocalyptic novel following a father and son as they journey across a desolate landscape in a desperate quest for survival.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (14, N'The Great Expectations', N'Charles Dickens', N'Chapman & Hall', CAST(N'1861-08-01' AS Date), N'Fiction', N'A bildungsroman following the life of an orphan named Pip as he encounters various characters and experiences both fortune and misfortune in Victorian England.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (15, N'The Alchemist ', N'Paulo Coelho', N'HarperCollins', CAST(N'1988-01-01' AS Date), N'Fiction', N'A philosophical novel following the journey of Santiago, a shepherd boy, as he travels from Spain to Egypt in pursuit of his Personal Legend.', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (16, N'test', N'test', N'test', CAST(N'2023-05-05' AS Date), N'Travel', N'this is the test description', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (17, N'test', N'a', N'a', CAST(N'2023-06-03' AS Date), N'Historical fiction', N'ABCD', 1)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Publisher], [PublishedDate], [Category], [Description], [Available]) VALUES (18, N'This is sparta', N'This is sparta', N'This is sparta', CAST(N'2023-06-03' AS Date), N'Fantasy', N'This is sparta', 1)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (1, N'user1', N'12345', N'User One', N'user1@example.com', N'Member')
INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (2, N'user2', N'12345', N'User Two', N'user2@example.com', N'Member')
INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (3, N'admin', N'12345', N'Admin User', N'admin@example.com', N'Admin')
INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (4, N'user3', N'12345', N'Nguyễn Văn A', N'A@gmail.com', N'Member')
INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (5, N'user4', N'12345', N'Nguyễn Văn B', N'B@gmail.com', N'Member')
INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (6, N'user5', N'12345', N'Nguyễn Văn A', N'A@gmail.com', N'Member')
INSERT [dbo].[Users] ([Id], [Username], [Password], [FullName], [Email], [Role]) VALUES (7, N'user7', N'12345', N'AAA', N'A@gmail.com', N'Member')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[BorrowingRecords] ON 

INSERT [dbo].[BorrowingRecords] ([Id], [UserId], [BookId], [BorrowedDate], [DueDate], [ReturnedDate], [Status]) VALUES (9, 1, 14, CAST(N'2024-03-09' AS Date), CAST(N'2024-03-15' AS Date), NULL, N'Checkout')
INSERT [dbo].[BorrowingRecords] ([Id], [UserId], [BookId], [BorrowedDate], [DueDate], [ReturnedDate], [Status]) VALUES (12, 6, 13, CAST(N'2024-03-09' AS Date), CAST(N'2024-04-05' AS Date), NULL, N'Checkout')
INSERT [dbo].[BorrowingRecords] ([Id], [UserId], [BookId], [BorrowedDate], [DueDate], [ReturnedDate], [Status]) VALUES (14, 6, 5, CAST(N'2024-03-09' AS Date), CAST(N'2024-04-02' AS Date), NULL, N'Checkout')
INSERT [dbo].[BorrowingRecords] ([Id], [UserId], [BookId], [BorrowedDate], [DueDate], [ReturnedDate], [Status]) VALUES (16, 6, 1, CAST(N'2024-03-09' AS Date), CAST(N'2024-06-05' AS Date), NULL, N'Checkout')
INSERT [dbo].[BorrowingRecords] ([Id], [UserId], [BookId], [BorrowedDate], [DueDate], [ReturnedDate], [Status]) VALUES (17, 1, NULL, CAST(N'0001-01-01' AS Date), CAST(N'0001-01-01' AS Date), NULL, N'Normal')
INSERT [dbo].[BorrowingRecords] ([Id], [UserId], [BookId], [BorrowedDate], [DueDate], [ReturnedDate], [Status]) VALUES (18, 1, 18, CAST(N'2024-03-09' AS Date), CAST(N'2023-05-05' AS Date), NULL, N'Checkout')
SET IDENTITY_INSERT [dbo].[BorrowingRecords] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Fiction')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Non-fiction')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Mystery')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Thriller')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Romance')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'Science fiction (Sci-Fi)')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (7, N'Fantasy')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (8, N'Historical fiction')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (9, N'Biography')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (10, N'Autobiography')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (11, N'Self-help')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (12, N'Travel')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (13, N'Poetry')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (14, N'Drama')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (15, N'Horror')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (16, N'Comedy')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (17, N'Children''s literature')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (18, N'Young adult (YA) fiction')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (19, N'Graphic novels/comics')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (20, N'Memoir')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
