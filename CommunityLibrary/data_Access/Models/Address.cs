using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string Apartment { get; set; }
        public string Enterance { get; set; }
        public string HouseNumber { get; set; }
        public string StreatAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public List<User> UsersInAddress { get; set; }
    }
}