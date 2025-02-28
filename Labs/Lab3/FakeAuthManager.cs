using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class FakeAuthManager : IAuthManager
    {
        public bool Login(string login, string password)
        {
            return login == "admin" && password == "admin";
        }

        public void Register(string login, string password)
        {
            // Ничего не делаем
        }

        public bool IsLoginTaken(string login)
        {
            return false;
        }
    }
}
