using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class InputPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            // queryStingMethod();
            HttpCookie cook = new HttpCookie("Mycoockies");
            cook.Values.Add("name", txtname.Text);
            cook.Values.Add("email", txtemail.Text);
            cook.Values.Add("phone", txtnumber.Text);
            Response.Cookies.Add(cook);
            Response.Redirect("RecipiantPage.aspx");
        }

        private void queryStingMethod()
        {
            string URL1 = $"RecipiantPage.aspx?name={txtname.Text}&email={txtemail.Text}&phone={txtnumber.Text}";
            Response.Redirect(URL1);
        }
    }
}