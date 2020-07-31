CREATE PROCEDURE [dbo].[UpdateCategory]
	@Id INT,
	@Name NVARCHAR(50)
AS
BEGIN
	UPDATE Category
	SET [Name] = @Name
	WHERE Id = @Id;
END
