using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //QueryStringMethod();
            var coocki = Request.Cookies["Mycoockies"];
            if(coocki == null)
            {
                lbldisplay.Text = "U should Enter Something In Input Page";
            }
            else
            {
                lbldisplay.Text = $"Name:{coocki.Values["name"]}<br/>Email:{coocki.Values["email"]}<br/>Phone:{coocki.Values["phone"]}";
            }
        }

        private void QueryStringMethod()
        {
            if (Request.QueryString.Count == 0)
            {
                lbldisplay.Text = "U should Enter Something In Input Page";
            }
            else
            {
                lbldisplay.Text = $"Name:{Request.QueryString["name"]}<br/>Email:{Request.QueryString["email"]}<br/>Phone:{Request.QueryString["phone"]}";
            }
        }
    }
}