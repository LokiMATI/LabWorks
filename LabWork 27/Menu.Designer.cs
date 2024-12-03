namespace LabWork_27
{
    partial class Menu
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
            TicketButton = new Button();
            CoursesButton = new Button();
            CityButton = new Button();
            SuspendLayout();
            // 
            // TicketButton
            // 
            TicketButton.Location = new Point(83, 67);
            TicketButton.Name = "TicketButton";
            TicketButton.Size = new Size(94, 29);
            TicketButton.TabIndex = 0;
            TicketButton.Text = "Билеты";
            TicketButton.UseVisualStyleBackColor = true;
            TicketButton.Click += TicketButton_Click;
            // 
            // CoursesButton
            // 
            CoursesButton.Location = new Point(83, 136);
            CoursesButton.Name = "CoursesButton";
            CoursesButton.Size = new Size(94, 29);
            CoursesButton.TabIndex = 1;
            CoursesButton.Text = "Курсы";
            CoursesButton.UseVisualStyleBackColor = true;
            CoursesButton.Click += CoursesButton_Click;
            // 
            // CityButton
            // 
            CityButton.Location = new Point(83, 200);
            CityButton.Name = "CityButton";
            CityButton.Size = new Size(94, 29);
            CityButton.TabIndex = 2;
            CityButton.Text = "Списки";
            CityButton.UseVisualStyleBackColor = true;
            CityButton.Click += CityButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(CityButton);
            Controls.Add(CoursesButton);
            Controls.Add(TicketButton);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "Menu";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button TicketButton;
        private Button CoursesButton;
        private Button CityButton;
    }
}
