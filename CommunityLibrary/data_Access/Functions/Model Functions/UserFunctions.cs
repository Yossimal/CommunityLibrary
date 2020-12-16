﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public partial class Functions : DalApi
    {
        public void AddUser(User user)
        {
            Validator.TrimObject(user);
            try
            {
                Validator.ValidateUser(user);
                ContextSingelton.Context.Users.Add(user);
                ContextSingelton.Context.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception("error - Couln't add the user");
            }
        }
        public User SearchUser(long id)
        {
            var Find = ContextSingelton.Context.Users.First(user => user.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error user doesn't exist");
        }
        public void UpdateUser(User user)
        {
            try
            {
                Validator.ValidateUser(user);
                ContextSingelton.Context.Entry(user).CurrentValues.SetValues(user);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couln't update the user");
            }
        }
        public void DeleteUser(long id)
        {
            var Del = ContextSingelton.Context.Users.First(user => user.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Users.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  user doesn't exist");
        }
        public User Authiticate(User user, string password) { throw new NotImplementedException(); }
        public ICollection<Offer> GetAllUsers(Func<User, bool> predicate = null) { throw new NotImplementedException(); }
        public ICollection<Offer> GetUserOffers(long id, Func<Offer, bool> predicate = null/*float km = float.MaxValue*/) { throw new NotImplementedException(); }
        public ICollection<Order> GetUserOrders(long id, Func<Order, bool> predicate = null/*float km = float.MaxValue*/) { throw new NotImplementedException(); }
        public ICollection<Comment> GetUserComments(long id, Func<Comment, bool> predicate = null/*float rating = 0*/) { throw new NotImplementedException(); }
        public ICollection<Book> GetUserBooks(long id, Func<Book, bool> predicate = null) { throw new NotImplementedException(); }
        public Address GetUserAddress(long id) { throw new NotImplementedException(); }
    }
}