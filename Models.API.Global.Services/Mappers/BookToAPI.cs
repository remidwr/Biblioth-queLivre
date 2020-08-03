using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.API.Global.Services.Mappers
{
    internal static class BookToAPI
    {
        internal static Book ToBook(this IDataRecord record)
        {
            return new Book()
            {
                ISBN = (string)record["ISBN"],
                Name = (string)record["Name"],
                Price = (double)record["Price"],
                Description = (string)record["Description"],
                Image = (string)record["Image"],
                Edition = (string)record["Edition"],
                Stock = (int)record["Stock"]
            };
        }

        internal static BookAll ToBookAll(this IDataRecord record)
        {
            return new BookAll()
            {
                ISBN = (string)record["ISBN"],
                Name = (string)record["Name"],
                AuthorName = (string)record["AuthorName"],
                CategoryName = (string)record["CategoryName"],
                Price = (double)record["Price"],
                Description = (string)record["Description"],
                Image = (string)record["Image"],
                Edition = (string)record["Edition"],
                Stock = (int)record["Stock"]
            };
        }
    }
}
