CREATE PROCEDURE [dbo].[DeleteAuthor]
	@Id int
AS
BEGIN
	DELETE FROM Author
	WHERE Id = @Id;
END