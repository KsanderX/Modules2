using Lab7.Models;
using Lab7.ViewModels;
using System.Windows;


namespace Lab7.Views
{
    /// <summary>
    /// Логика взаимодействия для PeopleView.xaml
    /// </summary>
    public partial class PeopleView : Window
    {
        private PeopleViewModelSimple vm;
        public PeopleView()
        {
            InitializeComponent();
            vm = new PeopleViewModelSimple();
            this.DataContext = vm;
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new PeopleView();
            window.DataContext = this.DataContext;
            window.Show();
        }

        private void Change_Selected_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectedPerson != null)
            {
                vm.SelectedPerson.Name = "Updated" + vm.SelectedPerson.Name;
                vm.SelectedPerson.Description += "[edited]";    
                RefreshDataContext();
            }
        }

        private void PushNewItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newPerson = new PersonModelSimple
                {
                    Id = vm.People.Max(p => p.Id) + 1,
                    Name = "New Person",
                    Birthday = DateTime.Now,
                    Description = "Just added"
                };
                vm.People.Add(newPerson);
                vm.SelectedPerson = newPerson;
                RefreshDataContext();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void PopLastItem_Click(object sender, RoutedEventArgs e)
        {
            if (vm.People.Count > 0)
            {
                vm.People.RemoveAt(vm.People.Count - 1);
                vm.SelectedPerson = vm.People.LastOrDefault();
                RefreshDataContext();
            }
        }
        private void RefreshDataContext()
        {
            this.DataContext = null;
            this.DataContext = vm;
        }
    }
}
