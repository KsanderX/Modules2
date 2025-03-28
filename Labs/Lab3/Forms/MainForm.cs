using Microsoft.Extensions.DependencyInjection;

namespace Lab3
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            using (var loginDialog = _serviceProvider.GetRequiredService<LoginDialog>())
            {
                if (loginDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Успешно");
                }
            }
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            using (var registerDialog = _serviceProvider.GetRequiredService<RegisterDialog>())
            {
                if(registerDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Успешно");
                }
            }
        }
    }
}
