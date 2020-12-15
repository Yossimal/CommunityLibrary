using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Context;
using data_Access.Models;
using System.Data.Entity.Migrations;

namespace data_Access.Functions
{
    public partial class Functions : DalApi
    {
        public void UpdateUser(User user)
        {
             ContextSingelton.Context.Entry(user).CurrentValues.SetValues(user);
            ContextSingelton.Context.SaveChanges();
        }
        public Book UpdateBook(Book book)
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