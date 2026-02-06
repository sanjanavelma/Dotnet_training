using System;
using Microsoft.Data.SqlClient;

public class UsingStoredProce
{
    private string connectionString =
        "Server=.\\SQLEXPRESS;Database=Sales_Test;Trusted_Connection=True;TrustServerCertificate=True;";

    public void GetStoreProce(int salaryLimit)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");

                using (SqlCommand command =
                       new SqlCommand("GetEmployeesAboveSalary", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parameter
                    command.Parameters.AddWithValue("@SalaryLimit", salaryLimit);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nEmployees found:\n");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader["Name"]} | {reader["Dept"]} | {reader["Salary"]}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }

            Console.WriteLine("Connection closed.");
        }
    }
}
