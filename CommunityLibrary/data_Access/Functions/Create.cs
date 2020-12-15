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
            if (Validator.AgeIsValid(user.BirthDate))
                throw new Exception("error - Age isn't good");
            if (!(Validator.PasswordIsValid(user.Password)))
                throw new Exception("error - password isn't good");
            if (Validator.MailIsValid(user.UserName))
                throw new Exception("error -  Email address isn't good!");
            if (Validator.PhoneIsValid(user.PhoneNumber))
                throw new Exception("error -  phone number address isn't good!");
            if (Validator.PhoneIsValid(user.UserName))
                throw new Exception("error -  phone number address isn't good!");
            if(!Validator.NameIsValid(user.FirstName))
                throw new Exception("error -  first name isn't good!");
            if (!Validator.NameIsValid(user.LastName))
                throw new Exception("error -  last name isn't good!");
            try
            {
                ContextSingelton.Context.Users.Add(user);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("user already exist if you would like to update press go back");
            }
        }

        public void AddComment(Comment comment)
        {
            try
            {
                ContextSingelton.Context.Comments.Add(comment);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("comment already exist if you would like to update press go back");
            }
        }
        public void AddOffer(Offer offer)
        {
            try
            {
                ContextSingelton.Context.Offers.Add(offer);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("offfer already exist if you would like to update press go back");
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
                throw new Exception("order already exist if you would like to update press go back");
            }
        }
    }
}