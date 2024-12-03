namespace LabWork_27
{
    partial class ListBoxs
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
            OurListBox = new ListBox();
            TheirListBox = new ListBox();
            NewCityTextBox = new TextBox();
            AddButton = new Button();
            SelectedButton = new Button();
            AllButton = new Button();
            SuspendLayout();
            // 
            // OurListBox
            // 
            OurListBox.FormattingEnabled = true;
            OurListBox.Items.AddRange(new object[] { "Архангельск", "Северодвинск", "Мурманск", "Санкт-Петербург", "Петрозаводск" });
            OurListBox.Location = new Point(12, 12);
            OurListBox.Name = "OurListBox";
            OurListBox.SelectionMode = SelectionMode.MultiSimple;
            OurListBox.Size = new Size(206, 224);
            OurListBox.TabIndex = 0;
            // 
            // TheirListBox
            // 
            TheirListBox.FormattingEnabled = true;
            TheirListBox.Items.AddRange(new object[] { "Москва", "Крым", "Нижний Новгород", "Волгоград", "Краснодар" });
            TheirListBox.Location = new Point(364, 12);
            TheirListBox.Name = "TheirListBox";
            TheirListBox.Size = new Size(206, 224);
            TheirListBox.TabIndex = 1;
            // 
            // NewCityTextBox
            // 
            NewCityTextBox.Location = new Point(12, 269);
            NewCityTextBox.Name = "NewCityTextBox";
            NewCityTextBox.Size = new Size(206, 27);
            NewCityTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(364, 269);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(206, 29);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SelectedButton
            // 
            SelectedButton.Location = new Point(265, 87);
            SelectedButton.Name = "SelectedButton";
            SelectedButton.Size = new Size(54, 29);
            SelectedButton.TabIndex = 4;
            SelectedButton.Text = ">";
            SelectedButton.UseVisualStyleBackColor = true;
            SelectedButton.Click += SelectedButton_Click;
            // 
            // AllButton
            // 
            AllButton.Location = new Point(265, 138);
            AllButton.Name = "AllButton";
            AllButton.Size = new Size(54, 29);
            AllButton.TabIndex = 5;
            AllButton.Text = ">>";
            AllButton.UseVisualStyleBackColor = true;
            AllButton.Click += AllButton_Click;
            // 
            // ListBoxs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(AllButton);
            Controls.Add(SelectedButton);
            Controls.Add(AddButton);
            Controls.Add(NewCityTextBox);
            Controls.Add(TheirListBox);
            Controls.Add(OurListBox);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "ListBoxs";
            Text = "ListBoxs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox OurListBox;
        private ListBox TheirListBox;
        private TextBox NewCityTextBox;
        private Button AddButton;
        private Button SelectedButton;
        private Button AllButton;
    }
}