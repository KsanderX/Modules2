using System.Windows;
using System.Windows.Input;
using Navigation.Models;
using Navigation.Services;
using Navigation.ViewModels.Commands;
using System.Collections.ObjectModel;

namespace Navigation.ViewModels
{
    public class EditProductViewModel : ViewModelBase
    {
        private readonly IMVVMNavigationService _navigationService;
        private readonly IDbWork _dbWork;
        private int _productId;
        public EditProductViewModel(IMVVMNavigationService navigationService, IDbWork dbWork)
        {
            _navigationService = navigationService;
            _dbWork = dbWork;
            LoadData();

        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private ObservableCollection<Material> _materials;
        public ObservableCollection<Material> Material
        {
            get => _materials;
            set
            {
                _materials = value;
                OnPropertyChanged(nameof(Material));
            }
        }

        private Material _currentMaterial;
        public Material CurrentMaterial
        {
            get => _currentMaterial;
            set
            {
                _currentMaterial = value;
                OnPropertyChanged(nameof(CurrentMaterial));
            }
        }

        private Product _currentProduct;
        public Product CurrentProduct
        {
            get => _currentProduct;
            set
            {
                _currentProduct = value;
                OnPropertyChanged(nameof(CurrentProduct));
            }
        }


        public void LoadData()
        {
            var materials = _dbWork.GetAllMaterials().ToList();
            Material = new ObservableCollection<Material>(materials);

            if (CurrentProduct != null)
            {
                Name = CurrentProduct.Name;
                Description = CurrentProduct.Description;

                if (CurrentProduct.MaterialId.HasValue)
                {
                    CurrentMaterial = Material.FirstOrDefault(m => m.Id == CurrentProduct.MaterialId.Value);
                }
            }
        }

        public void LoadProduct(int id)
        {
            _productId = id;
            var product = _dbWork.GetProductById(id);
            if (product != null)
            {
                CurrentProduct = product;
                LoadData();
            }
            else
            {
                MessageBox.Show($"Error!");
                _navigationService.NavigateTo<MainViewModel>();
            }
        }


        private ICommand _saveChangesCommand;
        public ICommand SaveChangesCommand => _saveChangesCommand ?? new DelegatedCommand(
            execute: (_) =>
            {
                CurrentProduct.Name = Name;
                CurrentProduct.Description = Description;
                CurrentProduct.DateOfLastEdit = DateTime.Now;
                CurrentProduct.MaterialId = CurrentMaterial.Id;
                _dbWork.UpdateProduct(CurrentProduct);
                _dbWork.SaveChanges();
                _navigationService.NavigateTo<MainViewModel>();
            }
            );

        private ICommand _cancelCommand;
        public ICommand CancelCommand => _cancelCommand ??= new DelegatedCommand(
            execute: (_) =>
            {
                _navigationService.NavigateTo<MainViewModel>();
            }
            );
    }
}
