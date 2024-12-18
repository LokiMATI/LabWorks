namespace LabWork_34
{
    partial class MapForm
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
            LoadMenuItem = new ToolStripMenuItem();
            OpenFileDialog = new OpenFileDialog();
            FonPanel = new Panel();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { LoadMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 28);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // LoadMenuItem
            // 
            LoadMenuItem.Name = "LoadMenuItem";
            LoadMenuItem.Size = new Size(91, 24);
            LoadMenuItem.Text = "Загрузить";
            LoadMenuItem.Click += LoadMenuItem_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Filter = "Файл Txt|*.txt";
            // 
            // FonPanel
            // 
            FonPanel.Dock = DockStyle.Fill;
            FonPanel.Location = new Point(0, 28);
            FonPanel.Name = "FonPanel";
            FonPanel.Size = new Size(800, 422);
            FonPanel.TabIndex = 1;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FonPanel);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "MapForm";
            Text = "MapForm";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem LoadMenuItem;
        private OpenFileDialog OpenFileDialog;
        private Panel FonPanel;
    }
}