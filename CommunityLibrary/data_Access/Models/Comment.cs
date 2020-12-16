using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public enum Reference
    {
        Offer,
        Order
    }
    public class Comment
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long OfferId { get; set; }
        public long OrderId { get; set; }
        public int Rating { get; set; }
        public Reference Reference { get; set; }
        public Offer Offer { get; set; }
        public Order Order { get; set; }
        public string Content { get; set; }
    }
}