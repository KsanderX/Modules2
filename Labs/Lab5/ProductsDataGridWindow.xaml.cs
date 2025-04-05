using Lab5.Services;
using System.Windows;


namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для ProductsDataGridWindow.xaml
    /// </summary>
    public partial class ProductsDataGridWindow : Window
    { 
        private IDbWorker _worker;
        public ProductsDataGridWindow(IDbWorker dbWorker)
        {
            InitializeComponent();
            _worker = dbWorker;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _worker.SaveChanged();
        }
    }
}
