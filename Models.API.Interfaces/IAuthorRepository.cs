using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> Get();
        Author Get(int id);
        void Insert(Author author);
        void Update(int id, Author author);
    }
}
