using Navigation.Models;
using Navigation.ViewModels;

namespace Navigation.Services
{
    public interface IMVVMNavigationService
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase;
        public event EventHandler<ViewModelBase> ViewModelChanged;
        public void NavigateToEditProduct(Product product);
    }
}
