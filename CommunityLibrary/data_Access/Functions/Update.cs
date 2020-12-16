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
            try
            {
                Validator.ValidateUser(user);
                ContextSingelton.Context.Entry(user).CurrentValues.SetValues(user);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couln't update the user");
            }
        }
        public void UpdateBook(Book book)
        {
            try
            {
                Validator.ValidateBook(book);
                ContextSingelton.Context.Entry(book).CurrentValues.SetValues(book);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couln't update the book");
            }
        }
        public void UpdateComment(Comment comment)
        {
            try
            {
                Validator.ValidateComment(comment);
                ContextSingelton.Context.Entry(comment).CurrentValues.SetValues(comment);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couldn't update the comment");
            }
        }
        public void UpdateOffer(Offer offer)
        {
            try
            {
                Validator.ValidateOffer(offer);
                ContextSingelton.Context.Entry(offer).CurrentValues.SetValues(offer);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couldn't update the offer");
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                Validator.ValidateOrder(order);
                ContextSingelton.Context.Entry(order).CurrentValues.SetValues(order);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couldn't update the order");
            }
        }
        public void UpdateAddress(Address address)
        {
            try
            {
                Validator.ValidateAddress(address);
                ContextSingelton.Context.Entry(address).CurrentValues.SetValues(address);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couln't add the address");
            }
        }
    }
}