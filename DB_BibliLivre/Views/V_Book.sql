CREATE VIEW [dbo].[V_Book]
AS 
	SELECT B.ISBN,
           B.[Name] as BookName, 
           A.[Name] as AuthorName, 
           C.[Name] as CategoryName, 
           B.Price, B.[Description], 
           B.[Image], 
           B.Edition, 
           B.Stock
    FROM Author A 
        JOIN MTM_BooksAuthor BA 
            ON A.Id = BA.Id_Author
        JOIN Books B
            ON BA.ISBN_Books = B.ISBN
        JOIN MTM_BooksCategory BC 
            ON B.ISBN = BC.ISBN_Books
        JOIN Category C 
            ON BC.Id_Category = C.Id;
