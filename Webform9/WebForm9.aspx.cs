using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace adoDemo1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] == null)
            {
                string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from Product;", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;

                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    Label1.Text = "Data loaded from database";
                }
            }else
            {
                GridView1.DataSource = Cache["Data"];
                GridView1.DataBind();

                Label1.Text = "Data loaded from Cache";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] != null)
            {
                Cache.Remove("Data");
                Label1.Text = "Data is removed from cache";
            }else
            {
                Label1.Text = "There is nothing in Cache";
            }
        }
    }
}