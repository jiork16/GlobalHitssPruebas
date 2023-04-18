using System;
using System.Collections.Generic;

#nullable disable

namespace APIRESTHITSS.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Ci { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string HomeAdress { get; set; }
        public string Email { get; set; }
        public string PhoneNumer { get; set; }
        public bool Status { get; set; }
    }
}
