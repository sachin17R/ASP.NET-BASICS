using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WEB_APPS.Models;

namespace WEB_APPS
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Product"] = ProductRepo.AllRecords;
        }

        protected void Session_Start(object sender,EventArgs e)
        {
            Session["MyCart"] = new List<Product>();
            Session["RecentList"] = new Queue<Product>();
        }
    }
}