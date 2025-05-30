using System.Windows;
using Lab11.Models;
using Lab11.Services;
using Lab11.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace Lab11.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        private IServiceProvider _serviceProvider;       
        private IAddBooksService _addBooksService;
        public AddBookWindow(IServiceProvider serviceProvider, IAddBooksService addBooksService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _addBooksService = addBooksService;
            DataContext = _serviceProvider.GetRequiredService<AddBookViewModel>();
        }     

        private void btnCreateBook_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AddBookViewModel;
            Book book = new Book()
            {
                Name = viewModel.Book.Name,
                Genre = viewModel.Book.Genre,
                Description = viewModel.Book.Description,
                BookReleaseDate = viewModel.Book.BookReleaseDate,
                UserId = viewModel.Book.UserId,
                StatusId = viewModel.Book.StatusId
            };
            _addBooksService.CreateBook(book);
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.LoadBooks();
            this.Close();
            mainWindow.Show();
        }
    }
}
