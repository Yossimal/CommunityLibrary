﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public class Functions
    {
        public void AddUser(User user)
        {
            DataContext dataContext = new DataContext();
            if (!(user.BirthDate < DateTime.Now.AddYears(-13)))
                throw new Exception("error - Age isn't good");

            if (!(Validator.PasswordIsValid(user.Password)))
                throw new Exception("error - password isn't good");

            var addr = new System.Net.Mail.MailAddress(user.EmailAddress);
            if (!(addr.Address == user.EmailAddress))
                throw new Exception("error -  Email address isn't good!");

            if (!(Validator.PhoneIsValid(user.PhoneNumber)))
                throw new Exception("error -  phone number address isn't good!");
            if (dataContext.Users.Any(u => u.UserName == user.UserName))
                throw new Exception("error -  phone number address isn't good!");

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
        public void AddBook()
    }
}