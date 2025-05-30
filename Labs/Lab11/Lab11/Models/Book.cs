using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public string? Description { get; set; }
        public DateTime BookReleaseDate { get; set; } = DateTime.Now;       
        public User? User { get; set; }
        public int UserId { get; set; }
        public Status? Status { get; set; }
        public int StatusId { get; set; }     
    }
}
