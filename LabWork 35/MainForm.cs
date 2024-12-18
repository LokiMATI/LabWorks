using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_35
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToFirstFormButton_Click(object sender, EventArgs e)
        {
            FirstForm form = new FirstForm();
            form.Show();
        }

        private void ToFirstFormDialogButton_Click(object sender, EventArgs e)
        {
            FirstForm form = new FirstForm();
            form.ShowDialog();
        }

        private void ToMDIFormButton_Click(object sender, EventArgs e)
        {
            MDIForm form = new MDIForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
