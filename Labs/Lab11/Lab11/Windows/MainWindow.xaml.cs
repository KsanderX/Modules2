using System.Windows;
using Lab11.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (var context = new AppDbContext())
            {
                var books = context.Books.Include(s => s.Status).ToList();
                BooksListView.ItemsSource = books;
            }
        }
    }
}