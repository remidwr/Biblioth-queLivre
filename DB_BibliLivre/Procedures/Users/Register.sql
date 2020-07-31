CREATE PROCEDURE [dbo].[Register]
	@LastName nvarchar(50),
	@FirstName nvarchar(50),
	@Email nvarchar(320),
	@Passwd nvarchar(20)
AS
BEGIN
	Declare @IsAdmin BIT = 0;

	IF (NOT EXISTS(SELECT * FROM [Users]))
	BEGIN
		SET @IsAdmin = 1;
	END

	INSERT INTO [Users] ([LastName], [FirstName], [Email], [Passwd], [IsAdmin])
	VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Passwd + dbo.GetPostSalt()), @IsAdmin);
END