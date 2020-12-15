using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Context;
using data_Access.Models;

namespace data_Access.Functions
{
    public class Delete
    {
        public void DeleteUser(long id)
        {
            ContextSingelton.Context.Users.Remove(ContextSingelton.Context.Users.First(user => user.Id == id));
        }
        public void DeleteBook(long id)
        {
            ContextSingelton.Context.Books.Remove(ContextSingelton.Context.Books.First(book => book.Id == id));
        }
        public void DeleteComment(long id)
        {
            ContextSingelton.Context.Comments.Remove(ContextSingelton.Context.Comments.First(comment => comment.Id == id));
        }
        public void DeleteOffer(long id)
        {
            ContextSingelton.Context.Offers.Remove(ContextSingelton.Context.Offers.First(offer => offer.Id == id));
        }

        public void DeleteOrder(long id)
        {
            ContextSingelton.Context.Orders.Remove(ContextSingelton.Context.Orders.First(order => order.Id == id));
        }
        public void DeleteAddress(long id)
        {
            ContextSingelton.Context.Address.Remove(ContextSingelton.Context.Address.First(address => address.Id == id));
        }
    }
}