using System.Windows;
using Lab5.Controls;
using Lab5.Services;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для ListMaterials.xaml
    /// </summary>
    public partial class ListMaterials : Window
    {
        IDbWorker _dbWorker;
        public ListMaterials(IDbWorker dbWorker)
        {
            InitializeComponent();
            _dbWorker = dbWorker;

            var materials = _dbWorker.GetMaterials();
            foreach (var material in materials)
            {
                var materialControls = new MaterialsControl(_dbWorker);
                materialControls.DataContext = material;
                stackPanel.Children.Add(materialControls);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _dbWorker.SaveChanged();
        }
    }
}
