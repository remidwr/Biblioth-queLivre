using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.API.Global.Services.Mappers
{
    internal static class AuthorToAPI
    {
        internal static Author ToAuthor(this IDataRecord record)
        {
            return new Author()
            {
                Id = (int)record["Id"],
                Name = (string)record["Name"]
            };
        }
    }
}
