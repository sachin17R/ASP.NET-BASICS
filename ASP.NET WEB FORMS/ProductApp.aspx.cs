using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_APPS.Models;

namespace WEB_APPS
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = ProductRepo.AllRecords;
                foreach (var item in data)
                    lstProducts.Items.Add(new ListItem
                    {
                        Text = item.ProductName,
                        Value = item.ProductId.ToString()
                    });
            }
        }
        protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            var id = int.Parse(lstProducts.SelectedValue);
            var selected = ProductRepo.AllRecords.FirstOrDefault((p) => p.ProductId == id);
            txtId.Text = selected.ProductId.ToString();
            txtName.Text = selected.ProductName;
            txtPrice.Text = selected.Price.ToString();
            imgPic.ImageUrl = selected.ProductImage;

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductImage = imgPic.ImageUrl,
                Price = int.Parse(txtPrice.Text),
                ProductId = int.Parse(txtId.Text),
                ProductName = txtName.Text,
                Quantity = int.Parse(dpQuantity.Text)
            };
            ProductRepo.UpdateProduct(product);
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ProductRepo.DeleteProduct(int.Parse(txtId.Text));
            Response.Redirect("WebForm1.aspx");
        }

        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    var product = new Product
        //    {
        //        Image = Image1.ImageUrl,
        //        Price = int.Parse(txtPrice.Text),
        //        ProductId = int.Parse(txtId.Text),
        //        ProductName = txtName.Text,
        //        Quantity = int.Parse(dpQuantity.Text)
        //    };
        //    ProductRepo.AddNewProduct(product);
        //    Response.Redirect("WebForm1.aspx");
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    StartUpLoad();
        //}
        //private void StartUpLoad()
        //{
        //    string imgName = string.Empty;
        //    int imgSize = 0;
        //    string imgPath = string.Empty;

        //    if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
        //    {
        //        //get the file name of the posted image           
        //        imgName = FileUpload1.PostedFile.FileName;
        //        //sets the image path           
        //        imgPath = @".\Images\" + imgName;
        //        //get the size in bytes that  
        //        imgSize = FileUpload1.PostedFile.ContentLength;
        //        // 10240 KB means 10MB, You can change the value based on your requirement  
        //        if (imgSize > 102400)
        //        {
        //            Page.ClientScript.RegisterClientScriptBlock(typeof(Page),
        //            "Alert", "alert('File is too big.')", true);
        //        }
        //        else
        //        {
        //            //then save it to the Folder  
        //            FileUpload1.SaveAs(Server.MapPath(imgPath));
        //            Image1.ImageUrl = imgPath;
        //            Page.ClientScript.RegisterClientScriptBlock(typeof(Page),
        //            "Alert", "alert('Image saved!')", true);
        //        }
        //    }

        }
}