using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Models.API.Interfaces
{
    public interface IAuthRepository
    {
        User Login(string email, string passwd);
        void Register(User user);
    }
}
