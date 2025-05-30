using Navigation.Services;

namespace Navigation.ViewModels
{
    public class MVVM : ViewModelBase
    {
        private readonly IMVVMNavigationService _navigationService;

        public MVVM(IMVVMNavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.ViewModelChanged += OnViewModelChanged;
        }

        private void OnViewModelChanged(object? sender, ViewModelBase e)
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            OnPropertyChanged(nameof(Title));
        }

        public new string Title => _navigationService.CurrentViewModel.Title;
        public ViewModelBase CurrentViewModel => _navigationService.CurrentViewModel;
    }
}
