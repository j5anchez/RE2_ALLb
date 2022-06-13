using System;
using System.Data.SqlClient;

namespace leerBD // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {

                DataSource = "localhost\\MSSQLSERVER2",
                UserID = "di",
                Password = "1234",
                InitialCatalog = "northwind"
            };
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                string query = "SELECT * FROM products";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1));

                        }
                    }
                    connection.Close();
                }

            }


            Console.ReadKey();
        }
    }
}
