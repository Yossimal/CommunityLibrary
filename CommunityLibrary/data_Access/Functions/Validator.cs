using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace data_Access.Functions
{

    // C# code to validate a password 
    class Validator
    {

        // A utility function to check 
        // whether a password is valid or not 
        public static bool PasswordIsValid(String password)
        {

            // for checking if password length 
            // is between 8 and 15 
            if (!((password.Length >= 8)
                && (password.Length <= 15)))
            {
                return false;
            }

            // to check space 
            if (password.Contains(" "))
            {
                return false;
            }
            if (true)
            {
                int count = 0;

                // check digits from 0 to 9 
                for (int i = 0; i <= 9; i++)
                {

                    // to convert int to string 
                    String str1 = i.ToString();

                    if (password.Contains(str1))
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
            }

            // for special characters 
            if (!(password.Contains("@") || password.Contains("#")
                || password.Contains("!") || password.Contains("~")
                || password.Contains("$") || password.Contains("%")
                || password.Contains("^") || password.Contains("&")
                || password.Contains("*") || password.Contains("(")
                || password.Contains(")") || password.Contains("-")
                || password.Contains("+") || password.Contains("/")
                || password.Contains(":") || password.Contains(".")
                || password.Contains(", ") || password.Contains("<")
                || password.Contains(">") || password.Contains("?")
                || password.Contains("|")))
            {
                return false;
            }

            if (true)
            {
                int count = 0;

                // checking capital letters 
                for (int i = 65; i <= 90; i++)
                {

                    // type casting 
                    char c = (char)i;

                    String str1 = c.ToString();
                    if (password.Contains(str1))
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
            }

            if (true)
            {
                int count = 0;

                // checking small letters 
                for (int i = 90; i <= 122; i++)
                {

                    // type casting 
                    char c = (char)i;
                    String str1 = c.ToString();

                    if (password.Contains(str1))
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
            }

            // if all conditions fails 
            return true;
        }
        public static bool PhoneIsValid(String s)
        {

            var regex = @"^(?<countryCode>[\+][1-9]{1}[0-9]{0,2}\s)?(?<areaCode>0?[1-9]\d{0,4})(?<number>\s[1-9][\d]{5,12})(?<extension>\sx\d{0,4})?$";

            return (Regex.IsMatch(s, regex));
        }
    }
}