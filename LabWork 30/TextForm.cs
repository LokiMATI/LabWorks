namespace LabWork_30
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Text = Path.GetFileName(OpenFileDialog.FileName);
                    RichTextBox.Text = File.ReadAllText(OpenFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text);
                    MessageBox.Show("Данные сохранены", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionColor = ColorDialog.Color;
            }
        }

        private void FontMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionFont = FontDialog.Font;
            }
        }

        private void DirectDefaultMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog.InitialDirectory = FolderBrowserDialog.InitialDirectory;
                SaveFileDialog.InitialDirectory = FolderBrowserDialog.InitialDirectory;
            }
        }

        private void CreateMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Безымянный";
            RichTextBox.Text = string.Empty;
        }

        private void DarkThemeMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            MenuStrip.BackColor = DarkThemeMenuItem.Checked ? Color.FromArgb(36, 36, 36) : Color.White;
            RichTextBox.BackColor = MenuStrip.BackColor;
            MenuStrip.ForeColor = DarkThemeMenuItem.Checked ? Color.White : Color.FromArgb(36, 36, 36);
            RichTextBox.ForeColor = MenuStrip.ForeColor;
        }

        private void HelloMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new HelloForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
