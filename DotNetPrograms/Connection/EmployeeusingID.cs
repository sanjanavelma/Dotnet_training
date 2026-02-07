using System;
using Microsoft.Data.SqlClient;

public class EmployeeRepository
{
    private string connectionString =
        "Server=.\\SQLEXPRESS;Database=Sales_Test;Trusted_Connection=True;TrustServerCertificate=True;";

    public void GetEmployeesAboveSalary(int salaryLimit, int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand("GetEmployeesAboveSalary", con))
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SalaryLimit", salaryLimit);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                bool hasData = false;

                while (reader.Read())
                {
                    hasData = true;

                    Console.WriteLine(
                        $"Name: {reader["Name"]}, Dept: {reader["Dept"]}, Salary: {reader["Salary"]}");
                }

                if (!hasData)
                    Console.WriteLine("No matching employee found.");
            }
        }
    }
    }