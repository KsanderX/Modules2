using Lab5.Models;
using Lab5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;


namespace Lab5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private AppDbContext _context;
    public MainWindow()
    {
        InitializeComponent();
        _context = new AppDbContext();
    }

    private void btnOpenDataGridMaterials_Click(object sender, RoutedEventArgs e)
    {
        var findMaterials = _context.Materials.Include(m => m.Products).ToList();
        var dataGridWindowWithProducts = new DataGridWindow(findMaterials, _context);
        dataGridWindowWithProducts.ShowDialog();
    }

    private void btnOpenDataGridProducts_Click(object sender, RoutedEventArgs e)
    {
        var findProducts = _context.Products.Include(p => p.Materials).ToList();
        var dataGridWindowWithMaterials = new DataGridWindow(findProducts, _context);
        dataGridWindowWithMaterials.ShowDialog();
    }

}


