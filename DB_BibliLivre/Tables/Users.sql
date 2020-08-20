CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL IDENTITY, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL,
    [AddressCity] NVARCHAR(50) NULL, 
    [AddressStreet] NVARCHAR(50) NULL, 
    [AddressNumber] INT NULL, 
    [AddressZipCode] INT NULL, 
    [Email] NVARCHAR(320) NOT NULL, 
    [Passwd] BINARY(64) NOT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [IsAdmin] BIT NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]), 
    CONSTRAINT [UK_Users_Email] UNIQUE ([Email]) 
)
