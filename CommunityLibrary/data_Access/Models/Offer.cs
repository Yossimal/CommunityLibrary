using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public string StatusDescription { get; set; }
        public User OfferUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int DaysForGive { get; set; }
        public int DaysForReturn { get; set; }
        public List<Comment> Comments { get; set; }
    }
}