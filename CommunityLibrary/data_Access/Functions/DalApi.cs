using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_Access.Models;


namespace data_Access.Functions
{
    interface DalApi
    {
        //USER FUNCTIONS
        void AddUser(User user);
        User SearchUser(long id);
        void UpdateUser(User user);
        void DeleteUser(long id);
        User Authiticate(User user, string password);
        ICollection<User> GetAllUsers(Func<User, bool> predicate = null);
        ICollection<Offer> GetUserOffers(long id, Func<Offer, bool> predicate = null/*float km = float.MaxValue*/);
        ICollection<Order> GetUserOrders(long id, Func<Order, bool> predicate = null/*float km = float.MaxValue*/);
        ICollection<Comment> GetUserComments(long id, Func<Comment, bool> predicate = null/*float rating = 0*/);
        ICollection<Book> GetUserBooks(long id, Func<Book, bool> predicate = null);
        Address GetUserAddress(long id);



        //ADDRESS FUNCTIONS
        void AddAddress(Address address);
        Address SearchAddress(long id);
        void UpdateAddress(Address address);
        void DeleteAddress(long id);



        //BOOK FUNCTIONS
        void AddBook(Book book);
        Book SearchBook(long id);
        void UpdateBook(Book book);
        void DeleteBook(long id);
        ICollection<Book> GetAllBooks(Func<Book, bool> predicate = null);
        ICollection<Offer> GetBookOffers(long id, Func<Offer, bool> predicate = null/*float km = float.MaxValue*/);
        ICollection<Order> GetBookOrders(long id, Func<Order, bool> predicate = null/*float km = float.MaxValue*/);



        //COMMENT FUNCTIONS
        void AddComment(Comment comment);
        Comment SearchComment(long id);
        void UpdateComment(Comment comment);
        void DeleteComment(long id);
        ICollection<Comment> GetAllComments(Func<Comment, bool> predicate = null);



        //OFFER FUNCTIONS
        void AddOffer(Offer offer);
        Offer SearchOffer(long id);
        void UpdateOffer(Offer offer);
        void DeleteOffer(long id);
        Book GetOfferBook(long id);


        //ORDER FUNCTIOS
        void AddOrder(Order order);
        Order SearchOrder(long id);
        void UpdateOrder(Order order);
        void DeleteOrder(long id);        
    }
}
