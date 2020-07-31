CREATE TABLE [dbo].[Billing]
(
    [Id] INT NOT NULL IDENTITY,
	[Street] NVARCHAR(50) NOT NULL, 
    [Number] INT NOT NULL, 
    [Box] INT NOT NULL, 
    [ZipCode] INT NOT NULL,
    [City] NVARCHAR(50) NOT NULL,
    [UserId] INT NOT NULL,
    CONSTRAINT [FK_Billing_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]), 
    CONSTRAINT [PK_Billing] PRIMARY KEY ([Id]) 
)
