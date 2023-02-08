
using ProductLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APPS
{
    public partial class DataCacheing : System.Web.UI.Page
    {
        static string constr = "Data Source=192.168.171.36;Initial Catalog=3338;Integrated Security=True";
        static string query = "Select * from tblPatient";
       static SqlConnection connn = new SqlConnection(constr);
       static SqlCommand cmd = new SqlCommand(query, connn);
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                cacheingdata();
                rpProducts.DataSource = Cache["products"];
                rpProducts.DataBind();
                connn.Close();
            }

        }

        private void cacheingdata()
        {
            if (Cache["products"] == null)
            {
                connn.Open();
                DataTable table = new DataTable("PATIENTS");
                  var reader = cmd.ExecuteReader();
                table.Load(reader);
                string txtfile = Server.MapPath("CacheDepender.txt");
                Cache.Add("products", table, new System.Web.Caching.CacheDependency(txtfile), DateTime.Now.AddMinutes(5), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);
                //string strCon = "Data Source=192.168.171.36;Initial Catalog=3338;Integrated Security=True";
                //SqlCacheDependencyAdmin.EnableNotifications(strCon);
                //SqlCacheDependencyAdmin.EnableTableForNotifications(strCon, "tblpatient");
                //SqlCacheDependency dep = new SqlCacheDependency("Output-cache", "tblpatient");
                //Cache.Add("myData", table, dep, DateTime.Now.AddMinutes(2), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);

                Response.Write("table updated from DATABASE");
            }
            else
            {
                Response.Write("data come from CACHE");
            }
        }
    }
}