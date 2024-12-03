namespace LabWork_26
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MallingButton_Click(object sender, EventArgs e)
        {
            Mailing form = new Mailing();
            Navigation(this, form);

        }
        private void Navigation(Form FromForm, Form ToForm)
        {
            FromForm.Hide();
            ToForm.ShowDialog();
            FromForm.Show();
        }

        private void ConverterButton_Click(object sender, EventArgs e)
        {
            Converter form = new Converter();
            Navigation(this, form);
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            Ticket form = new Ticket();
            Navigation(this, form);
        }
    }
}
