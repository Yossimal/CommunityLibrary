using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using data_Access.Functions;
using data_Access.Models;

namespace data_Access.views
{
    public partial class Login : System.Web.UI.Page
    {
        private Functions.Functions func=new Functions.Functions();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_OnClick(object sender, EventArgs e)
        {
           Models.User usr=new User();
           usr.UserName = userName.Text;
           usr.FirstName = firstName.Text;
           usr.LastName = lastName.Text;
           usr.BirthDate = DateTime.Parse(bitrthDate.Text);
           usr.EmailAddress = email.Text;
           usr.Password = password.Text;
           usr.PhoneNumber = phoneNumber.Text;
           usr.LendingCount = 0;
           Address add=new Address();
           add.Apartment = apartmentNumber.Text;
           add.City = city.Text;
           add.Country = country.Text;
           add.Enterance = Enterance.Text;
           add.ZipCode = zip.Text;
           add.StreatAddress = street.Text;
           usr.Address = add;
           try
           {
               func.AddUser(usr);
           }
           catch (Exception ex)
           {

           }
        }
    }
}