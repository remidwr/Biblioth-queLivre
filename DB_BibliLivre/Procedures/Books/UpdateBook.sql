CREATE PROCEDURE [dbo].[UpdateBook]
	@OldISBN nvarchar(50),
	@NewISBN nvarchar(50),
	@Name nvarchar(120),
	@Price money,
	@Description nvarchar(MAX),
	@Image nvarchar(500),
	@Edition nvarchar(120),
	@Stock int,
	@AuthorName NVARCHAR(50),
	@CategoryName NVARCHAR(50)
AS
BEGIN
	UPDATE [Books]
	SET [ISBN] = @NewISBN,
	    [Name] = @Name,
		[Price] = @Price,
		[Description] = @Description,
		[Image] = @Image,
		[Edition] = @Image,
		[Stock] = @Stock
	WHERE [ISBN] = @OldISBN;


	IF((SELECT Id FROM Author WHERE [Name] = @AuthorName) is null)
		BEGIN
			INSERT INTO Author ([Name])
			VALUES (@AuthorName);
		END

	DECLARE @AuthorId INT = (SELECT Id FROM Author WHERE [Name] = @AuthorName);

	UPDATE MTM_BooksAuthor
	SET [ISBN_Books] = @NewISBN,
		[Id_Author] = @AuthorId
	WHERE [ISBN_Books] = @OldISBN;


	IF((SELECT Id FROM Category WHERE [Name] = @CategoryName) is null)
		BEGIN
			INSERT INTO Category ([Name])
			VALUES (@CategoryName);
		END

	DECLARE @CategoryId INT = (SELECT Id FROM Category WHERE [Name] = @CategoryName);

	UPDATE MTM_BooksCategory
	SET [ISBN_Books] = @NewISBN,
		[Id_Category] = @CategoryId
	WHERE [ISBN_Books] = @OldISBN;
END
