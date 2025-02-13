﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public long LendingCount { get; set; }
        public Roles Role { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
        public enum Roles { Basic, Premium, Administrator }
        public List<Offer> Offers { get; set; }
        public List<Order> Orders { get; set; }
       // public List<Book> Books { get; set; }
        public List<Comment> Comments { get; set; }
    }
}