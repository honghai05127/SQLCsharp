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
           
            List<User> list = new List<User>();
            list = GetUser();
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
       
        public List<User> GetUser()
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
            return list;
        }

        [NonAction]
        public bool check_exists(string tentaikhoan)
        {
            
            List<User> list = new List<User>();
            list = GetUser();
            foreach(User temp in list)
            {
                if (temp.Tentaikhoan == tentaikhoan) return false;
            }
            return true;
        }

        // GET: UserController/Create
        public ActionResult Delete(string tendangnhap)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            List<User> list = new List<User>();
            list = GetUser();
            var std = list.Where(ur => ur.Tentaikhoan == tendangnhap).FirstOrDefault();

            return View(std);
        }
        [HttpPost]
        public ActionResult Delete(User user)
        {
            
            List<User> list = new List<User>();
            list = GetUser();
            
            var userFind = list.Where(s => s.Tentaikhoan == user.Tentaikhoan).FirstOrDefault();
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = "DELETE FROM [dbo].[_CODE_TAIKHOAN] WHERE Tendangnhap = @tendangnhap ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tendangnhap", user.Tentaikhoan);
            cmd.Parameters.AddWithValue("@matkhau", user.Matkhau);

            cmd.ExecuteNonQuery();

            conn.Close();
            return RedirectToAction("Index");
        }

        
    }

}
