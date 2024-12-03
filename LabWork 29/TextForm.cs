namespace LabWork_29
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
    }
}
