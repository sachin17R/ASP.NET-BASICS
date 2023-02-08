using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtfirst.Text);
            double v2 = double.Parse(txtsecond.Text);
            string ope = dplist.SelectedValue;
           double res =  OperationMaker(v1, v2, ope);
            pdisplay.Text = res.ToString();
        }

        private double OperationMaker(double v1, double v2, string ope)
        {
            switch (ope)
            {
                case "Add":return v1 + v2;
                case "sub":return v1 - v2;
                case "mul":return v1 * v2;
                case "div":return v1 / v2;    
                default:
                    break;
            }
            return 0;
        }
    }
}