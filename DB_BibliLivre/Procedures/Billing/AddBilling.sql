CREATE PROCEDURE [dbo].[AddBilling]
	@Street NVARCHAR(50), 
    @Number INT, 
    @Box INT, 
    @ZipCode INT,
    @City NVARCHAR(50),
    @UserID INT
AS
BEGIN
	INSERT INTO Billing (Street, Number, Box, ZipCode, City, UserId)
    VALUES (@Street, @Number, @Box, @ZipCode, @City, @UserID);
END