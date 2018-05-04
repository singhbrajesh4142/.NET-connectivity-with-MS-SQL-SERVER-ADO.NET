using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace adoDemo1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee_tbl; select * from Product;", conn);
                SqlDataReader rdr =  cmd.ExecuteReader();

                firstGridView.DataSource = rdr;
                firstGridView.DataBind();

                while (rdr.NextResult())
                {
                    secondGridView.DataSource = rdr;
                    secondGridView.DataBind();
                }
            }
        }
    }
}