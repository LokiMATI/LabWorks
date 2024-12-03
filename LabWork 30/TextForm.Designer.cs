namespace LabWork_30
{
    partial class TextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            CreateMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            SaveMenuItem = new ToolStripMenuItem();
            ColorMenuItem = new ToolStripMenuItem();
            FontMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            DirectDefaultMenuItem = new ToolStripMenuItem();
            CloseMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            DarkThemeMenuItem = new ToolStripMenuItem();
            RichTextBox = new RichTextBox();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            ColorDialog = new ColorDialog();
            FontDialog = new FontDialog();
            FolderBrowserDialog = new FolderBrowserDialog();
            HelloMenuItem = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem, видToolStripMenuItem, HelloMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 28);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateMenuItem, OpenMenuItem, SaveMenuItem, ColorMenuItem, FontMenuItem, SettingsMenuItem, CloseMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(59, 24);
            FileMenuItem.Text = "Файл";
            // 
            // CreateMenuItem
            // 
            CreateMenuItem.Name = "CreateMenuItem";
            CreateMenuItem.Size = new Size(167, 26);
            CreateMenuItem.Text = "Создать";
            CreateMenuItem.Click += CreateMenuItem_Click;
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(167, 26);
            OpenMenuItem.Text = "Открыть";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // SaveMenuItem
            // 
            SaveMenuItem.Name = "SaveMenuItem";
            SaveMenuItem.Size = new Size(167, 26);
            SaveMenuItem.Text = "Сохранить";
            SaveMenuItem.Click += SaveMenuItem_Click;
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(167, 26);
            ColorMenuItem.Text = "Цвет";
            ColorMenuItem.Click += ColorMenuItem_Click;
            // 
            // FontMenuItem
            // 
            FontMenuItem.Name = "FontMenuItem";
            FontMenuItem.Size = new Size(167, 26);
            FontMenuItem.Text = "Шрифт";
            FontMenuItem.Click += FontMenuItem_Click;
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DirectDefaultMenuItem });
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(167, 26);
            SettingsMenuItem.Text = "Настройки";
            // 
            // DirectDefaultMenuItem
            // 
            DirectDefaultMenuItem.Name = "DirectDefaultMenuItem";
            DirectDefaultMenuItem.Size = new Size(242, 26);
            DirectDefaultMenuItem.Text = "Папка по умолчанию";
            DirectDefaultMenuItem.Click += DirectDefaultMenuItem_Click;
            // 
            // CloseMenuItem
            // 
            CloseMenuItem.Name = "CloseMenuItem";
            CloseMenuItem.Size = new Size(167, 26);
            CloseMenuItem.Text = "Закрыть";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DarkThemeMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(49, 24);
            видToolStripMenuItem.Text = "Вид";
            // 
            // DarkThemeMenuItem
            // 
            DarkThemeMenuItem.CheckOnClick = true;
            DarkThemeMenuItem.Name = "DarkThemeMenuItem";
            DarkThemeMenuItem.Size = new Size(182, 26);
            DarkThemeMenuItem.Text = "Ночная тема";
            DarkThemeMenuItem.CheckedChanged += DarkThemeMenuItem_CheckedChanged;
            // 
            // RichTextBox
            // 
            RichTextBox.Dock = DockStyle.Fill;
            RichTextBox.Location = new Point(0, 28);
            RichTextBox.Name = "RichTextBox";
            RichTextBox.Size = new Size(800, 422);
            RichTextBox.TabIndex = 1;
            RichTextBox.Text = "";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Filter = "Текстовые документы|*.txt|Текст в формате rtf|*.rtf|Все файлы|*.*";
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.Filter = "Текстовые документы|*.txt|Текст в формате rtf|*.rtf";
            // 
            // HelloMenuItem
            // 
            HelloMenuItem.Name = "HelloMenuItem";
            HelloMenuItem.Size = new Size(112, 24);
            HelloMenuItem.Text = "Приветствие";
            HelloMenuItem.Click += HelloMenuItem_Click;
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RichTextBox);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            MinimumSize = new Size(300, 300);
            Name = "TextForm";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private RichTextBox RichTextBox;
        private OpenFileDialog OpenFileDialog;
        private ToolStripMenuItem SaveMenuItem;
        private SaveFileDialog SaveFileDialog;
        private ToolStripMenuItem ColorMenuItem;
        private ColorDialog ColorDialog;
        private ToolStripMenuItem FontMenuItem;
        private FontDialog FontDialog;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem DirectDefaultMenuItem;
        private FolderBrowserDialog FolderBrowserDialog;
        private ToolStripMenuItem CreateMenuItem;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem DarkThemeMenuItem;
        private ToolStripMenuItem HelloMenuItem;
    }
}
