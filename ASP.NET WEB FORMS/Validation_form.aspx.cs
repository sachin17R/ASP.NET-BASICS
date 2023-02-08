using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class Validation_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if ((args.Value == "sachin") || (args.Value == "pavan") || (args.Value == "chikka"))
                args.IsValid = true;
            else
            {
                args.IsValid = false;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string content = $"The Name: {txtname.Text}<br/>The Email Address: {txtemail.Text} with an Experience of over {txtExperience.Text} years";
                lblInfo.Text = content;
            }
            else
            {
                lblInfo.Text = String.Empty;
            }
        }
    }
}