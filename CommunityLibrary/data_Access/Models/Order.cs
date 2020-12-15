using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Models
{
    public class Order
    {
        public long Id { get; set; }
        public Offer Order_Id { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime Recive_Time { get; set; }
        public DateTime Return_Time { get; set; }
        public User User_Id { get; set; }
        public List<Order> User_Orders_List { get; set; }
        public List<Order> Offer_Orders_List { get; set; }
        public List<Comment> Order_Comments_List { get; set; }
    }
}