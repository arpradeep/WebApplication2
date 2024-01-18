

using Microsoft.Data.SqlClient;
using System.Data;

namespace WebApplication2.Model
{
    public class SqlExecution
    {
        public string conn = "Data Source=DESKTOP-NNTVB6Q\\MSSQLSERVER01;Initial Catalog=cuserorder;Trusted_Connection=True;;MultipleActiveResultSets=true;TrustServerCertificate=True;";

        public string   customervalidtion( string Emailid)
        {
            int i = 0;
           // string conn = "Data Source=DESKTOP-NNTVB6Q\\MSSQLSERVER01;Initial Catalog=cuserorder;Trusted_Connection=True;;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand("customervalidation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Emailid", SqlDbType.VarChar).Value = Emailid;

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                          i=Convert.ToInt32( reader["id"]);
                        }
                    }
                    con.Close();
                }
            }
            if (i == 0)
            {
                return "Invalid";
            }
            else { return "Valid"; }
           
        }
    }
}
