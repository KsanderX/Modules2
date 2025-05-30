using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11.Models;

namespace Lab11.Services
{
    public interface IAddBooksService 
    {
        public ObservableCollection<User> GetUsers();
        public ObservableCollection<Status> GetStatuses();
        public void CreateBook(Book book);
        public ObservableCollection<Book> GetBook();
        public void Save();
        public void DeleteBook(Book book);
    }
}
