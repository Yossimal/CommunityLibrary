using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public class Functions
    {
        readonly DataContext dataContext = new DataContext();
        public void AddUser(User user)
        {
            if (Validator.AgeIsValid(user.BirthDate)
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
                throw new Exception("id already exist if you would like to update press go back");
            }
        }
        public void AddBook(Book book)
        {
            if (!Validator.NameIsValid(book.Name))
                throw new Exception("error - Book's name isn't valid!");

            if (!Validator.NameIsValid(book.Author))
                throw new Exception("error - Book's author isn't valid!");

            if (!Validator.BarCodeIsValid(book.BarCode))
                throw new Exception("error - Book's barcode isn't valid!");

            try
            {
                dataContext.Books.Add(book);
                dataContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("error - Couln't add the book", e);
            }
        }
    }
}