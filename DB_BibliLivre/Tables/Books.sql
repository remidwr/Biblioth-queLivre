CREATE TABLE [dbo].[Books]
(
	[ISBN] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(120) NOT NULL,
    [Price] MONEY NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Image] NVARCHAR(500) NOT NULL, 
    [Edition] NVARCHAR(120) NOT NULL, 
    [Stock] INT NOT NULL, 
    CONSTRAINT [PK_Livres] PRIMARY KEY ([ISBN]), 
    CONSTRAINT [UK_Books_Name] UNIQUE ([Name]) 
)
