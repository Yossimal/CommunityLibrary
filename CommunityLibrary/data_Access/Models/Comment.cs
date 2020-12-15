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
        public long CommentId { get; set; }
        public int Rating { get; set; }
        public Reference Reference { get; set; }
        public string Content { get; set; }
    }
}