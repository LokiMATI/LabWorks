namespace LabWork_28
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Navigation(Form FromForm, Form ToForm)
        {
            FromForm.Hide();
            ToForm.ShowDialog();
            FromForm.Show();
        }

        private void DataButton_Click(object sender, EventArgs e)
        {
            Data form = new Data();
            Navigation(this, form);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            Navigation(this, form);
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            StoreForm form = new StoreForm();
            Navigation(this, form);
        }
    }
}
