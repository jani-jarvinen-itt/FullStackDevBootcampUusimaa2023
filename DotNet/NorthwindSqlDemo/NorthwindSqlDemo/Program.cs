using System.Data.SqlClient;

// open connection to the Northwind database
string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
SqlConnection conn = new(connectionString);
conn.Open();

// create an SQL statement
string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
SqlCommand cmd = new(sql, conn);

// execute the SQL and display results
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    string companyName = reader["CompanyName"]?.ToString() ?? "";
    Console.WriteLine(companyName);
}

// cleanup
conn.Close();
