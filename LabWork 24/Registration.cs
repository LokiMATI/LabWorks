namespace LabWork_24
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(LoginTextBox.Text)
                && PasswordTextBox.Text == PasswordConfirmTextBox.Text
                && !String.IsNullOrWhiteSpace(PasswordTextBox.Text)
                && !String.IsNullOrWhiteSpace(PasswordConfirmTextBox.Text))
            {


                MessageBox.Show($"{LoginTextBox.Text}, вы успешно зарегистрированны",
                    "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка заполнения",
                    "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (String.IsNullOrWhiteSpace(LoginTextBox.Text))
                {
                    LoginTextBox.BackColor = Color.FromName("Red");
                }
                if (PasswordTextBox.Text != PasswordConfirmTextBox.Text)
                {
                    PasswordConfirmTextBox.BackColor = Color.FromName("Red");
                }
            }
        }

        private void Navigation(Form FromForm, Form ToForm)
        {
            FromForm.Hide();
            ToForm.ShowDialog();
            FromForm.Show();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            LoginTextBox.BackColor = Color.FromName("White");
        }

        private void PasswordConfirmTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordConfirmTextBox.BackColor = Color.FromName("White");
        }

        private void CountryTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {

            
            //    CountryTextBox.Enabled = true;
            //}
            //else
            //{
            //    CountryTextBox.Enabled = false;
            //}


        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else e.Handled = true;
        }
    }
}
