using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Models.API.Global.Services.Extensions
{
    internal static class UserToAPI
    {
        internal static User ToUser(this IDataRecord record)
        {
            return new User() 
            { 
                Id = (int)record["Id"], 
                LastName = (string)record["LastName"], 
                FirstName = (string)record["FirstName"], 
                AddressCity = (string)record["AddressCity"], 
                AddressStreet = (string)record["AddressStreet"], 
                AddressNumber = (int)record["AddressNumber"], 
                AddressZipCode = (int)record["AddressZipCode"], 
                Email = (string)record["Email"], 
                Phone = (string)record["Phone"], 
                IsAdmin = (bool)record["IsAdmin"] 
            };
        }
    }
}
