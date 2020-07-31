CREATE PROCEDURE [dbo].[UpdateUser]
    @Id int,
	@LastName nvarchar(50),
	@FirstName nvarchar(50),
	@AddressCity NVARCHAR(50), 
    @AddressStreet NVARCHAR(50), 
    @AddressNumber INT, 
    @AddressZipCode INT,
    @Phone NVARCHAR(50)
AS
BEGIN
	UPDATE Users
	SET
		LastName = @LastName,
        FirstName = @FirstName,
        AddressCity = @AddressCity,
        AddressStreet = @AddressStreet,
        AddressNumber = @AddressNumber,
        AddressZipCode = @AddressZipCode,
        Phone = @Phone
    WHERE Id = @Id;
END