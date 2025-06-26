using System.Collections;
using System.Windows;
using Lab5.Models;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для DataGridWindow.xaml
    /// </summary>
    public partial class DataGridWindow : Window
    {
        private IEnumerable _itemsSource;
        private AppDbContext _context;
        public DataGridWindow(IEnumerable itemSourse, AppDbContext context)
        {
            InitializeComponent();
            _itemsSource = itemSourse;
            dataGrid.ItemsSource = _itemsSource;
            _context = context;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
