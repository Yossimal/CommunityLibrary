using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_Access.Models;


namespace data_Access.Functions
{
    interface Interface1
    {
        //USER FUNCTIONS
        void AddUser(User user);
        User SearchUser(long id)

        void AddAddress(User user);
        void AddBook(User user);
        void AddComment(User user);
        void AddOffer(User user);
        void AddOrder(User user);


    }
}
