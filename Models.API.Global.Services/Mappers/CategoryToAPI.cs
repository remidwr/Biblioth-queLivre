using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Models.API.Global.Services.Mappers
{
    internal static class CategoryToAPI
    {
        internal static Category ToCategory(this IDataRecord record)
        {
            return new Category()
            {
                Id = (int)record["Id"],
                Name = (string)record["Name"]
            };
        }
    }
}
