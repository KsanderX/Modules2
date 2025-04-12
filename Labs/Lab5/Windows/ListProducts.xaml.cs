using System.Windows;
using Lab5.Models;
using Lab5.Controls;
using Lab5.Services;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для ListProducts.xaml
    /// </summary>
    public partial class ListProducts : Window
    {
        private IDbWorker _dbWorker;
        private Material _material;
        public ListProducts(IDbWorker dbWorker, Material material)
        {
            InitializeComponent();
            _dbWorker = dbWorker;
            _material = material;
            if (_material != null)
            { 
                LoadProductsByMaterial();
            }
            else
            {
                LoadProducts();
            }

        }
        private void LoadProducts()
        {
            var products = _dbWorker.GetProducts();
            var materials = _dbWorker.GetMaterials();

            foreach (var product in products)
            {
                var productView = new ProductControl();
                var viewModel = new ViewModel()
                {
                    Product = product,
                    Materials = materials,
                };

                productView.DataContext = viewModel;

                stackPanel.Children.Add(productView);
            }
        }

        private void LoadProductsByMaterial()
        {
            var productsTest = _dbWorker.GetProductsMaterial(_material);
            var materials = _dbWorker.GetMaterials();

            foreach (var product in productsTest)
            {
                var productView = new ProductControl();
                var viewModel = new ViewModel()
                {
                    Product = product,
                    Materials = materials,
                };

                productView.DataContext = viewModel;

                stackPanel.Children.Add(productView);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _dbWorker.SaveChanged();
        }
    }
}
