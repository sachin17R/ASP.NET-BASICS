using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_APPS.Models;

namespace WEB_APPS
{
    public partial class BillingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = Session["MyCart"] as List<Product>;
                lstCart.DataSource = data;
                lstCart.DataBind();
            }
        }


    }
}