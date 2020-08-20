CREATE TABLE [dbo].[MTM_BooksAuthor]
(
	[ISBN_Books] NVARCHAR(50) NOT NULL, 
    [Id_Author] INT NOT NULL,
	CONSTRAINT [PK_MTM_BooksAuthor] PRIMARY KEY ([ISBN_Books], [Id_Author]), 
    CONSTRAINT [FK_MTM_BooksAuthor_Books] FOREIGN KEY ([ISBN_Books]) REFERENCES [Books]([ISBN]), 
    CONSTRAINT [FK_MTM_BooksAuthor_Author] FOREIGN KEY ([Id_Author]) REFERENCES [Author]([Id])
)
