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
        public string AddUser(string userName, string password , string firstName, string lastName, int dayBirth, int monthBirth, int yearBirth, string emailAddress, string phoneNumber,string apartment, string enterance, string houseNumber,string city, string state, string zipCode, string country, string streetAddress)
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

            data.AddUser(user);
            return "fail";
        }


    }
}
