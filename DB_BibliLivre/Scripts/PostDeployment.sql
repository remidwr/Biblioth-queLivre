/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
EXEC DB_BibliLivre.dbo.Register @LastName = 'Dewinckeleer', @FirstName = 'Rémi', @Email = 'remidwr@gmail.com', @Passwd = 'Test1234=';

EXEC DB_BibliLivre.dbo.AddAuthor @Name = 'Antoine de Saint-Exupéry';

EXEC DB_BibliLivre.dbo.AddCategory @Name = 'Fable';

EXEC DB_BibliLivre.dbo.AddBook @ISBN = '9782070408504', @Name = 'Le Petit Prince', @Price = 3.70, @Description = 'Le Petit Prince', @Image = '', @Edition = 'Gallimard', @Stock = 10, @AuthorName = 'Antoine de Saint-Exupéry', @CategoryName = 'Fable';
