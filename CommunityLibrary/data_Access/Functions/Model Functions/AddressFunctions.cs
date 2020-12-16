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
        public Address SearchAddress(long id)
        {
            var Find = ContextSingelton.Context.Address.First(address => address.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error address doesn't exist");
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
        public void DeleteAddress(long id)
        {
            var Del = ContextSingelton.Context.Address.First(address => address.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Address.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  address doesn't exist");
        }
    }
}