using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.App_Code
{
    public class DataContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> 
    }
}