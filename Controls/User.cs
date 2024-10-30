using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
    public class User
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable user_tb;
        private string str;
        private string idUser;
        private string username;
        private string password;
        private string name;
        private string phanQuyen;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string IdUser { get => idUser; set => idUser = value; }

        public User() 
        { 

        }
       
    }
}
