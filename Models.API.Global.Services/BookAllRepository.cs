using Models.API.Global.Entities;
using Models.API.Global.Services.Mappers;
using Models.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Database;

namespace Models.API.Global.Services
{
    public class BookAllRepository : IBookAllRepository
    {
        private Connection _connection;

        public BookAllRepository(Connection connection)
        {
            _connection = connection;
        }

        public IEnumerable<BookAll> Get()
        {
            Command command = new Command(
                "SELECT B.ISBN, B.[Name] as BookName, A.[Name] as AuthorName, C.[Name] as CategoryName, B.Price, B.[Description], B.[Image], B.Edition, B.Stock " +
                "FROM Author A " +
                "JOIN MTM_BooksAuthor BA ON A.Id = BA.Id_Author " +
                "JOIN Books B ON BA.ISBN_Books = B.ISBN " +
                "JOIN MTM_BooksCategory BC ON B.ISBN = BC.ISBN_Books " +
                "JOIN Category C ON BC.Id_Category = C.Id;"
                );

            return _connection.ExecuteReader(command, dr => dr.ToBookAll());
        }

        public BookAll Get(string ISBN)
        {
            Command command = new Command(
                "SELECT B.ISBN, B.[Name] as BookName, A.[Name] as AuthorName, C.[Name] as CategoryName, B.Price, B.[Description], B.[Image], B.Edition, B.Stock " +
                "FROM Author A " +
                "JOIN MTM_BooksAuthor BA ON A.Id = BA.Id_Author " +
                "JOIN Books B ON BA.ISBN_Books = B.ISBN " +
                "JOIN MTM_BooksCategory BC ON B.ISBN = BC.ISBN_Books " +
                "JOIN Category C ON BC.Id_Category = C.Id " +
                "WHERE B.ISBN = @ISBN;"
                );
            command.AddParameter("ISBN", ISBN);

            return _connection.ExecuteReader(command, dr => dr.ToBookAll()).SingleOrDefault();
        }

        public void Insert(Book book, Author author, Category category)
        {
            Command command = new Command("AddBook", true);
            command.AddParameter("ISBN", book.ISBN);
            command.AddParameter("Name", book.Name);
            command.AddParameter("Price", book.Price);
            command.AddParameter("Description", book.Description);
            command.AddParameter("Image", book.Image);
            command.AddParameter("Edition", book.Edition);
            command.AddParameter("Stock", book.Stock);
            command.AddParameter("AuthorName", author.Name);
            command.AddParameter("CategoryName", category.Name);
        }

        public void Update(string ISBN, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
