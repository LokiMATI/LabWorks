namespace LabWork_34
{
    partial class MainForm
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
            ToTimerButton = new Button();
            ToTheWORLDOfCapibaraButton = new Button();
            ToMapButton = new Button();
            SuspendLayout();
            // 
            // ToTimerButton
            // 
            ToTimerButton.Location = new Point(92, 34);
            ToTimerButton.Name = "ToTimerButton";
            ToTimerButton.Size = new Size(94, 29);
            ToTimerButton.TabIndex = 0;
            ToTimerButton.Text = "Таймер";
            ToTimerButton.UseVisualStyleBackColor = true;
            ToTimerButton.Click += ToTimerButton_Click;
            // 
            // ToTheWORLDOfCapibaraButton
            // 
            ToTheWORLDOfCapibaraButton.Location = new Point(92, 89);
            ToTheWORLDOfCapibaraButton.Name = "ToTheWORLDOfCapibaraButton";
            ToTheWORLDOfCapibaraButton.Size = new Size(94, 29);
            ToTheWORLDOfCapibaraButton.TabIndex = 1;
            ToTheWORLDOfCapibaraButton.Text = "Капибара";
            ToTheWORLDOfCapibaraButton.UseVisualStyleBackColor = true;
            ToTheWORLDOfCapibaraButton.Click += ToTheWORLDOfCapibaraButton_Click;
            // 
            // ToMapButton
            // 
            ToMapButton.Location = new Point(92, 153);
            ToMapButton.Name = "ToMapButton";
            ToMapButton.Size = new Size(94, 29);
            ToMapButton.TabIndex = 2;
            ToMapButton.Text = "Карта";
            ToMapButton.UseVisualStyleBackColor = true;
            ToMapButton.Click += ToMapButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(ToMapButton);
            Controls.Add(ToTheWORLDOfCapibaraButton);
            Controls.Add(ToTimerButton);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "MainForm";
            Text = "Главная форма";
            ResumeLayout(false);
        }

        #endregion

        private Button ToTimerButton;
        private Button ToTheWORLDOfCapibaraButton;
        private Button ToMapButton;
    }
}
