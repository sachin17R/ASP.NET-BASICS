using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_APPS.Models;

namespace WEB_APPS
{
    public partial class WebForm4 : System.Web.UI.Page
    {
         Product selectedProduct = null;
        static List<Product> cart = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = Application["product"] as List<Product>;
                rpProduct.DataSource  = Application["product"] as List<Product>;
                rpProduct.DataBind();
            }
        }
        protected void OnView_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Details")
            {
                var id = Convert.ToInt32(e.CommandArgument);//Id of the Product U have selected 
                getProduct(id);

                //Add to the recent list...
                addToRecentList();
            }
        }

        private void addToRecentList()
        {
            //Get the Current list
            var recentList = Session["RecentList"] as Queue<Product>;
            //Count should be more than 5...
            if (recentList.Count == 5)
                recentList.Dequeue();
            //Add the newly selected Item into the recentList
            recentList.Enqueue(selectedProduct);
            //Set it back to the Session State
            Session["recentItems"] = recentList;
            //Reverse the queue for getting the latest added to the top
            var list = recentList.Reverse();
            //set the list to the lstRecentList Control
            lstRecentList.DataSource = list;
            lstRecentList.DataBind();
           // Response.Redirect("ShoppingCart.aspx");
            
        }

        private void getProduct(int id)
        {
            var data = Application["product"] as List<Product>;
            selectedProduct = data.Find((p) => p.ProductId == id);
            txtProductId.Text = selectedProduct.ProductId.ToString();
            txtProductName.Text = selectedProduct.ProductName;
            txtProductCost.Text = selectedProduct.Price.ToString();
            txtQuantity.Text = selectedProduct.Quantity.ToString();
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            int id =int.Parse( txtProductId.Text);
            string name = txtProductName.Text;
            int qty = int.Parse(txtQuantity.Text);
            int price = int.Parse(txtProductCost.Text);
            var pro = new Product { ProductId = id, Quantity = qty, ProductName = name, Price = price };
            cart.Add(pro);
            Session["MyCart"] = cart;
        }
    }
}