using System.Windows;
using Lab11.Models;
using Lab11.Services;
using Lab11.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IServiceProvider _serviceProvider;
        private IAddBooksService _addBooksService;

        public MainWindow(IServiceProvider serviceProvider, IAddBooksService addBooksService)
        {
            InitializeComponent();
            LoadBooks();
            _serviceProvider = serviceProvider;
            _addBooksService = addBooksService;
        }

        public void LoadBooks()
        {
            using (var context = new AppDbContext())
            {
                var books = context.Books.Include(s => s.Status).Include(u => u.User).ToList();
                BooksListView.ItemsSource = books;
            }
        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (BooksListView.SelectedItem is Book selectedBook)
            {
                _addBooksService.DeleteBook(selectedBook);
                LoadBooks();
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления.");
            }
        }

        private void btnLogout_Clickbtn(object sender, RoutedEventArgs e)
        {
            var autorizationWindow = _serviceProvider.GetRequiredService<AutorizationWindow>();
            this.Close();
            autorizationWindow.Show();
        }

        private void btnAddBooks_Clickbtn(object sender, RoutedEventArgs e)
        {
            var addBookWindow = _serviceProvider.GetRequiredService<AddBookWindow>();
            this.Close();
            addBookWindow.ShowDialog();
        }
    }
}