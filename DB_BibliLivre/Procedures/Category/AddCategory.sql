CREATE PROCEDURE [dbo].[AddCategory]
	@Name NVARCHAR(50)
AS
BEGIN
	INSERT INTO Category ([Name])
	VALUES (@Name);
END