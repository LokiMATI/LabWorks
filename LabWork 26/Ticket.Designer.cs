namespace LabWork_26
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
            FromLabel = new Label();
            ToLable = new Label();
            FromTimeLabel = new Label();
            ToTimeLabel = new Label();
            FromTextBox = new TextBox();
            ToTextBox = new TextBox();
            FromDateTimePicker = new DateTimePicker();
            ToDateTimePicker = new DateTimePicker();
            BuyButton = new Button();
            ToCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(12, 9);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(56, 20);
            FromLabel.TabIndex = 0;
            FromLabel.Text = "Откуда";
            // 
            // ToLable
            // 
            ToLable.AutoSize = true;
            ToLable.Location = new Point(12, 68);
            ToLable.Name = "ToLable";
            ToLable.Size = new Size(41, 20);
            ToLable.TabIndex = 1;
            ToLable.Text = "Куда";
            // 
            // FromTimeLabel
            // 
            FromTimeLabel.AutoSize = true;
            FromTimeLabel.Location = new Point(143, 9);
            FromTimeLabel.Name = "FromTimeLabel";
            FromTimeLabel.Size = new Size(40, 20);
            FromTimeLabel.TabIndex = 2;
            FromTimeLabel.Text = "Туда";
            // 
            // ToTimeLabel
            // 
            ToTimeLabel.AutoSize = true;
            ToTimeLabel.Location = new Point(167, 68);
            ToTimeLabel.Name = "ToTimeLabel";
            ToTimeLabel.Size = new Size(70, 20);
            ToTimeLabel.TabIndex = 3;
            ToTimeLabel.Text = "Обратно";
            // 
            // FromTextBox
            // 
            FromTextBox.Location = new Point(12, 31);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.Size = new Size(125, 27);
            FromTextBox.TabIndex = 4;
            // 
            // ToTextBox
            // 
            ToTextBox.Location = new Point(12, 91);
            ToTextBox.Name = "ToTextBox";
            ToTextBox.Size = new Size(125, 27);
            ToTextBox.TabIndex = 5;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Location = new Point(143, 31);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(166, 27);
            FromDateTimePicker.TabIndex = 6;
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Location = new Point(143, 91);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(166, 27);
            ToDateTimePicker.TabIndex = 7;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(12, 166);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(94, 29);
            BuyButton.TabIndex = 8;
            BuyButton.Text = "Заказать";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // ToCheckBox
            // 
            ToCheckBox.AutoSize = true;
            ToCheckBox.Location = new Point(143, 71);
            ToCheckBox.Name = "ToCheckBox";
            ToCheckBox.Size = new Size(18, 17);
            ToCheckBox.TabIndex = 9;
            ToCheckBox.UseVisualStyleBackColor = true;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(ToCheckBox);
            Controls.Add(BuyButton);
            Controls.Add(ToDateTimePicker);
            Controls.Add(FromDateTimePicker);
            Controls.Add(ToTextBox);
            Controls.Add(FromTextBox);
            Controls.Add(ToTimeLabel);
            Controls.Add(FromTimeLabel);
            Controls.Add(ToLable);
            Controls.Add(FromLabel);
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "Ticket";
            Text = "Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FromLabel;
        private Label ToLable;
        private Label FromTimeLabel;
        private Label ToTimeLabel;
        private TextBox FromTextBox;
        private TextBox ToTextBox;
        private DateTimePicker FromDateTimePicker;
        private DateTimePicker ToDateTimePicker;
        private Button BuyButton;
        private CheckBox ToCheckBox;
    }
}