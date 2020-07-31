CREATE TABLE [dbo].[MTM_BooksCategory]
(
	[ISBN_Books] NVARCHAR(50) NOT NULL, 
    [Id_Category] INT NOT NULL,
	CONSTRAINT [PK_MTM_BooksCategory] PRIMARY KEY ([ISBN_Books], [Id_Category]), 
    CONSTRAINT [FK_MTM_BooksCategory_Books] FOREIGN KEY ([ISBN_Books]) REFERENCES [Books]([ISBN]), 
    CONSTRAINT [FK_MTM_BooksCategory_Category] FOREIGN KEY ([Id_Category]) REFERENCES [Category]([Id])
)
