using Lab5.Models;
using Lab5.Services;
using Microsoft.EntityFrameworkCore;
using System.Windows;


namespace Lab5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private AppDbContext _context;
    private IDbWorker _dbWorker;
    public MainWindow(IDbWorker dbWorker)
    {
        InitializeComponent();
        _context = new AppDbContext();
        _dbWorker = dbWorker;
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
    private void btnOpenDataGridMaterials2_Click(object sender, RoutedEventArgs e)
    {
        var material = new MaterialsDataGridWindow(_dbWorker);
        material.DataContext = _dbWorker.GetMaterials();
        material.ShowDialog();
    }

    private void btnOpenDataGridProducts2_Click(object sender, RoutedEventArgs e)
    {
        var product = new ProductsDataGridWindow(_dbWorker);
        product.DataContext = _dbWorker.GetProducts();
        product.ShowDialog();
    }
}


