using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public class Create
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
                dataContext.Users.Add(user);
                dataContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("user already exist if you would like to update press go back");
            }
        }
        public void AddBook();

        public void AddComment(Comment comment)
        {
            try
            {
                dataContext.Comments.Add(comment);
                dataContext.SaveChanges();
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
                dataContext.Offers.Add(offer);
                dataContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("offfer already exist if you would like to update press go back");
            }
        }
        public void AddOrder(Offer order)
        {
            try
            {
                dataContext.Offers.Add(order);
                dataContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("order already exist if you would like to update press go back");
            }
        }
    }
}