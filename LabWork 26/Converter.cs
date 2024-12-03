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
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputTextBox.Text)) OutputLable.Text = "В поле ввода пусто";
            if (InchRadioButton.Checked) OutputLable.Text = Convert.ToString(Decimal.Round(decimal.Parse(InputTextBox.Text) * (decimal)0.0254, 2));
            if (KilometersRadioButton.Checked) OutputLable.Text = Convert.ToString(Decimal.Round(decimal.Parse(InputTextBox.Text) * 1000, 2));
            if (CentimetersRadioButton.Checked) OutputLable.Text = Convert.ToString(Decimal.Round(decimal.Parse(InputTextBox.Text) * (decimal)0.01, 2));
            if (FeetRadioButton.Checked) OutputLable.Text = Convert.ToString(Decimal.Round(decimal.Parse(InputTextBox.Text) * (decimal)0.3048, 2));
        }
    }
}
