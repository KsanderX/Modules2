using System.Windows;
using Var1.DataBase;
using Var1.Service;

namespace Lab6.Service
{
    public class DbService : IDbService
    {
        private AppDbContext _context;

        public DbService()
        {
            _context = new AppDbContext();
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void AddRequest(Request request)
        {
            _context.Requests.Add(request);
            _context.SaveChanges();
        }

        public List<Request> GetRequests()
        {
            return _context.Requests.ToList();
        }

        public Var1.DataBase.Request GetRequestById(string selectedId)
        {
            if (int.TryParse(selectedId, out int id))
            {
                Request request = _context.Requests.FirstOrDefault(r => r.Id == id);

                if (request == null)
                {
                    MessageBox.Show("Такой заявки нет");
                }

                return request;
            }
            else
            {
                MessageBox.Show("Некорректный формат ID");
                return null;
            }
        }

        public Dictionary<string, double> GetFaultStatistics()
        {
            Dictionary<string, double> faultStatistics = new Dictionary<string, double>();

            int faultCountType1 = _context.Requests.Where(r => r.CarTypeId == 1).Count();
            int faultCountType2 = _context.Requests.Where(r => r.CarTypeId == 2).Count();
            int faultCountType3 = _context.Requests.Where(r => r.CarTypeId == 3).Count();

            faultStatistics.Add("Sedan", faultCountType1);
            faultStatistics.Add("Coupe", faultCountType2);
            faultStatistics.Add("Universal", faultCountType3);

            return faultStatistics;
        }

        public bool Authorization(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
