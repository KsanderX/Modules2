using Lab5.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IDataService _dataService;
    public MainWindow(IDataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var materials = new MaterialDataGrid(_dataService);
        this.Hide();
        this.Close();
    }




    //public MainWindow()
    //{
    //    InitializeComponent();

    //    var groupe = new Group()
    //    {
    //        Name = "2307ca1"
    //    };
    //    var student = new Student()
    //    {
    //        Name = "sanechek",
    //        Group = groupe
    //    };

    //    //textBox1.Text = student.Name;
    //    //textBox2.Text = student.Group.Name;
    //    DataContext = student;
    //}
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public Group Group { get; set; }
    //}

    //public class Group
    //{
    //    public string Name { get; set; }
    //}   
}


