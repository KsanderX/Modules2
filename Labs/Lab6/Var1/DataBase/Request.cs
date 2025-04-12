

namespace Var1.DataBase
{
    public class Request
    {
        public int ID { get; set; }
        public string Number { get; set; } = string.Empty;
        public DateTime DateAdd { get; set; }
        public string TypeCar { get; set; }
        public string ModelCar { get; set; }
        public string ProblemDescription {  get; set; }        
        public User Client { get; set; }
        public int PhoneNumber { get; set; }


    }
}
