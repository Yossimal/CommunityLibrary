﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using data_Access.Models;

namespace data_Access.HttpAPI
{
    /// <summary>
    /// Summary description for CommunityLibraryPrivate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CommunityLibraryPrivate : System.Web.Services.WebService
    {

        [WebMethod]
        public User CheckLogin(string key,string userName,string password)
        {
            User ret = new User();
            return ret;
        }
    }
}
