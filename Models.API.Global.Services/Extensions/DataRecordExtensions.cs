using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Models.API.Global.Services.Extensions
{
    internal static class DataRecordExtensions
    {
        internal static User ToUser(this IDataRecord record)
        {
            return new User() { Id = (int)record["Id"], LastName = (string)record["LastName"], FirstName = (string)record["FirstName"], AddressCity = (string)record["AddressCity"], AddressStreet = (string)record["AddressStreet"], AddressNumber = (int)record["AddressNumber"], AddressZipCode = (int)record["AddressZipCode"], Email = (string)record["Email"], Phone = (string)record["Phone"], IsAdmin = (bool)record["IsAdmin"] };
        }

        internal static Book ToBook(this IDataRecord record)
        {
            return new Book() { ISBN = (string)record["ISBN"], Name = (string)record["Name"], Price = (double)record["Price"], Description = (string)record["Description"], Image = (string)record["Image"], Edition = (string)record["Edition"], Stock = (int)record["Stock"] };
        }
    }
}
