namespace LabWork_31
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

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LeftStripButton_Click(object sender, EventArgs e)
        {
            if (CenterStripButton.Checked || RightStripButton.Checked)
            {
                CenterStripButton.Checked = false;
                RightStripButton.Checked = false;
                LeftStripButton.Checked = true;
                RichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void CenterStripButton_Click(object sender, EventArgs e)
        {
            if (LeftStripButton.Checked || RightStripButton.Checked)
            {
                CenterStripButton.Checked = true;
                RightStripButton.Checked = false;
                LeftStripButton.Checked = false;
                RichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void RightStripButton_Click(object sender, EventArgs e)
        {
            if (CenterStripButton.Checked || LeftStripButton.Checked)
            {
                CenterStripButton.Checked = false;
                RightStripButton.Checked = true;
                LeftStripButton.Checked = false;
                RichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void FontStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(FontStripComboBox.Text, 9);
        }

        private void TextForm_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                FontStripComboBox.Items.Add(fontFamily.Name);
            }
            RichTextBox.SelectionFont = new Font("Arial", 9);
            DateStatusLabel.Text = DateTime.Now.ToString();
            string text = RichTextBox.Text.ToString();
            CharsCountStatusLabel.Text = text.Length.ToString();
            CharsCountNoSpaceStatusLabel.Text = (text.Length - text.Count(c => c == ' ')).ToString();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateStatusLabel.Text = DateTime.Now.ToString();
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = RichTextBox.Text.ToString();
            CharsCountStatusLabel.Text = text.Length.ToString();
            CharsCountNoSpaceStatusLabel.Text = (text.Length - text.Count(c => c == ' ')).ToString();
        }
    }
}
