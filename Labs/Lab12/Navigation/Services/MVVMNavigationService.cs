using Microsoft.Extensions.DependencyInjection;
using Navigation.Models;
using Navigation.ViewModels;

namespace Navigation.Services
{
    public class MVVMNavigationService : IMVVMNavigationService
    {
       private readonly IServiceProvider _serviceProvider;
        public MVVMNavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public event EventHandler<ViewModelBase> ViewModelChanged = null!;

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                ViewModelChanged?.Invoke(this, value);
            } 
        }


        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            CurrentViewModel = _serviceProvider.GetRequiredService<TViewModel>();
        }

        public void NavigateToEditProduct(Product product)
        {
            var viewModel = _serviceProvider.GetRequiredService<EditProductViewModel>();
            viewModel.LoadProduct(product.Id);
            CurrentViewModel = viewModel;
        }
    }
}
