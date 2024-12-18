namespace LabWork_34
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToTimerButton_Click(object sender, EventArgs e)
        {
            TimerForm form = new TimerForm();
            Navigate(form);
        }

        private void Navigate(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ToTheWORLDOfCapibaraButton_Click(object sender, EventArgs e)
        {
            TheWORLDOfCapibaraForm form = new TheWORLDOfCapibaraForm();
            Navigate(form);
        }

        private void ToMapButton_Click(object sender, EventArgs e)
        {
            MapForm form = new MapForm();
            Navigate(form);
        }
    }
}
