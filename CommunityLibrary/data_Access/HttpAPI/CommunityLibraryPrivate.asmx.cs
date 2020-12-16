using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services;
using System.Web.UI.WebControls;
using data_Access.Models;
using System.Web.Script.Services;
using data_Access.Functions;
using Microsoft.SqlServer.Server;

namespace data_Access.HttpAPI
{
    /// <summary>
    /// Summary description for CommunityLibraryPrivate
    /// </summary>
    [EnableCors(origins: "https://localhost:44300/", headers: "*", methods: "*")]
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [ScriptService]
    public class CommunityLibraryPrivate : System.Web.Services.WebService
    {
        private DalApi data=new Functions.Functions();
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User CheckLogin(string userName,string password)
        {
            return data.Authiticate(userName,password);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User GetUser(int id)
        {
            return data.SearchUser(id);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string AddUser(string userName, string password , string firstName, string lastName, int dayBirth, int monthBirth, int yearBirth, string emailAddress, string phoneNumber,
            string apartment, string enterance, string houseNumber,string city, string state, string zipCode, string country, string streetAddress)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = password;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.BirthDate = new DateTime(dayBirth,monthBirth,yearBirth);
            user.EmailAddress = emailAddress;
            user.PhoneNumber = phoneNumber;
            Address address = new Address();
            address.Apartment = apartment;
            address.City = city;
            address.Country = country;
            address.Enterance = enterance;
            address.ZipCode = zipCode;
            address.StreatAddress = streetAddress;
            address.State = state;
            address.HouseNumber = houseNumber;
            try
            {
                data.AddUser(user);
                return "ok";
            }
            catch(Exception ex)
            {
                return ex.Message;
               
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string AddBook(string name,string author, string barcode)
        {
            Book book = new Book();
            book.Name = name; ;
            book.Author = author;
            book.BarCode = barcode;
            try
            {
                data.AddBook(book);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string AddAddress(string apartment, string enterance, string houseNumber, string city, string state, string zipCode, string country, string streetAddress)
        {
            Address address = new Address();
            address.Apartment = apartment;
            address.City = city;
            address.Country = country;
            address.Enterance = enterance;
            address.ZipCode = zipCode;
            address.StreatAddress = streetAddress;
            address.State = state;
            address.HouseNumber = houseNumber;
            try
            {
                data.AddAddress(address);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string AddComment(int rating , string content,string refference)
        {
            Comment comment = new Comment();
            comment.Rating = rating;
            comment.Content = content;
            comment.Reference = (Reference)Enum.Parse(typeof(Reference),refference);
           
            try
            {
                data.AddComment(comment);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string AddOffer(string name, string author, string barCode, int bookId, string statusDescription,int daysForGive, int daysForReturn)
        {
            Offer offer = new Offer();
            offer.Book = new Book();
            offer.Book.Name = name;
            offer.Book.Author = author;
            offer.Book.BarCode = barCode;
            offer.BookId = bookId;
            offer.StatusDescription = statusDescription;
            offer.DaysForGive = daysForGive;
            offer.DaysForReturn = daysForReturn;
            try
            {
                data.AddOffer(offer);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string AddOrder(int dayStartTime, int monthStartTime, int yearStartTime, int dayReciveTime, int monthReciveTime, int yearReciveTime, int dayReturnTime, int monthReturnTime, int yearReturnTime)
        {
            Order order = new Order();
            order.StartTime = new DateTime(dayStartTime, monthStartTime, yearStartTime);
            order.ReciveTime = new DateTime(dayReciveTime, monthReciveTime, yearReciveTime);
            order.ReturnTime = new DateTime(dayReturnTime, monthReturnTime, yearReturnTime);
            try
            {
                data.AddOrder(order);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /////// REQUEST


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User SearchUser(long id)
        {
            try
            {
                return data.SearchUser(id);
            }
            catch 
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Book SearchBook(long id)
        {
            try
            {
                
                return data.SearchBook(id);
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Address SearchAddress(long id)
        {
            try
            {   
                return data.SearchAddress(id);
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Comment SearchComment(long id)
        {
            try
            {
                return data.SearchComment(id);
            }
            catch
            {
                return null;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Offer SearchOffer(long id)
        {
            try
            {
                return data.SearchOffer(id);
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Order SearchOrder(long id)
        {
            try
            {
                
                return data.SearchOrder(id); ;
            }
            catch 
            {
                return null;
            }
        }

      


        ///UPDATE

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateUser(string userName, string password, string firstName, string lastName, int dayBirth, int monthBirth, int yearBirth, string emailAddress, string phoneNumber,
            string apartment, string enterance, string houseNumber, string city, string state, string zipCode, string country, string streetAddress)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = password;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.BirthDate = new DateTime(dayBirth, monthBirth, yearBirth);
            user.EmailAddress = emailAddress;
            user.PhoneNumber = phoneNumber;
            Address address = new Address();
            address.Apartment = apartment;
            address.City = city;
            address.Country = country;
            address.Enterance = enterance;
            address.ZipCode = zipCode;
            address.StreatAddress = streetAddress;
            address.State = state;
            address.HouseNumber = houseNumber;
            try
            {
                data.UpdateUser(user);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateBook(string name, string author, string barcode)
        {
            Book book = new Book();
            book.Name = name; ;
            book.Author = author;
            book.BarCode = barcode;
            try
            {
                data.UpdateBook(book);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateAddress(string apartment, string enterance, string houseNumber, string city, string state, string zipCode, string country, string streetAddress)
        {
            Address address = new Address();
            address.Apartment = apartment;
            address.City = city;
            address.Country = country;
            address.Enterance = enterance;
            address.ZipCode = zipCode;
            address.StreatAddress = streetAddress;
            address.State = state;
            address.HouseNumber = houseNumber;
            try
            {
                data.UpdateAddress(address);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateComment( int rating , string content,string refference)
        {
            Comment comment = new Comment();
            comment.Rating = rating;
            comment.Content = content;
            comment.Reference = (Reference)Enum.Parse(typeof(Reference), refference);
            try
            {
                data.UpdateComment(comment);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateOffer(string name, string author, string barCode, int bookId, string statusDescription, int daysForGive, int daysForReturn)
        {
            Offer offer = new Offer();
            offer.Book = new Book();
            offer.Book.Name = name;
            offer.Book.Author = author;
            offer.Book.BarCode = barCode;
            offer.BookId = bookId;
            offer.StatusDescription = statusDescription;
            offer.DaysForGive = daysForGive;
            offer.DaysForReturn = daysForReturn;
            try
            {
                data.UpdateOffer(offer);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateOrder(int dayStartTime, int monthStartTime, int yearStartTime, int dayReciveTime, int monthReciveTime, int yearReciveTime, int dayReturnTime, int monthReturnTime, int yearReturnTime)
        {
            Order order = new Order();
            order.StartTime = new DateTime(dayStartTime, monthStartTime, yearStartTime);
            order.ReciveTime = new DateTime(dayReciveTime, monthReciveTime, yearReciveTime);
            order.ReturnTime = new DateTime(dayReturnTime, monthReturnTime, yearReturnTime);
            try
            {
                data.UpdateOrder(order);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        //DELETE

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteUser(long id)
        {
            try
            {
                data.DeleteUser(id);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteBook(long id)
        {
            try
            {
                data.DeleteBook(id);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteAddresss(long id)
        {
            try
            {
                data.DeleteAddress(id);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


       

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteComment(long id)
        {
            try
            {
                data.DeleteComment(id);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteOffer(long id)
        {
            try
            {
                data.DeleteOffer(id);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteOrder(long id)
        {
            try
            {
                data.DeleteOrder(id);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }




















        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<User> GetAllUsers(long id)
        {
            try
            {
                return data.GetAllUsers().ToList();
            }
            catch 
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Offer> GetUserOffers(long id)
        {
            try
            {
                return data.GetUserOffers(id).ToList();
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Order> GetUserOrders(long id)
        {
            try
            {
                return data.GetUserOrders(id).ToList();
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Comment> GetUserComments(long id)
        {
            try
            {
                return data.GetUserComments(id).ToList();
            }
            catch
            {
                return null;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Book> GetUserBooks(long id)
        {
            try
            {
                return data.GetUserBooks(id).ToList();
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Address GetUserAddress(long id)
        {
            try
            {
                return data.GetUserAddress(id);
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Book> GetAllBooks(long id)
        {
            try
            {
                return data.GetAllBooks().ToList();
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Offer> GetBookOffers(long id)
        {
            try
            {
                return data.GetBookOffers(id).ToList();
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Order> GetBookOrders(long id)
        {
            try
            {
                return data.GetBookOrders(id).ToList();
            }
            catch
            {
                return null;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Comment> GetAllComments(long id)
        {
            try
            {
                return data.GetAllComments().ToList();
            }
            catch
            {
                return null;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Book GetOfferBook(long id)
        {
            try
            {
                return data.GetOfferBook(id);
            }
            catch
            {
                return null;
            }
        }
    }
}
