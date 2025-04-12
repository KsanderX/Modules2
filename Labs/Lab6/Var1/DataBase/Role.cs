using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1.DataBase
{
    public class Role
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<User> Users { get; set; }
    }
}
