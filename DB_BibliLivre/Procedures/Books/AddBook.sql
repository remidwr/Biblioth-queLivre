CREATE PROCEDURE [dbo].[AddBook]
	@ISBN NVARCHAR(50),
	@Name NVARCHAR(120),
	@Price MONEY,
	@Description NVARCHAR(MAX),
	@Image NVARCHAR(500),
	@Edition NVARCHAR(120),
	@Stock INT,
	@AuthorName NVARCHAR(50),
	@CategoryName NVARCHAR(50)
AS
BEGIN
	INSERT INTO [Books] ([ISBN], [Name], [Price], [Description], [Image], [Edition], [Stock])
	VALUES (@ISBN, @Name, @Price, @Description, @Image, @Edition, @Stock);

	IF((SELECT Id FROM Author WHERE [name] = @AuthorName) is null)
		BEGIN
			INSERT INTO Author ([Name])
			VALUES (@AuthorName);
		END

	DECLARE @AuthorId INT = (SELECT Id FROM Author WHERE [Name] = @AuthorName);

	INSERT INTO MTM_BooksAuthor ([Id_Author], [ISBN_Books])
	VALUES (@AuthorId, @ISBN);

	IF((SELECT Id FROM Category WHERE [Name] = @CategoryName) is null)
		BEGIN
			INSERT INTO Category ([Name])
			VALUES (@CategoryName);
		END
	
	DECLARE @CategoryId INT = (SELECT Id FROM Category WHERE [Name] = @CategoryName);

	INSERT INTO MTM_BooksCategory ([ISBN_Books], [Id_Category])
	VALUES (@ISBN, @CategoryId);
END