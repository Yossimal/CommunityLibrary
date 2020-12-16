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
        public void DeleteUser(long id)
        {
            var Del = ContextSingelton.Context.Users.First(user => user.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Users.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  user doesn't exist");
        }
        public void DeleteBook(long id)
        {
            var Del = ContextSingelton.Context.Books.First(book => book.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Books.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  book doesn't exist");
        }
        public void DeleteComment(long id)
        {
            var Del = ContextSingelton.Context.Comments.First(comment => comment.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Comments.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  comment doesn't exist");
        }
        public void DeleteOffer(long id)
        {
            var Del = ContextSingelton.Context.Offers.First(offer => offer.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Offers.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  offer doesn't exist");
        }

        public void DeleteOrder(long id)
        {
            var Del = ContextSingelton.Context.Orders.First(order => order.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Orders.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  order doesn't exist");
        }
        public void DeleteAddress(long id)
        {
            var Del = ContextSingelton.Context.Address.First(address => address.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Address.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  address doesn't exist");
        }
    }
}