using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public long Bar_Code { get; set; }
        public List<Order> Orders_List { get; set; }
        public List<Offer> Offers_List { get; set; }


    }
}