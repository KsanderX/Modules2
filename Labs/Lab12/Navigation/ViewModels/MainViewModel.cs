using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Navigation.Models;
using Navigation.Services;
using Navigation.ViewModels.Commands;

namespace Navigation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IMVVMNavigationService _navigationService;
        private readonly IDbWork _dbWork;
        public MainViewModel(IMVVMNavigationService service, IDbWork db)
        {
            Title = "Main Window";
            _navigationService = service;
            _dbWork = db;
            LoadData();
        }
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Product
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public void LoadData()
        {
            Product = new ObservableCollection<Product>(_dbWork.GetAllProducts());
        }

        private ICommand _addProductCommand = null!;
        public ICommand AddProductCommand => _addProductCommand ??= new DelegatedCommand(
            execute: (_) =>
            {
                _navigationService.NavigateTo<AddProductViewModel>();
            }
            );

        private ICommand _deleteProductCommand;
        public ICommand DeleteProductCommand => _deleteProductCommand ??= new DelegatedCommand(
            execute: (_) =>
            {
                try
                {
                    _dbWork.DeleteProduct(SelectedProduct.Id);
                    _dbWork.SaveChanges();
                    MessageBox.Show("Success");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}");
                }
            }
            );

        private ICommand _editProductCommand = null!;
        public ICommand EditProductCommand => _editProductCommand ??= new DelegatedCommand(
            execute: (obj) =>
            {
                if (obj is not Product product)
                    return;
                _navigationService.NavigateToEditProduct(product);
            }
        );
    }
}
