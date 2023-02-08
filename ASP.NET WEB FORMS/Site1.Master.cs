using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated)
            {
                lbluserinfo.Text ="welcome "+ Page.User.Identity.Name;
            }
            else
            {
                lbluserinfo.Text = "welcome user";
            }
            lblyear.Text = DateTime.Now.Year.ToString();
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
             FormsAuthentication.SignOut();
        }
    }
}