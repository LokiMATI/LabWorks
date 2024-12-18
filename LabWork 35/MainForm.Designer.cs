namespace LabWork_35
{
    partial class MainForm
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
            ToFirstFormButton = new Button();
            ToFirstFormDialogButton = new Button();
            ToMDIFormButton = new Button();
            SuspendLayout();
            // 
            // ToFirstFormButton
            // 
            ToFirstFormButton.Location = new Point(12, 42);
            ToFirstFormButton.Name = "ToFirstFormButton";
            ToFirstFormButton.Size = new Size(258, 29);
            ToFirstFormButton.TabIndex = 0;
            ToFirstFormButton.Text = "Открыть форму";
            ToFirstFormButton.UseVisualStyleBackColor = true;
            ToFirstFormButton.Click += ToFirstFormButton_Click;
            // 
            // ToFirstFormDialogButton
            // 
            ToFirstFormDialogButton.Location = new Point(12, 93);
            ToFirstFormDialogButton.Name = "ToFirstFormDialogButton";
            ToFirstFormDialogButton.Size = new Size(258, 29);
            ToFirstFormDialogButton.TabIndex = 1;
            ToFirstFormDialogButton.Text = "Открыть форму в диалоговом режиме";
            ToFirstFormDialogButton.UseVisualStyleBackColor = true;
            ToFirstFormDialogButton.Click += ToFirstFormDialogButton_Click;
            // 
            // ToMDIFormButton
            // 
            ToMDIFormButton.Location = new Point(12, 143);
            ToMDIFormButton.Name = "ToMDIFormButton";
            ToMDIFormButton.Size = new Size(258, 29);
            ToMDIFormButton.TabIndex = 2;
            ToMDIFormButton.Text = "Открыть mdi-форму";
            ToMDIFormButton.UseVisualStyleBackColor = true;
            ToMDIFormButton.Click += ToMDIFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(ToMDIFormButton);
            Controls.Add(ToFirstFormDialogButton);
            Controls.Add(ToFirstFormButton);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "MainForm";
            Text = "Главная форма";
            ResumeLayout(false);
        }

        #endregion

        private Button ToFirstFormButton;
        private Button ToFirstFormDialogButton;
        private Button ToMDIFormButton;
    }
}