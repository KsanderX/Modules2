using System.Windows;
using System.Windows.Controls;
using Lab5.Models;
using Lab5.Services;

namespace Lab5.Controls
{
    /// <summary>
    /// Логика взаимодействия для MaterialsControl1.xaml
    /// </summary>
    public partial class MaterialsControl : UserControl
    {
        private IDbWorker _dbWorker;
        public MaterialsControl(IDbWorker worker)
        {
            InitializeComponent();
            _dbWorker = worker;
        }
        private void btnOpenProducts_Click(object sender, RoutedEventArgs e)
        {
            _dbWorker.SaveChanged();
        }

        private void btnOpenProducts_Click_1(object sender, RoutedEventArgs e)
        {
            Material selectedProduct = _dbWorker.GetMaterialId(int.Parse(tbId.Text));
            var products = new ListProducts(_dbWorker, selectedProduct);
            products.ShowDialog();
        }
    }
}
