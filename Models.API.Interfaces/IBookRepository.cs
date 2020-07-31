using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> Get();
        Book Get(int id);
        void Insert(Book book, Author author, Category category);
        void Update(string ISBN, Book book);
        void Delete(string ISBN);
    }
}
