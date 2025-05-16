using System.Windows;
using Lab7.Models;
using Lab7.ViewModels;

namespace Lab7.ViewsMVVM
{
    /// <summary>
    /// Логика взаимодействия для PeopleViewMVVM.xaml
    /// </summary>
    public partial class PeopleViewMVVM : Window
    {
        private PeopleViewModelMVVM vm;
        public PeopleViewMVVM()
        {
            InitializeComponent();
            this.DataContext = new PeopleViewModelMVVM();
        }
        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new PeopleViewMVVM
            {
                DataContext = this.DataContext
            };
            window.Show();
        }

        private void Change_Selected_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PeopleViewModelMVVM viewModel && viewModel.SelectedPerson != null)
            {
                viewModel.SelectedPerson.Name = "Новое имя";
                viewModel.SelectedPerson.Description = "Новое описание";
                viewModel.SelectedPerson.Birthday = DateTime.Now;
            }
        }

        private void PushNewItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataContext is PeopleViewModelMVVM viewModel)
                {
                    var newPerson = new PersonModelMVVM
                    {
                        Id = viewModel.People.Count + 1,
                        Name = "Новый человек",
                        Description = "Новое описание",
                        Birthday = new DateTime(2000, 1, 1)
                    };

                    viewModel.People.Add(newPerson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void PopLastItem_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PeopleViewModelMVVM viewModel && viewModel.People.Count > 0)
            {
                viewModel.People.RemoveAt(viewModel.People.Count - 1);
            }
        }

        private void BeginProcess_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is PeopleViewModelMVVM vm)
            {
                vm.BeginProcess();
            }
        }

        private void ResetProcess_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is PeopleViewModelMVVM vm)
            {
                vm.ResetProcess();
            }
        }
    }
}
