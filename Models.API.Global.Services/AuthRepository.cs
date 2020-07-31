using Models.API.Global.Entities;
using Models.API.Global.Services.Extensions;
using Models.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tools.Database;

namespace Models.API.Global.Services
{
    public class AuthRepository : IAuthRepository
    {
        public Connection _connection;

        public AuthRepository(Connection connection)
        {
            _connection = connection;
        }

        public User Login(string email, string passwd)
        {
            Command command = new Command("Login", true);
            command.AddParameter("Email", email);
            command.AddParameter("Passwd", passwd);

            return _connection.ExecuteReader(command, dr => dr.ToUser()).SingleOrDefault();
        }

        public void Register(User user)
        {
            Command command = new Command("Register", true);
            command.AddParameter("LastName", user.LastName);
            command.AddParameter("FirstName", user.FirstName);
            command.AddParameter("Email", user.Email);
            command.AddParameter("Passwd", user.Passwd);

            _connection.ExecuteNonQuery(command);
        }
    }
}
