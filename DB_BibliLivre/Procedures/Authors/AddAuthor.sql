CREATE PROCEDURE [dbo].[AddAuthor]
	@Name nvarchar(120)
AS
BEGIN
	INSERT INTO Author ([Name])
	VALUES (@Name);
END