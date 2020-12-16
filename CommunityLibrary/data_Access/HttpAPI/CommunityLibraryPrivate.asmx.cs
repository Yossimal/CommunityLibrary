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
        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User CheckLogin(string key,string userName,string password)
        {
            User ret = new User();
            ret.UserName = userName;
            ret.FirstName = "test";
            ret.Password = password;
            return ret;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Test(string name)
        {
            return name.ToUpper();
        }

    }
}
