namespace LabWork_31
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            MenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            CreateMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            SaveMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            DirectDefaultMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            CloseMenuItem = new ToolStripMenuItem();
            ViewMenuItem = new ToolStripMenuItem();
            DarkThemeMenuItem = new ToolStripMenuItem();
            FormatMenuItem = new ToolStripMenuItem();
            FormatMenuStrip = new ContextMenuStrip(components);
            ColorMenuItem = new ToolStripMenuItem();
            FontMenuItem = new ToolStripMenuItem();
            RichTextBox = new RichTextBox();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            ColorDialog = new ColorDialog();
            FontDialog = new FontDialog();
            FolderBrowserDialog = new FolderBrowserDialog();
            ToolStrip = new ToolStrip();
            FontStripComboBox = new ToolStripComboBox();
            LeftStripButton = new ToolStripButton();
            CenterStripButton = new ToolStripButton();
            RightStripButton = new ToolStripButton();
            StatusStrip = new StatusStrip();
            DateStatusLabel = new ToolStripStatusLabel();
            CharsCountStatusLabel = new ToolStripStatusLabel();
            Timer = new System.Windows.Forms.Timer(components);
            CharsCountNoSpaceStatusLabel = new ToolStripStatusLabel();
            MenuStrip.SuspendLayout();
            FormatMenuStrip.SuspendLayout();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem, ViewMenuItem, FormatMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 28);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateMenuItem, OpenMenuItem, SaveMenuItem, SettingsMenuItem, toolStripSeparator1, CloseMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(59, 24);
            FileMenuItem.Text = "Файл";
            // 
            // CreateMenuItem
            // 
            CreateMenuItem.Name = "CreateMenuItem";
            CreateMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateMenuItem.Size = new Size(216, 26);
            CreateMenuItem.Text = "Создать";
            CreateMenuItem.Click += CreateMenuItem_Click;
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenMenuItem.Size = new Size(216, 26);
            OpenMenuItem.Text = "Открыть";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // SaveMenuItem
            // 
            SaveMenuItem.Name = "SaveMenuItem";
            SaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveMenuItem.Size = new Size(216, 26);
            SaveMenuItem.Text = "Сохранить";
            SaveMenuItem.Click += SaveMenuItem_Click;
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DirectDefaultMenuItem });
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(216, 26);
            SettingsMenuItem.Text = "Настройки";
            // 
            // DirectDefaultMenuItem
            // 
            DirectDefaultMenuItem.Name = "DirectDefaultMenuItem";
            DirectDefaultMenuItem.Size = new Size(242, 26);
            DirectDefaultMenuItem.Text = "Папка по умолчанию";
            DirectDefaultMenuItem.Click += DirectDefaultMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // CloseMenuItem
            // 
            CloseMenuItem.Name = "CloseMenuItem";
            CloseMenuItem.Size = new Size(216, 26);
            CloseMenuItem.Text = "Закрыть";
            CloseMenuItem.Click += CloseMenuItem_Click;
            // 
            // ViewMenuItem
            // 
            ViewMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DarkThemeMenuItem });
            ViewMenuItem.Name = "ViewMenuItem";
            ViewMenuItem.Size = new Size(49, 24);
            ViewMenuItem.Text = "Вид";
            // 
            // DarkThemeMenuItem
            // 
            DarkThemeMenuItem.CheckOnClick = true;
            DarkThemeMenuItem.Name = "DarkThemeMenuItem";
            DarkThemeMenuItem.Size = new Size(182, 26);
            DarkThemeMenuItem.Text = "Ночная тема";
            DarkThemeMenuItem.CheckedChanged += DarkThemeMenuItem_CheckedChanged;
            // 
            // FormatMenuItem
            // 
            FormatMenuItem.DropDown = FormatMenuStrip;
            FormatMenuItem.Name = "FormatMenuItem";
            FormatMenuItem.Size = new Size(138, 24);
            FormatMenuItem.Text = "Форматировние";
            // 
            // FormatMenuStrip
            // 
            FormatMenuStrip.ImageScalingSize = new Size(20, 20);
            FormatMenuStrip.Items.AddRange(new ToolStripItem[] { ColorMenuItem, FontMenuItem });
            FormatMenuStrip.Name = "FormatMenuStrip";
            FormatMenuStrip.OwnerItem = FormatMenuItem;
            FormatMenuStrip.Size = new Size(127, 52);
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(126, 24);
            ColorMenuItem.Text = "Цвет";
            ColorMenuItem.Click += ColorMenuItem_Click;
            // 
            // FontMenuItem
            // 
            FontMenuItem.Name = "FontMenuItem";
            FontMenuItem.Size = new Size(126, 24);
            FontMenuItem.Text = "Шрифт";
            FontMenuItem.Click += FontMenuItem_Click;
            // 
            // RichTextBox
            // 
            RichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBox.ContextMenuStrip = FormatMenuStrip;
            RichTextBox.Location = new Point(0, 59);
            RichTextBox.Name = "RichTextBox";
            RichTextBox.Size = new Size(800, 391);
            RichTextBox.TabIndex = 1;
            RichTextBox.Text = "";
            RichTextBox.TextChanged += RichTextBox_TextChanged;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Filter = "Текстовые документы|*.txt|Текст в формате rtf|*.rtf|Все файлы|*.*";
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.Filter = "Текстовые документы|*.txt|Текст в формате rtf|*.rtf";
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(20, 20);
            ToolStrip.Items.AddRange(new ToolStripItem[] { FontStripComboBox, LeftStripButton, CenterStripButton, RightStripButton });
            ToolStrip.Location = new Point(0, 28);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(800, 28);
            ToolStrip.TabIndex = 2;
            ToolStrip.Text = "toolStrip1";
            // 
            // FontStripComboBox
            // 
            FontStripComboBox.Name = "FontStripComboBox";
            FontStripComboBox.Size = new Size(121, 28);
            FontStripComboBox.SelectedIndexChanged += FontStripComboBox_SelectedIndexChanged;
            // 
            // LeftStripButton
            // 
            LeftStripButton.Checked = true;
            LeftStripButton.CheckOnClick = true;
            LeftStripButton.CheckState = CheckState.Checked;
            LeftStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LeftStripButton.ImageTransparentColor = Color.Magenta;
            LeftStripButton.Name = "LeftStripButton";
            LeftStripButton.Size = new Size(128, 25);
            LeftStripButton.Text = "По левому краю";
            LeftStripButton.Click += LeftStripButton_Click;
            // 
            // CenterStripButton
            // 
            CenterStripButton.CheckOnClick = true;
            CenterStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            CenterStripButton.ImageTransparentColor = Color.Magenta;
            CenterStripButton.Name = "CenterStripButton";
            CenterStripButton.Size = new Size(85, 25);
            CenterStripButton.Text = "По центру";
            CenterStripButton.Click += CenterStripButton_Click;
            // 
            // RightStripButton
            // 
            RightStripButton.CheckOnClick = true;
            RightStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RightStripButton.Image = (Image)resources.GetObject("RightStripButton.Image");
            RightStripButton.ImageTransparentColor = Color.Magenta;
            RightStripButton.Name = "RightStripButton";
            RightStripButton.Size = new Size(138, 25);
            RightStripButton.Text = "По правому краю";
            RightStripButton.Click += RightStripButton_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { DateStatusLabel, CharsCountStatusLabel, CharsCountNoSpaceStatusLabel });
            StatusStrip.Location = new Point(0, 426);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 24);
            StatusStrip.TabIndex = 3;
            StatusStrip.Text = "statusStrip1";
            // 
            // DateStatusLabel
            // 
            DateStatusLabel.Name = "DateStatusLabel";
            DateStatusLabel.Size = new Size(0, 18);
            // 
            // CharsCountStatusLabel
            // 
            CharsCountStatusLabel.Name = "CharsCountStatusLabel";
            CharsCountStatusLabel.Size = new Size(0, 18);
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // CharsCountNoSpaceStatusLabel
            // 
            CharsCountNoSpaceStatusLabel.Name = "CharsCountNoSpaceStatusLabel";
            CharsCountNoSpaceStatusLabel.Size = new Size(0, 18);
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Controls.Add(RichTextBox);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            MinimumSize = new Size(300, 300);
            Name = "TextForm";
            Load += TextForm_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            FormatMenuStrip.ResumeLayout(false);
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
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
        private ColorDialog ColorDialog;
        private FontDialog FontDialog;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem DirectDefaultMenuItem;
        private FolderBrowserDialog FolderBrowserDialog;
        private ToolStripMenuItem CreateMenuItem;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem ViewMenuItem;
        private ToolStripMenuItem DarkThemeMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem FormatMenuItem;
        private ContextMenuStrip FormatMenuStrip;
        private ToolStripMenuItem ColorMenuItem;
        private ToolStripMenuItem FontMenuItem;
        private ToolStrip ToolStrip;
        private ToolStripComboBox FontStripComboBox;
        private ToolStripButton LeftStripButton;
        private ToolStripButton CenterStripButton;
        private ToolStripButton RightStripButton;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel DateStatusLabel;
        private System.Windows.Forms.Timer Timer;
        private ToolStripStatusLabel CharsCountStatusLabel;
        private ToolStripStatusLabel CharsCountNoSpaceStatusLabel;
    }
}
