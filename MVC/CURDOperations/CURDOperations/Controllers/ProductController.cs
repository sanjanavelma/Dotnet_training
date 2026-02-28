using CURDOperations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CURDOperations.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

        // ================= READ =================
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToInt32(reader["Price"])
                    });
                }
            }

            return View(products);
        }

        // ================= CREATE =================
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product.Name != null && product.Price > 0)
            {
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    string query = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToAction("Index");
        }

        // ================= UPDATE =================
        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (product.Id > 0)
            {
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    string query = "UPDATE Products SET Name=@Name, Price=@Price WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToAction("Index");
        }

        // ================= DELETE =================
        [HttpPost]
        public IActionResult DeleteById(Product product)
        {
            if (product.Id > 0)
            {
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    string query = "DELETE FROM Products WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Id", product.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToAction("Index");
        }
    }
}