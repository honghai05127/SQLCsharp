using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LapTop.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LapTop.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration config)
        {
            _configuration = config;
        }


        // GET: UserController
        public ActionResult Index()
        {
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            List<User> list = new List<User>();
            string query = "select * from _CODE_TAIKHOAN";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            Tentaikhoan = reader["TENDANGNHAP"].ToString(),
                            Matkhau = reader["MATKHAU"].ToString()
                        });

                    }

                }
            }
            return View(list);
        }


        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        public IActionResult Create(User um)
        {
            try
            {
                string connStr = _configuration.GetConnectionString("DefaultConnection");
                SqlConnection conn = new SqlConnection(connStr);
                if (!check_exists(um.Tentaikhoan))
                {
                    ModelState.AddModelError("", "Tên tài khoản đã tồn tại");
                    
                }
                conn.Open();
                string query = "INSERT INTO [dbo].[_CODE_TAIKHOAN]([TENDANGNHAP],[MATKHAU])VALUES(@tendangnhap,@matkhau)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tendangnhap", um.Tentaikhoan);
                cmd.Parameters.AddWithValue("@matkhau", um.Matkhau);

                cmd.ExecuteNonQuery();

                conn.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(um);
            }
            
        }
        [NonAction]
        public bool check_exists(string tentaikhoan)
        {
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            List<User> list = new List<User>();
            string query = "select * from _CODE_TAIKHOAN";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            Tentaikhoan = reader["TENDANGNHAP"].ToString(),
                            Matkhau = reader["MATKHAU"].ToString()
                        });

                    }

                }
            }
            foreach(User temp in list)
            {
                if (temp.Tentaikhoan == tentaikhoan) return false;
            }
            return true;
            }

    }
}