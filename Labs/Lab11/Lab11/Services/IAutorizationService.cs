using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Services
{
    public interface IAutorizationService
    {
        public bool Autorization(string login, string password);
    }
}
