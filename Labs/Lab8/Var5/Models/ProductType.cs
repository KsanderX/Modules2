using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var5.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();
    }
}
