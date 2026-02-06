using System;
using Microsoft.Data.SqlClient;

public class EmployeeRepository
{
    private string connectionString =
        "Server=.\\SQLEXPRESS;Database=Sales_Test;Trusted_Connection=True;TrustServerCertificate=True;";

    public void GetEmployeesAboveSalary(int salaryLimit)
    {
        string query = "SELECT Name, Dept, Salary FROM Employees WHERE Salary >= @Salarylimit";

        using (SqlConnection con = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.AddWithValue("@Salarylimit", salaryLimit);

            con.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"Name: {reader["Name"]}, Dept: {reader["Dept"]}, Salary: {reader["Salary"]}");
                }
            }
        }
    }
}
