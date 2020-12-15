using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Context;
using data_Access.Models;

namespace data_Access.Functions
{
    public class Request
    {
        public User SearchUser(long id)
        {
            return ContextSingelton.Context.Users.First(user=> user.Id == id);
        }
        public Book SearchBook(long id)
        {
            return ContextSingelton.Context.Books.First(book => book.Id == id);
        }
        public Comment SearchComment(long id)
        {
            return ContextSingelton.Context.Comments.First(comment => comment.Id == id);
        }
        public Offer SearchOffer(long id)
        {
            return ContextSingelton.Context.Offers.First(offer => offer.Id == id);
        }

        public Order SearchOrder(long id)
        {
            return ContextSingelton.Context.Orders.First(order => order.Id == id);
        }
        public Address SearchAddress(long id)
        {
            return ContextSingelton.Context.Address.First(address => address.Id == id);
        }

    }
}