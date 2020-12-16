using data_Access.Context;
using data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace data_Access.views
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!long.TryParse(Session["user-id"]?.ToString(), out long userId))
            {
                Response.Redirect("Welcome.aspx?msg=1");
            }

            User user = ContextSingelton.Context.Users.Find(userId);
            Address address = ContextSingelton.Context.Address.Find(user.AddressId);

            userName.Text = user.UserName;
            firstName.Text = user.FirstName;
            lastName.Text = user.LastName;
            phoneNumber.Text = user.PhoneNumber;

            country.Text = address.Country;
            state.Text = address.State;
            city.Text = address.City;
            zip.Text = address.ZipCode;
            street.Text = address.StreatAddress;
            houseNumber.Text = address.HouseNumber;
            enterance.Text = address.Enterance;
            apartmentNumber.Text = address.Apartment;

            lendingCount.Text = user.LendingCount.ToString();
            role.Text = user.Role.ToString();
        }

        protected void update_Click(object sender, EventArgs e)
        {

        }
    }
}