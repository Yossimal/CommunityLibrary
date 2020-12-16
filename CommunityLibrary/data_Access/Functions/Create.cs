using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public partial class Functions : DalApi
    {

        public void AddUser(User user)
        {
            Validator.TrimObject(user);
            try
            {
                Validator.ValidateUser(user);
                ContextSingelton.Context.Users.Add(user);
                ContextSingelton.Context.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception("error - Couln't add the user");
            }
        }

        public void AddAddress(Address address)
        {
            Validator.TrimObject(address);
            try
            {
                Validator.ValidateAddress(address);
                ContextSingelton.Context.Address.Add(address);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couln't add the address");
            }
        }

        public void AddBook(Book book)
        {
            Validator.TrimObject(book);
            try
            {
                Validator.ValidateBook(book);
                ContextSingelton.Context.Books.Add(book);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couln't add the book");
            }
        }

        public void AddComment(Comment comment)
        {
            Validator.TrimObject(comment);
            try
            {
                Validator.ValidateComment(comment);   
                ContextSingelton.Context.Comments.Add(comment);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couldn't add the comment");
            }
        }
        public void AddOffer(Offer offer)
        {
            Validator.TrimObject(offer);
            try
            {
                Validator.ValidateOffer(offer);
                ContextSingelton.Context.Offers.Add(offer);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couldn't add the offer");
            }
        }
        public void AddOrder(Order order)
        {
            try
            {
                Validator.ValidateOrder(order);
                ContextSingelton.Context.Orders.Add(order);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couldn't add the order");
            }
        }
    }
}