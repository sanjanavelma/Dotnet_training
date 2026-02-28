using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using EmployeeForm.Models;

namespace EmployeeForm.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IConfiguration _configuration;

        public EmployeesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // ================= INDEX =================
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();

            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employees.Add(new Employee
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Salary = Convert.ToDecimal(reader["Salary"])
                    });
                }
            }

            return View(employees);
        }

        // ================= CREATE GET =================
        public IActionResult Create()
        {
            return View();
        }

        // ================= CREATE POST =================
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Console.WriteLine("POST METHOD HIT");
            if (!ModelState.IsValid)
                return View(employee);

            try
            {
                string connectionString = _configuration.GetConnectionString("DefaultConnection");

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Employees
                            (FirstName, LastName, Email, PhoneNumber, Gender,
                             DateOfBirth, Age, Department, Designation,
                             Salary, State, City, AddressLine1, AddressLine2,
                             Pincode, AadhaarNumber, JoiningDate, IsActive)
                             VALUES
                            (@FirstName, @LastName, @Email, @PhoneNumber, @Gender,
                             @DateOfBirth, @Age, @Department, @Designation,
                             @Salary, @State, @City, @AddressLine1, @AddressLine2,
                             @Pincode, @AadhaarNumber, @JoiningDate, 1)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Age", employee.Age);
                    cmd.Parameters.AddWithValue("@Department", employee.Department);
                    cmd.Parameters.AddWithValue("@Designation", employee.Designation);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@State", employee.State);
                    cmd.Parameters.AddWithValue("@City", employee.City);
                    cmd.Parameters.AddWithValue("@AddressLine1", employee.AddressLine1);
                    cmd.Parameters.AddWithValue("@AddressLine2", employee.AddressLine2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pincode", employee.Pincode);
                    cmd.Parameters.AddWithValue("@AadhaarNumber", employee.AadhaarNumber);
                    cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("Error: " + ex.Message);
            }
        }
    }
}