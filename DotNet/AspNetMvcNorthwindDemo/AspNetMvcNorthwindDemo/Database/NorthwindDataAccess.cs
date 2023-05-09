using System.Data.SqlClient;

namespace AspNetMvcNorthwindDemo.Database
{
    public class NorthwindDataAccess
    {
        public List<string> GetFinnishCustomers()
        {
            // open connection to the Northwind database
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection conn = new(connectionString);
            conn.Open();

            // create an SQL statement
            string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
            SqlCommand cmd = new(sql, conn);

            // execute the SQL and display results
            List<string> results = new();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string companyName = reader["CompanyName"]?.ToString() ?? "";
                results.Add(companyName);
            }

            // cleanup
            conn.Close();

            // we are done
            return results;
        }
    }
}
