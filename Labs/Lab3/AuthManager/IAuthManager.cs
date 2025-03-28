using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Lab3.AuthManager
{
    public interface IAuthManager
    {
        bool Login(string login, string password);
        void Register(string login, string password);
        bool IsLoginTaken(string login);
    }
}
