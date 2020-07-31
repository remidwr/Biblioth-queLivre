using Models.API.Global.Entities;
using Models.API.Global.Services.Extensions;
using Models.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Database;

namespace Models.API.Global.Services
{
    public class BookRepository : IBookRepository
    {
        private Connection _connection;

        public BookRepository(Connection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Book> Get()
        {
            Command command = new Command("SELECT B.ISBN, B.[Name] as BookName, A.[Name] as AuthorName, C.[Name] as CategoryName, B.Price, B.[Description], B.[Image], B.Edition, B.Stock FROM Author A JOIN MTM_BooksAuthor BA ON A.Id = BA.Id_Author JOIN Books B ON BA.ISBN_Books = B.ISBN JOIN MTM_BooksCategory BC ON B.ISBN = BC.ISBN_Books JOIN Category C ON BC.Id_Category = C.Id");

            return;
        }

        public Book Get(int id)
        {
            Command command = new Command("");

            return;
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

            _connection.ExecuteNonQuery(command);
        }

        public void Update(string ISBN, Book book)
        {
            Command command = new Command("UpdateBook", true);
            command.AddParameter("ISBN", ISBN);
            command.AddParameter("Name", book.Name);
            command.AddParameter("Price", book.Price);
            command.AddParameter("Description", book.Description);
            command.AddParameter("Image", book.Image);
            command.AddParameter("Edition", book.Description);
            command.AddParameter("Stock", book.Stock);

            _connection.ExecuteNonQuery(command);
        }

        public void Delete(string ISBN)
        {
            Command command = new Command("DeleteBook", true);
            command.AddParameter("ISBN", ISBN);

            _connection.ExecuteNonQuery(command);
        }
    }
}
