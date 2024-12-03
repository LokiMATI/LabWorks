namespace LabWork_23
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
            TaskTwoButton = new Button();
            TaskThreeButton = new Button();
            TaskFourButton = new Button();
            SuspendLayout();
            // 
            // TaskTwoButton
            // 
            TaskTwoButton.Location = new Point(78, 68);
            TaskTwoButton.Name = "TaskTwoButton";
            TaskTwoButton.Size = new Size(94, 29);
            TaskTwoButton.TabIndex = 0;
            TaskTwoButton.Text = "Задание 2";
            TaskTwoButton.UseVisualStyleBackColor = true;
            TaskTwoButton.Click += TaskTwoButton_Click;
            // 
            // TaskThreeButton
            // 
            TaskThreeButton.Location = new Point(78, 134);
            TaskThreeButton.Name = "TaskThreeButton";
            TaskThreeButton.Size = new Size(94, 29);
            TaskThreeButton.TabIndex = 1;
            TaskThreeButton.Text = "Задание 3";
            TaskThreeButton.UseVisualStyleBackColor = true;
            TaskThreeButton.Click += TaskThreeButton_Click;
            // 
            // TaskFourButton
            // 
            TaskFourButton.Location = new Point(78, 195);
            TaskFourButton.Name = "TaskFourButton";
            TaskFourButton.Size = new Size(94, 29);
            TaskFourButton.TabIndex = 2;
            TaskFourButton.Text = "Задание 4";
            TaskFourButton.UseVisualStyleBackColor = true;
            TaskFourButton.Click += this.TaskFourButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(232, 303);
            Controls.Add(TaskFourButton);
            Controls.Add(TaskThreeButton);
            Controls.Add(TaskTwoButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button TaskTwoButton;
        private Button TaskThreeButton;
        private Button TaskFourButton;
    }
}
