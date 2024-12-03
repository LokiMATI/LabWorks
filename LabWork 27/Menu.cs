namespace LabWork_27
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Navigation(Form FromForm, Form ToForm)
        {
            FromForm.Hide();
            ToForm.ShowDialog();
            FromForm.Show();
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            Ticket form = new Ticket();
            Navigation(this, form);
        }

        private void CoursesButton_Click(object sender, EventArgs e)
        {
            Courses form = new Courses();
            Navigation(this, form);
        }

        private void CityButton_Click(object sender, EventArgs e)
        {
            ListBoxs form = new ListBoxs();
            Navigation(this, form);
        }
    }
}
