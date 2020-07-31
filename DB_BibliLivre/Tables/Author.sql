CREATE TABLE [dbo].[Author]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(120) NOT NULL, 
    CONSTRAINT [PK_Author] PRIMARY KEY ([Id]), 
    CONSTRAINT [UK_Author_Name] UNIQUE ([Name])
)
