using System.Collections.ObjectModel;
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
        public void UpdateBook(Book book);
    }
}
