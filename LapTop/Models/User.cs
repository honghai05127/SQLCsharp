using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LapTop.Models
{
    public class User
    {
        private string _tentaikhoan;
        private string _matkhau;

        public User()
        {
        }

        public User(string tentaikhoan, string matkhau)
        {
            _tentaikhoan = tentaikhoan;
            _matkhau = matkhau;
        }

        public string Tentaikhoan { get => _tentaikhoan; set => _tentaikhoan = value; }
        public string Matkhau { get => _matkhau; set => _matkhau = value; }
    }
}

