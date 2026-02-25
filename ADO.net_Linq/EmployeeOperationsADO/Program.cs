using System;
using System.Data;
using Microsoft.Data.SqlClient;
class Program
{
    static string connectionString = "Server=localhost\\SQLEXPRESS;Database=EmployeeOperationsDB;Trusted_Connection=True;TrustServerCertificate=True;";
    static void Main()
    {
        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();

        GetEmployeesByDepartment(dept);
        GetDepartmentCount(dept);
        GetEmployeeOrders();
        GetDuplicateEmployees();
    }

    static void GetEmployeesByDepartment(string dept)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetEmployeesByDepartment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Department", dept);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nEmployees in Department:");

            while (reader.Read())
            {
                Console.WriteLine($"{reader["EmpId"]} - {reader["Name"]} - {reader["Phone"]}");
            }

            reader.Close();
        }
    }

    static void GetDepartmentCount(string dept)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetDepartmentEmployeeCount", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Department", dept);

            SqlParameter outputParam = new SqlParameter("@TotalEmployees", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine($"\nTotal employees in {dept}: {outputParam.Value}");
        }
    }

    static void GetEmployeeOrders()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetEmployeeOrders", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nEmployee Orders:");

            while (reader.Read())
            {
                Console.WriteLine($"{reader["Name"]} - {reader["OrderId"]} - {reader["OrderAmount"]}");
            }

            reader.Close();
        }
    }

    static void GetDuplicateEmployees()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetDuplicateEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nDuplicate Employees:");

            while (reader.Read())
            {
                Console.WriteLine($"{reader["EmpId"]} - {reader["Name"]} - {reader["Phone"]}");
            }

            reader.Close();
        }
    }
}