using System.Windows;
using Lab5.Services;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для MaterialsDataGridWindow.xaml
    /// </summary>
    public partial class MaterialsDataGridWindow : Window
    {
        private IDbWorker _bWorker;
        public MaterialsDataGridWindow(IDbWorker dbWorker)
        {
            InitializeComponent();
            _bWorker = dbWorker;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _bWorker.SaveChanged();
        }
    }
}
