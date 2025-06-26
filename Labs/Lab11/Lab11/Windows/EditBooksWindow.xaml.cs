using System.Windows;
using Lab11.Models;
using Lab11.Services;

namespace Lab11.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditBooksWindow.xaml
    /// </summary>
    public partial class EditBooksWindow : Window
    {
        private readonly IAddBooksService _addBooksService;
        private Book _bookToEdit;

        public EditBooksWindow(IAddBooksService addBooksService, Book bookToEdit)
        {
            InitializeComponent();
            _addBooksService = addBooksService;
            _bookToEdit = bookToEdit;

            DataContext = new
            {
                Book = _bookToEdit,
                Users = _addBooksService.GetUsers(),
                Statuses = _addBooksService.GetStatuses()
            };
        }
        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _addBooksService.UpdateBook(_bookToEdit);
                _addBooksService.Save();

                MessageBox.Show("Книга успешно обновлена.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении книги: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}