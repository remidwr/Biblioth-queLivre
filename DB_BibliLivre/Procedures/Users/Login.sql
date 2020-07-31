CREATE PROCEDURE [dbo].[Login]
	@Email nvarchar(320),
	@Passwd nvarchar(20)
AS
BEGIN
	SELECT [Id], [LastName], [FirstName], [AddressCity], [AddressStreet], [AddressNumber], [AddressZipCode], [Email], [Passwd], [Phone], [IsAdmin]
	FROM [Users]
	WHERE Email = @Email AND Passwd = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Passwd + dbo.GetPostSalt());
END