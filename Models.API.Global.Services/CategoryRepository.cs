using Models.API.Global.Entities;
using Models.API.Global.Services.Mappers;
using Models.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Tools.Database;

namespace Models.API.Global.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private Connection _connection;

        public CategoryRepository(Connection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Category> GET()
        {
            Command command = new Command(
                "SELECT Id, [Name]" +
                "FROM Category"
                );

            return _connection.ExecuteReader(command, dr => dr.ToCategory());
        }

        public Category Get(int id)
        {
            Command command = new Command(
                "SELECT Id, [Name]" +
                "FROM Author" +
                "WHERE Id = @Id"
                );
            command.AddParameter("Id", id);

            return _connection.ExecuteReader(command, dr => dr.ToCategory()).SingleOrDefault();
        }

        public void Insert(Category category)
        {
            Command command = new Command("AddCategory", true);
            command.AddParameter("Name", category.Name);

            _connection.ExecuteNonQuery(command);
        }

        public void Update(int id, Category category)
        {
            Command command = new Command("UpdateCategory", true);
            command.AddParameter("Id", id);
            command.AddParameter("Name", category.Name);

            _connection.ExecuteNonQuery(command);
        }
    }
}
