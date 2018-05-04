using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace adoDemo1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee_tbl", connection);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    DataTable sourceTable = new DataTable();
                    sourceTable.Columns.Add("EmployeeId");
                    sourceTable.Columns.Add("EmployeeName");
                    sourceTable.Columns.Add("Gender");
                    sourceTable.Columns.Add("Salary");
                    sourceTable.Columns.Add("Salary + 10%");

                    while (rdr.Read())
                    {
                        int originalSalary = Convert.ToInt32(rdr["Salary"]);
                        double bonusSalary = originalSalary * 1.1;

                        DataRow dataRow = sourceTable.NewRow();
                        dataRow["EmployeeId"] = rdr["EmployeeId"];
                        dataRow["EmployeeName"] = rdr["EmployeeId"];
                        dataRow["Gender"] = rdr["EmployeeId"];
                        dataRow["Salary"] = originalSalary;
                        dataRow["Salary + 10%"] = bonusSalary;

                        sourceTable.Rows.Add(dataRow);
                    }

                    GridView1.DataSource = sourceTable;
                    GridView1.DataBind();
                }
            }
        }
    }
}