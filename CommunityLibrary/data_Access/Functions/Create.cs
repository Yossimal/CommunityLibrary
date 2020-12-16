using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public partial class Functions:DalApi
    {

        public void AddUser(User user)
        {
            Validator.TrimObject(user);

            if (Validator.AgeIsValid(user.BirthDate))
                throw new Exception("error - Age is invalid.");

            if (!(Validator.PasswordIsValid(user.Password)))
                throw new Exception("error - password is invalid.");

            if (Validator.MailIsValid(user.UserName))
                throw new Exception("error -  Email address is invalid.");

            if (Validator.PhoneIsValid(user.PhoneNumber))
                throw new Exception("error -  phone number address is invalid.");

            if (Validator.PhoneIsValid(user.UserName))
                throw new Exception("error -  phone number address is invalid.");

            user.FirstName = user.FirstName.Trim();
            if(!Validator.NameIsValid(user.FirstName))
                throw new Exception("error -  first name is invalid.");

            user.LastName = user.LastName.Trim();
            if (!Validator.NameIsValid(user.LastName))
                throw new Exception("error -  last name is invalid.");

            try
            {
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
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            Validator.TrimObject(book);

            if (!Validator.NameIsValid(book.Name))
                throw new Exception("error - Book's name is invalid.");

            if (!Validator.NameIsValid(book.Author))
                throw new Exception("error - Book's author is invalid.");

            if (!Validator.BarCodeIsValid(book.BarCode))
                throw new Exception("error - Book's barcode is invalid.");

            try
            {
                ContextSingelton.Context.Books.Add(book);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("error - Couln't add the book");
            }
        }

        public void AddComment(Comment comment)
        {
            Validator.TrimObject(comment);

            if (!Validator.ContnetIsValid(comment.Content))
                throw new Exception("error - Comment's content is invalid!");

            try
            {
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

            if (!Validator.ContnetIsValid(offer.StatusDescription))
                throw new Exception("error - Offer's status description is invalid");

            try
            {
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