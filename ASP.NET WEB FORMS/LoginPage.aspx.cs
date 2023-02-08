using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(txtusername.Text, txtpassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtusername.Text, false);
            }
            else
            {
                lblerror.Text = "Login Failed";
            }
        }
    }
}