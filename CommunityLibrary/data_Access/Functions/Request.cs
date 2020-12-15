using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Context;
using data_Access.Models;

namespace data_Access.Functions
{
    public partial class Functions : DalApi
    {
        public User SearchUser(long id)
        {
            var Find = ContextSingelton.Context.Users.First(user => user.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error user doesn't exist");
        }
        public Book SearchBook(long id)
        {
            var Find = ContextSingelton.Context.Books.First(book => book.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error book doesn't exist");
        }
        public Comment SearchComment(long id)
        {
            var Find = ContextSingelton.Context.Comments.First(comment => comment.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error comment doesn't exist");
        }
        public Offer SearchOffer(long id)
        {
            var Find = ContextSingelton.Context.Offers.First(offer => offer.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error offer doesn't exist");
        }

        public Order SearchOrder(long id)
        {
            var Find = ContextSingelton.Context.Orders.First(order => order.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error order doesn't exist");
        }
        public Address SearchAddress(long id)
        {
            var Find = ContextSingelton.Context.Address.First(address => address.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error address doesn't exist");
        }

    }
}