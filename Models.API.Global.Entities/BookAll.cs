using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Models.API.Global.Entities
{
    public class BookAll
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Edition { get; set; }
        public int Stock { get; set; }
    }
}
