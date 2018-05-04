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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void getDataFromDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string query = "select * from Employee_tbl";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataSet ds = new DataSet("Employee");
                adapter.Fill(ds);

                Cache["DATASET"] = ds;

                GridView1.DataSource = ds;
                GridView1.DataBind();

                lblMessage.Text = "Data Loaded from Database";
            }
        }

        private void getDataFromCache()
        {
            if(Cache["DATASET"] != null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string query = "select * from Employee_tbl";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    DataSet ds = new DataSet("Employee");
                    adapter.Fill(ds);
                    
                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    lblMessage.Text = "Data Loaded from Cache";
                }
            }
        }

        protected void btnGetDataFromDB_Click(object sender, EventArgs e)
        {
            getDataFromDB();
        }

        protected void btnUpdateData_Click(object sender, EventArgs e)
        {
            
        }
    }
}