using System.Security.AccessControl;

namespace LabWork_23
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать " + DateTime.Now, "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            var result = MessageBox.Show("Хотите выйти?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TaskTwoButton_Click(object sender, EventArgs e) { 
            Windows form = new Windows();
            Navigation(this, form);
        }

        private void TaskThreeButton_Click(object sender, EventArgs e) { 
            DateGhost form = new DateGhost();
            Navigation(this, form);
        }

        private void TaskFourButton_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            Navigation(this, form);
        }

        private void Navigation(Form FromForm, Form ToForm)
        {
            FromForm.Hide();
            ToForm.ShowDialog();
            FromForm.Show();
        }
    }
}
