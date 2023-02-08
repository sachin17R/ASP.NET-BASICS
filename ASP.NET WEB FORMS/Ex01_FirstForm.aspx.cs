using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class Ex01_FirstForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCLick_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtFirst.Text);
            double v2 = double.Parse(txtSecond.Text);
            string res = dplist.SelectedValue;
           var result =  Converter(v1, v2, res);
            pdisplay.Text = "Result :" + result;
        }

        private double Converter(double v1, double v2, string res)
        {
            switch (res)
            {
                case "Add": return v1 + v2;
                case "Sub": return v1 - v2;
                case "Mul": return v1 * v2;
                case "Div": return v1 / v2;
                default:
                    break;
            }
            return 0;
        }
    }
}