using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Global.Entities
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Edition { get; set; }
        public int Stock { get; set; }
    }
}
