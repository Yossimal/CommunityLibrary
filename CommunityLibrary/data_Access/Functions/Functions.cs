using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.Functions
{
    public class Functions
    {
        public void AddUser(User user)
        {
            if (user.BirthDate < DateTime.Now)
            {
                try
                {
                    
                }
                catch (Exception)
                {
                    throw new Exception("id already exist if you would like to update press go back");
                }
            }
            else
                throw new Exception("error - Age isen't good");
        }
    }
}