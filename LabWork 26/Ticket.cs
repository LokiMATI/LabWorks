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
    public partial class Ticket : Form
    {
        private StringBuilder _errorMessage = new StringBuilder();
        public Ticket()
        {
            InitializeComponent();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FromTextBox.Text)) _errorMessage.AppendLine("Вы не ввели откуда вылетаете.");
            if (String.IsNullOrEmpty(ToTextBox.Text)) _errorMessage.AppendLine("Вы не ввели куда вылетаете.");
            if (_errorMessage.Length > 0 ){
                MessageBox.Show(_errorMessage.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                _errorMessage.Clear();
            }
            else
            {
                if (ToCheckBox.Checked) MessageBox.Show($"Билет: {FromDateTimePicker.Value.ToString()} {FromTextBox.Text} - {ToTextBox.Text}\nОбратный билет: {ToDateTimePicker.Value.ToString()} {ToTextBox.Text} - {FromTextBox.Text}", "Билет заказан", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"Билет: {FromDateTimePicker.Value.ToString()} {FromTextBox.Text} - {ToTextBox.Text}", "Билет заказан", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
