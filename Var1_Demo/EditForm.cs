using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Var1_Demo.Models;

namespace Var1_Demo
{
    public partial class EditForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Book Book { get; private set; }
        public EditForm()
        {
            InitializeComponent();
        }
    }
}
