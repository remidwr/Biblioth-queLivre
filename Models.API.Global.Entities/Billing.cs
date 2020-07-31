using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Global.Entities
{
    public class Billing
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int Box { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int UserId { get; set; }
    }
}
