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
        public Order SearchOrder(long id)
        {
            var Find = ContextSingelton.Context.Orders.First(order => order.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error order doesn't exist");
        }
        public void UpdateOrder(Order order)
        {
            try
            {
                Validator.ValidateOrder(order);
                ContextSingelton.Context.Entry(order).CurrentValues.SetValues(order);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couldn't update the order");
            }
        }
        void DeleteOrder(long id)
        {
            var Del = ContextSingelton.Context.Orders.First(order => order.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Orders.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  order doesn't exist");
        }
        Book GetOrderBook(long id);
    }
}