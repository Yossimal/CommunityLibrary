using data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace data_Access.views
{
    public partial class Welcome : System.Web.UI.Page
    {
        private Functions.Functions func = new Functions.Functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["logout"] != null && Request.QueryString["logout"].ToString() == "logout")
            {
                Session.Abandon();
            }
        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = func.Authentication(userName.Text, password.Text);
                Session["user-id"] = user.Id.ToString();
                Response.Redirect("Profile.aspx");
                signIn.Text = "Successfully signed in";
            }
            catch (Exception ex)
            {

            }

        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void discover_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discover.aspx");
        }
    }
}