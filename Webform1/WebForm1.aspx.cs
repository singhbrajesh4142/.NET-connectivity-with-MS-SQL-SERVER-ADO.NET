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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=(localdb)\\PRFTInstance; database=Sample; integrated security=SSPI";

            // retrieve connectionstring from web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand cmd = new SqlCommand("Select * from tbl_demo", connection);
                connection.Open();
                gridview1.DataSource = cmd.ExecuteReader();
                gridview1.DataBind();
            }
        }
    }
}