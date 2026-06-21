using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Interface
{
    public interface IAuth
    {
        bool Login(string email, string password);
        void Logout();
    }
}
