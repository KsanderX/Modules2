

namespace Var1.DataBase
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime DateAdd { get; set; }
        public string CarModel { get; set; }
        public string ProblemDescription {  get; set; }        
        public User Client { get; set; }
        public int PhoneNumber { get; set; }
        public int CarTypeId {  get; set; }
        public CarType? CarType { get; set; }

    }
}
