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
        public void UpdateBook(Book book)
        {
            ContextSingelton.Context.Entry(book).CurrentValues.SetValues(book);
            ContextSingelton.Context.SaveChanges();
        }
        public void SearchComment(Comment comment)
        {
            ContextSingelton.Context.Entry(comment).CurrentValues.SetValues(comment);
            ContextSingelton.Context.SaveChanges();
        }
        public void SearchOffer(Offer offer)
        {
            ContextSingelton.Context.Entry(offer).CurrentValues.SetValues(offer);
            ContextSingelton.Context.SaveChanges();
        }

        public void SearchOrder(Order order)
        {
            ContextSingelton.Context.Entry(order).CurrentValues.SetValues(order);
            ContextSingelton.Context.SaveChanges();
        }
        public void SearchAddress(Address address)
        {
            ContextSingelton.Context.Entry(address).CurrentValues.SetValues(address);
            ContextSingelton.Context.SaveChanges();
        }
    }
}