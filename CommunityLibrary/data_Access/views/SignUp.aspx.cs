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