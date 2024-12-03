using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_26
{
    public partial class Mailing : Form
    {
        private StringBuilder _errorMessage = new StringBuilder();
        public Mailing()
        {
            InitializeComponent();
        }

        private void ConfirmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SubscribeButton.Enabled = !SubscribeButton.Enabled;
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text)) _errorMessage.AppendLine("Поле 'Логин' пустое.");
            if (String.IsNullOrWhiteSpace(EmailTextBox.Text)) _errorMessage.AppendLine("Поле 'Email' пустое.");
            if (_errorMessage.Length > 0)
            {
                MessageBox.Show(_errorMessage.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _errorMessage.Clear();
            }
            else
            {
                MessageBox.Show("Вы подписались на рассылку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Mailing_Load(object sender, EventArgs e)
        {

        }
    }
}
