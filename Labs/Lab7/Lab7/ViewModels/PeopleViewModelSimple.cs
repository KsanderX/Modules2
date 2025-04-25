using System.Collections.ObjectModel;
using System.ComponentModel;
using Lab7.Models;


namespace Lab7.ViewModels
{
    public class PeopleViewModelSimple : INotifyPropertyChanged
    {
        private PersonModelSimple _selectedPerson;
        public ObservableCollection<PersonModelSimple> People { get; set; } = new()
        {
            new PersonModelSimple  {Id = 1, Name = "Sanchez", Birthday = new (2005, 2, 27), Description = "Sportic"},
            new PersonModelSimple {Id = 2, Name = "George", Birthday = new (2005, 4, 29), Description = "The best swordsman"},
            new PersonModelSimple {Id = 3, Name = "Alexey", Birthday = new(2005, 2, 11), Description = "Top dude" }

        };
        public PersonModelSimple? SelectedPerson
        {
            get => _selectedPerson;
            set { _selectedPerson = value; OnPropertyChanged(nameof(SelectedPerson)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
