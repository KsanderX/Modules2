using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11.Models;

namespace Lab11.Services
{
    public interface IRegistrationService 
    {
        public void RegAccount(User user);
    }
}
