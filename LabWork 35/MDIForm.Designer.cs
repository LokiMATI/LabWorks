namespace LabWork_35
{
    partial class MDIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip = new MenuStrip();
            NewFormMenuItem = new ToolStripMenuItem();
            ToFirstFormMenuItem = new ToolStripMenuItem();
            ToSecondFormMenuItem = new ToolStripMenuItem();
            ToThirdFormMenuItem = new ToolStripMenuItem();
            CloseAllMenuItem = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { NewFormMenuItem, CloseAllMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 28);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // NewFormMenuItem
            // 
            NewFormMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToFirstFormMenuItem, ToSecondFormMenuItem, ToThirdFormMenuItem });
            NewFormMenuItem.Name = "NewFormMenuItem";
            NewFormMenuItem.Size = new Size(118, 24);
            NewFormMenuItem.Text = "Новая форма";
            // 
            // ToFirstFormMenuItem
            // 
            ToFirstFormMenuItem.Name = "ToFirstFormMenuItem";
            ToFirstFormMenuItem.Size = new Size(195, 26);
            ToFirstFormMenuItem.Text = "Первая форма";
            ToFirstFormMenuItem.Click += ToFirstFormMenuItem_Click;
            // 
            // ToSecondFormMenuItem
            // 
            ToSecondFormMenuItem.Name = "ToSecondFormMenuItem";
            ToSecondFormMenuItem.Size = new Size(195, 26);
            ToSecondFormMenuItem.Text = "Вторая форма";
            ToSecondFormMenuItem.Click += ToSecondFormMenuItem_Click;
            // 
            // ToThirdFormMenuItem
            // 
            ToThirdFormMenuItem.Name = "ToThirdFormMenuItem";
            ToThirdFormMenuItem.Size = new Size(195, 26);
            ToThirdFormMenuItem.Text = "Третья форма";
            ToThirdFormMenuItem.Click += ToThirdFormMenuItem_Click;
            // 
            // CloseAllMenuItem
            // 
            CloseAllMenuItem.Name = "CloseAllMenuItem";
            CloseAllMenuItem.Size = new Size(107, 24);
            CloseAllMenuItem.Text = "Закрыть всё";
            CloseAllMenuItem.Click += this.CloseAllMenuItem_Click;
            // 
            // MDIForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip;
            Name = "MDIForm";
            Text = "MDI форма";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem NewFormMenuItem;
        private ToolStripMenuItem ToFirstFormMenuItem;
        private ToolStripMenuItem ToSecondFormMenuItem;
        private ToolStripMenuItem ToThirdFormMenuItem;
        private ToolStripMenuItem CloseAllMenuItem;
    }
}
