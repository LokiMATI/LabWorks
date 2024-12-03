namespace LabWork_25
{
    public partial class LabWork : Form
    {
        public LabWork()
        {
            InitializeComponent();
            BirthDateTimePicker.MaxDate = DateTime.Now;
        }

        private void BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var age = DateTime.Now.Year - BirthDateTimePicker.Value.Year;
            AgeLabel.Text = age.ToString();
        }

        private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TemperatureTextBox.Text = TemperatureTrackBar.Value.ToString();
        }

        private void TemperatureTextBox_TextChanged(object sender, EventArgs e)
        {
            TemperatureTrackBar.Value = int.Parse(TemperatureTextBox.Text);
        }

        private void RadiusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ResultSquareSphereLabel.Text = Convert.ToString(Decimal.Round(RadiusNumericUpDown.Value * RadiusNumericUpDown.Value * (decimal)3.14 * (decimal)4, 2));
            ResultVolumeSphereLabel.Text = Convert.ToString(Decimal.Round(RadiusNumericUpDown.Value * RadiusNumericUpDown.Value * RadiusNumericUpDown.Value * (decimal)3.14 * 4 / 3, 2));
        }
    }
}
