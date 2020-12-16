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
        public void AddBook(Book book)
        {
            Validator.TrimObject(book);
            try
            {
                Validator.ValidateBook(book);
                ContextSingelton.Context.Books.Add(book);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couln't add the book");
            }
        }
        public Book SearchBook(long id)
        {
            var Find = ContextSingelton.Context.Books.First(book => book.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error book doesn't exist");
        }
        public void UpdateBook(Book book)
        {
            try
            {
                Validator.ValidateBook(book);
                ContextSingelton.Context.Entry(book).CurrentValues.SetValues(book);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couln't update the book");
            }
        }
        public void DeleteBook(long id)
        {
            var Del = ContextSingelton.Context.Books.First(book => book.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Books.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  book doesn't exist");
        }
        public ICollection<Book> GetAllBooks(Func<Book, bool> predicate = null)
        {
            if (predicate == null)
                return ContextSingelton.Context.Books.ToList();
            return ContextSingelton.Context.Books.Where(predicate).ToList();
        }
        public ICollection<Offer> GetBookOffers(long id, Func<Offer, bool> predicate = null/*float km = float.MaxValue*/)
        {
            if (predicate == null)
                return ContextSingelton.Context.Books.First(B => B.Id == id).OffersList.ToList();
            return ContextSingelton.Context.Books.First(B => B.Id == id).OffersList.Where(predicate).ToList();
        }
        public ICollection<Order> GetBookOrders(long id, Func<Order, bool> predicate = null/*float km = float.MaxValue*/)
        {
            if (predicate == null)
                return ContextSingelton.Context.Books.First(B => B.Id == id).OrdersList.ToList();
            return ContextSingelton.Context.Books.First(B => B.Id == id).OrdersList.Where(predicate).ToList();
        }
    }
}