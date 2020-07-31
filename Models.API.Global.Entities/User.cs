using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Models.API.Global.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public int AddressNumber { get; set; }
        public int AddressZipCode { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
    }
}
