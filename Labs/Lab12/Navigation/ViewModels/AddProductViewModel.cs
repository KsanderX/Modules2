using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Navigation.Models;
using Navigation.Services;
using Navigation.ViewModels.Commands;

namespace Navigation.ViewModels
{
    public class AddProductViewModel : ViewModelBase
    {
        private readonly IMVVMNavigationService _navigationService;
        private readonly IDbWork _dbWork;
        public AddProductViewModel(IMVVMNavigationService service, IDbWork dbWork)
        {
            _navigationService = service;
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


        public void LoadData()
        {
            Material = new ObservableCollection<Material>(_dbWork.GetAllMaterials().ToList());
        }

        private ICommand _saveChangesCommand;
        public ICommand SaveChangesCommand => _saveChangesCommand ?? new DelegatedCommand(
            execute: (_) =>
            {
                try
                {
                    var product = new Product
                    {
                        Name = Name,
                        Description = Description,
                        DateOfCreation = DateTime.Now,
                        DateOfLastEdit = DateTime.Now,
                        MaterialId = CurrentMaterial.Id
                    };
                    _dbWork.AddProduct(product);
                    _dbWork.SaveChanges();
                    MessageBox.Show("Выполнено успешно!");
                    _navigationService.NavigateTo<MainViewModel>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}");
                }

            }
            );

        private ICommand _cancelCommand;
        public ICommand CancelCommand => _cancelCommand ??= new DelegatedCommand(
            execute: (_) =>
            {
                _navigationService.NavigateTo<MainViewModel>();
            });
    }
}
