using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1.DataBase
{
    class Request
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public DateTime DateAdd { get; set; }
        public string TypeCar { get; set; }
        public string ModelCar { get; set; }
        public string ProblemDescription {  get; set; }
        
        public User UserId { get; set; }
        public int PhoneNumber { get; set; }


    }
}
