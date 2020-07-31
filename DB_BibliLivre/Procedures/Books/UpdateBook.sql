CREATE PROCEDURE [dbo].[UpdateBook]
	@ISBN nvarchar(50),
	@Name nvarchar(120),
	@Price money,
	@Description nvarchar(MAX),
	@Image nvarchar(500),
	@Edition nvarchar(120),
	@Stock int
AS
BEGIN
	UPDATE [Books]
	SET [Name] = @Name,
		[Price] = @Price,
		[Description] = @Description,
		[Image] = @Image,
		[Edition] = @Image,
		[Stock] = @Stock
	WHERE [ISBN] = @ISBN;
END
