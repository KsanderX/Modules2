using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var5.Models
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int ProductTypeId { get; set; }
        public  ProductType ProductType { get; set; }
        public float Distance { get; set; }
        public int Quantity { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
        public int PhoneNumber { get; set; }
        public int RequestStatusId { get; set; } = 1;
        public RequestStatus RequestStatus { get; set; }
    }
}
