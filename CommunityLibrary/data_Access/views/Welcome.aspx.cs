using data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace data_Access.views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Functions.Functions func = new Functions.Functions();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = func.Authentication(userName.Text, password.Text);
                signIn.Text = "Successfully signed in";
            }
            catch (Exception)
            {

            }

        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void discover_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discover.aspx");
        }
    }
}