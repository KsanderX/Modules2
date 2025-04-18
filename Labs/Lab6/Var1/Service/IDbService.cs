using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1.Service
{
    public interface IDbService
    {
        public void Save();
        public void AddRequest(DataBase.Request request);
        public List<DataBase.Request> GetRequests();
        public DataBase.Request GetRequestById(string id);
        public Dictionary<string, double> GetFaultStatistics();
        public bool Authorization(string login, string password);
    }
}
