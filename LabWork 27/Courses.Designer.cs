namespace LabWork_27
{
    partial class Courses
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
            CoursesCheckedListBox = new CheckedListBox();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // CoursesCheckedListBox
            // 
            CoursesCheckedListBox.FormattingEnabled = true;
            CoursesCheckedListBox.Items.AddRange(new object[] { "Руские народные пляски", "Программирование", "Вязание", "Повязание", "Завязание", "Песни послекишовского времени", "Педагогика", "Психология", "Психолгоия для психологов", "Психушка" });
            CoursesCheckedListBox.Location = new Point(12, 12);
            CoursesCheckedListBox.Name = "CoursesCheckedListBox";
            CoursesCheckedListBox.Size = new Size(258, 224);
            CoursesCheckedListBox.TabIndex = 0;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(73, 282);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(131, 29);
            SignUpButton.TabIndex = 1;
            SignUpButton.Text = "Записаться";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(SignUpButton);
            Controls.Add(CoursesCheckedListBox);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "Courses";
            Text = "Courses";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox CoursesCheckedListBox;
        private Button SignUpButton;
    }
}