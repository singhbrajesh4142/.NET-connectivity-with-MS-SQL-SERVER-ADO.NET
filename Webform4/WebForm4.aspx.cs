using System;
using System.Configuration;
using System.Data.SqlClient;

namespace adoDemo1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", empName.Text);
                cmd.Parameters.AddWithValue("@Gender", genderList.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", empSalary.Text);

                // define output parameter
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@EmployeeId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.Add(outputParameter);
                con.Open();
                cmd.ExecuteNonQuery();

                string EmployeeId = outputParameter.Value.ToString();
                lblMessage.Text = "Employee Id = " + EmployeeId;
            }

        }
    }
}