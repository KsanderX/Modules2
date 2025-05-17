using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Book>? Books { get; set; } 
    }
}
