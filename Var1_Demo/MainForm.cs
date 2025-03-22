using Microsoft.VisualBasic.ApplicationServices;
using Var1_Demo.Models;

namespace Var1_Demo
{
    public partial class MainForm : Form
    {
        private LibraryContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            dataGridView1.DataSource = _context.Books.ToList();
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}
