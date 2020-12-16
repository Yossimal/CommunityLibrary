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


        //COMMENT FUNCTIONS
        void AddComment(Comment comment);
        Comment SearchComment(long id);
        void UpdateComment(Comment comment);
        void DeleteComment(long id);


        //OFFER FUNCTIONS
        void AddOffer(Offer offer);
        Offer SearchOffer(long id);
        void UpdateOffer(Offer offer);
        void DeleteOffer(long id);


        //ORDER FUNCTIOS
        void AddOrder(Order order);
        Order SearchOrder(long id);
        void UpdateOrder(Order order);
        void DeleteOrder(long id);

        
    }
}
