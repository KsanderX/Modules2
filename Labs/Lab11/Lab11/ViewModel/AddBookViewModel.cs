using System.Collections.ObjectModel;
using Lab11.Models;
using Lab11.Services;

namespace Lab11.ViewModel
{
    public class AddBookViewModel
    {
        public Book Book { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Status> Statuses { get; set; }
        private IAddBooksService _bookService;
        public AddBookViewModel(IAddBooksService addBooks)
        {
            Book = new Book();
            _bookService = addBooks;
            Statuses = _bookService.GetStatuses();
            Users = _bookService.GetUsers();
        }
    }
}
