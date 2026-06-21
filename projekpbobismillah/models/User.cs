using projekpbobismillah.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.models
{
    public abstract class User : IAuth
    {
        private int IDUser;
        private string email;
        private string password;

        public int UserID { get => IDUser; set => IDUser = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public User(int IDuser, string email, string password)
        {
            IDUser = IDuser;
            Email = email;
            Password = password;
        }

        public virtual bool Login(string inputEmail, string inputPassword)
        {
            if (inputEmail == Email && inputPassword == Password)
            {
                Console.WriteLine($"{Email} berhasil login!");
                return true;
            }
            Console.WriteLine("Email atau password salah!");
            return false;
        }

        public virtual void Logout()
        {
            Console.WriteLine($"{Email} logout.");
        }

        public abstract void ViewDashboard();
    }
}
