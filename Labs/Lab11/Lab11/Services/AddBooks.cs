using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab11.Services
{
    public class AddBooks : IAddBooksService
    {
        private AppDbContext _context;
        public AddBooks()
        {
            _context = new AppDbContext();
        }
        public void CreateBook(Book book)
        {           
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public ObservableCollection<Book> GetBook()
        {
            return new(_context.Books                
                .Include(i => i.Status)
                .Include(i => i.User)
                .ToList());
        }

        public ObservableCollection<Status> GetStatuses()
        {
            return new(_context.Statuses.ToList());
        }

        public ObservableCollection<User> GetUsers()
        {
            return new(_context.Users.ToList());
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
