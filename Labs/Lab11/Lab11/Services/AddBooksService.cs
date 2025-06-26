using System.Collections.ObjectModel;
using Lab11.Models;

namespace Lab11.Services
{
    public class AddBooksService : IAddBooksService
    {
        private readonly AppDbContext _context;

        public AddBooksService(AppDbContext context)
        {
            _context = context;
        }

        public ObservableCollection<User> GetUsers() => new ObservableCollection<User>(_context.Users);
        public ObservableCollection<Status> GetStatuses() => new ObservableCollection<Status>(_context.Statuses);
        public void CreateBook(Book book) => _context.Books.Add(book);
        public ObservableCollection<Book> GetBook() => new ObservableCollection<Book>(_context.Books);
        public void Save() => _context.SaveChanges();
        public void DeleteBook(Book book) => _context.Books.Remove(book);

        public void UpdateBook(Book book)
        {
            var existingBook = _context.Books.Find(book.Id);
            if (existingBook != null)
            {
                _context.Entry(existingBook).CurrentValues.SetValues(book);
            }
        }
    }
}
