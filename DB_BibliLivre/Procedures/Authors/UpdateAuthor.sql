CREATE PROCEDURE [dbo].[UpdateAuthor]
	@Id int,
	@Name nvarchar(120)
AS
BEGIN
	UPDATE Author
	SET [Name] = @Name
	WHERE Id = @Id;
END