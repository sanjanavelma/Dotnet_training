using System;
using Microsoft.Data.SqlClient;
using System.Data;

class Program
{
    static string connectionString =
        "Server=.\\SQLEXPRESS;Database=Sales_Test;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        Console.Write("Enter gender: ");
        string gender = Console.ReadLine();

        using (SqlConnection con = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand("uspGetGenderCount", con))
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // input parameter
            cmd.Parameters.AddWithValue("@gender", gender);

            // output parameter
            SqlParameter outputParam = new SqlParameter("@count", System.Data.SqlDbType.Int);
            outputParam.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);

            con.Open();
            cmd.ExecuteNonQuery();

            int result = (int)outputParam.Value;

            Console.WriteLine($"Count of {gender}: {result}");
        }
    }
}
