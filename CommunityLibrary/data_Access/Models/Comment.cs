using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public enum refference
    {
        OFFER,
        ORDER
    }
    public class Comment
    {
        public long Id { get; set; }
        public long User_Id { get; set; }
        public long Comment_Id { get; set; }
        public int Rating { get; set; }
        public refference Refference{ get; set; }
        public string Content { get; set; }
    }
}