using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public class Order
    {
        public long Id { get; set; }
        public Offer Offer { get; set; }
        public long OfferId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ReciveTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public User UserId { get; set; }
        public List<Comment> Comments { get; set; }
    }
}