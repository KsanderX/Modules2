using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7.Models;

namespace Lab7.ViewModels
{
    public class PeopleViewModelMVVM : INotifyPropertyChanged
    {
        private PersonModelMVVM? _selectedPerson;

        public ObservableCollection<PersonModelMVVM> People { get; set; } = new()
        {
            new PersonModelMVVM {Id = 1, Name = "Sanchez", Birthday = new DateTime(2005, 2, 27), Description = "Sportic" },
            new PersonModelMVVM {Id = 2, Name = "George", Birthday = new(2005, 4, 29), Description = "The best swordsman"},
            new PersonModelMVVM {Id = 3, Name = "Alexey", Birthday = new(2005, 2, 11), Description = "Top dude"}
        };

        public PersonModelMVVM? SelectedPerson
        {
            get => _selectedPerson;
            set { _selectedPerson = value; OnPropertyChanged(nameof(SelectedPerson)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int _percentDone;
        private int PercentDone
        {
            get => _percentDone;
            set
            {
                if (_percentDone != value)
                {
                    _percentDone = value;
                    OnPropertyChanged(nameof(PercentDone));
                }
            }
        }
        private CancellationTokenSource? _cts;

        public async void BeginProcess()
        {
            _cts = new CancellationTokenSource();
            try
            {
                for (int i = PercentDone; i <= 100; i++)
                {
                    _cts.Token.ThrowIfCancellationRequested();
                    await Task.Delay(100);
                    PercentDone = i;
                }
            }
            catch (OperationCanceledException)
            {

            }
        }
        public void ResetProcess()
        {
            _cts?.Cancel();
            PercentDone = 0;
        }

    }
}
