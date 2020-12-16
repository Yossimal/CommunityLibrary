using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using data_Access.Models;
using data_Access.Context;


namespace data_Access.Functions
{
    // C# code to validate a password 
    static class Validator
    {

        static DataContext dataContext = new DataContext();


        public static void ValidateUser(User user)
        {
            string exception = "error: ";
            bool foundEx = false;
            if (Validator.AgeIsValid(user.BirthDate))
            {
                exception += "Age is invalid ";
                foundEx = true;
            }

            if (!(Validator.PasswordIsValid(user.Password)))
            {
                exception += "password is invalid ";
                foundEx = true;
            }

            if (Validator.MailIsValid(user.EmailAddress))
            {
                exception += "Email address is invalid ";
                foundEx = true;
            }

            if (Validator.PhoneIsValid(user.PhoneNumber))
            {
                exception += "phone number is invalid ";
                foundEx = true;
            }

            if (Validator.UsernameIsValid(user.UserName))
            {
                exception += "username is invalid ";
                foundEx = true;
            }

            user.FirstName = user.FirstName.Trim();
            if (!Validator.NameIsValid(user.FirstName))
            {
                exception += "first name is invalid ";
                foundEx = true;
            }

            user.LastName = user.LastName.Trim();
            if (!Validator.NameIsValid(user.LastName))
            {
                exception += "last name is invalid ";
                foundEx = true;
            }
            if (foundEx)
                throw new Exception(exception);
        }
        public static void ValidateBook(Book book)
        {
            string exception = "error: ";
            bool foundEx = false;
            if (!Validator.NameIsValid(book.Name))
            {
                exception += "name is invalid ";
                foundEx = true;
            }

            if (!Validator.NameIsValid(book.Author))
            {
                exception += "author is invalid ";
                foundEx = true;
            }

            if (!Validator.BarCodeIsValid(book.BarCode))
            {
                exception += "barcode is invalid ";
                foundEx = true;
            }
            if (foundEx)
                throw new Exception(exception);
        }
        public static void ValidateComment(Comment comment)
        {
            if (!Validator.ContnetIsValid(comment.Content))
                throw new Exception("error: Comment's content is invalid!");
        }
        public static void ValidateOffer(Offer offer) 
        {
            if (!Validator.ContnetIsValid(offer.StatusDescription))
                throw new Exception("error: Offer's status description is invalid");
        }
        public static void ValidateOrder(Order order)
        {
        }

        ///NOT IMPLEMENTED
        public static void ValidateAddress(Address address){  }




        // A utility function to check 
        // whether a password is valid or not 
        public static bool PasswordIsValid(string password)
        {
            if (password.Length < 8 ||
                password.Length > 15) return false;

            bool containsDigits = false;
            bool containsSpecial = false;
            bool containsUpper = false;
            bool containsLower = false;

            foreach (char ch in password)
            {
                if (char.IsWhiteSpace(ch))
                {
                    return false;
                }

                if (char.IsDigit(ch))
                {
                    containsDigits = true;
                    continue;
                }

                if (char.IsLower(ch))
                {
                    containsLower = true;
                    continue;
                }

                if (char.IsUpper(ch))
                {
                    containsUpper = true;
                    continue;
                }

                if (char.IsPunctuation(ch))
                {
                    containsSpecial = true;
                    continue;
                }
            }

            return containsDigits && containsSpecial && containsLower && containsUpper;
        }
        public static bool PhoneIsValid(string s)
        {

            var regex = @"^(?<countryCode>[\+][1-9]{1}[0-9]{0,2}\s)?(?<areaCode>0?[1-9]\d{0,4})(?<number>\s[1-9][\d]{5,12})(?<extension>\sx\d{0,4})?$";

            return (Regex.IsMatch(s, regex));
        }

        public static bool NameIsValid(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        public static bool ContnetIsValid(string content)
        {
            return !string.IsNullOrEmpty(content);
        }

        public static bool UsernameIsValid(string username)
        {
            return dataContext.Users.Any(u => u.UserName == username);
        }

        public static bool MailIsValid(string mail)
        {
            var addr = new System.Net.Mail.MailAddress(mail);
            return addr.Address == mail;
        }

        public static bool AgeIsValid(DateTime age)
        {
            return age < DateTime.Now.AddYears(-13);
        }

        public static bool BarCodeIsValid(string barCode)
        {
            throw new NotImplementedException();
        }

        public static void TrimObject(object obj)
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                var str = prop.GetValue(obj) as string;

                if (str != null) prop.SetValue(obj, str.Trim());
            }
        }
    }
}