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
    public class AuthorRepository : IAuthorRepository
    {
        private Connection _connection;

        public AuthorRepository(Connection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Author> Get()
        {
            Command command = new Command(
                "SELECT Id, [Name]" +
                "FROM Author"
                );

            return _connection.ExecuteReader(command, dr => dr.ToAuthor());
        }

        public Author Get(int id)
        {
            Command command = new Command(
                "SELECT Id, [Name]" +
                "FROM Author" +
                "WHERE Id = @Id"
                );
            command.AddParameter("Id", id);

            return _connection.ExecuteReader(command, dr => dr.ToAuthor()).SingleOrDefault();
        }

        public void Insert(Author author)
        {
            Command command = new Command("AddAuthor", true);
            command.AddParameter("Name", author.Name);

            _connection.ExecuteNonQuery(command);
        }

        public void Update(int id, Author author)
        {
            Command command = new Command("UpdateAuthor", true);
            command.AddParameter("Id", id);
            command.AddParameter("Name", author.Name);

            _connection.ExecuteNonQuery(command);
        }
    }
}
