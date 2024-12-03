namespace LabWork_27
{
    partial class Ticket
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
            FromComboBox = new ComboBox();
            FromLable = new Label();
            ToComboBox = new ComboBox();
            ToLable = new Label();
            BuyButton = new Button();
            SuspendLayout();
            // 
            // FromComboBox
            // 
            FromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FromComboBox.FormattingEnabled = true;
            FromComboBox.Items.AddRange(new object[] { "Архангельск", "Магадан", "Омск", "Государство Москва", "Наш родной Питер", "Северодвинск", "Холмогоры", "Рай", "Ад" });
            FromComboBox.Location = new Point(12, 89);
            FromComboBox.Name = "FromComboBox";
            FromComboBox.Size = new Size(151, 28);
            FromComboBox.TabIndex = 0;
            // 
            // FromLable
            // 
            FromLable.AutoSize = true;
            FromLable.Location = new Point(12, 66);
            FromLable.Name = "FromLable";
            FromLable.Size = new Size(56, 20);
            FromLable.TabIndex = 1;
            FromLable.Text = "Откуда";
            // 
            // ToComboBox
            // 
            ToComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Items.AddRange(new object[] { "Архангельск", "Магадан", "Омск", "Государство Москва", "Наш родной Питер", "Северодвинск", "Холмогоры", "Рай", "Ад" });
            ToComboBox.Location = new Point(12, 162);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(151, 28);
            ToComboBox.TabIndex = 2;
            // 
            // ToLable
            // 
            ToLable.AutoSize = true;
            ToLable.Location = new Point(12, 139);
            ToLable.Name = "ToLable";
            ToLable.Size = new Size(41, 20);
            ToLable.TabIndex = 3;
            ToLable.Text = "Куда";
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(12, 267);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(94, 29);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Заказать";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(BuyButton);
            Controls.Add(ToLable);
            Controls.Add(ToComboBox);
            Controls.Add(FromLable);
            Controls.Add(FromComboBox);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "Ticket";
            Text = "Покупка билетов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FromComboBox;
        private Label FromLable;
        private ComboBox ToComboBox;
        private Label ToLable;
        private Button BuyButton;
    }
}