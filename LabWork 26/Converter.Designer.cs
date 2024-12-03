namespace LabWork_26
{
    partial class Converter
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
            InputLabel = new Label();
            InputTextBox = new TextBox();
            InchRadioButton = new RadioButton();
            KilometersRadioButton = new RadioButton();
            CentimetersRadioButton = new RadioButton();
            FeetRadioButton = new RadioButton();
            ConversionButton = new Button();
            OutputLable = new Label();
            SuspendLayout();
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Location = new Point(12, 36);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(153, 20);
            InputLabel.TabIndex = 0;
            InputLabel.Text = "Расстояние в метрах";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 59);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 27);
            InputTextBox.TabIndex = 1;
            // 
            // InchRadioButton
            // 
            InchRadioButton.AutoSize = true;
            InchRadioButton.Location = new Point(12, 92);
            InchRadioButton.Name = "InchRadioButton";
            InchRadioButton.Size = new Size(83, 24);
            InchRadioButton.TabIndex = 2;
            InchRadioButton.TabStop = true;
            InchRadioButton.Text = "Дюймы";
            InchRadioButton.UseVisualStyleBackColor = true;
            // 
            // KilometersRadioButton
            // 
            KilometersRadioButton.AutoSize = true;
            KilometersRadioButton.Checked = true;
            KilometersRadioButton.Location = new Point(12, 122);
            KilometersRadioButton.Name = "KilometersRadioButton";
            KilometersRadioButton.Size = new Size(110, 24);
            KilometersRadioButton.TabIndex = 3;
            KilometersRadioButton.TabStop = true;
            KilometersRadioButton.Text = "Километры";
            KilometersRadioButton.UseVisualStyleBackColor = true;
            // 
            // CentimetersRadioButton
            // 
            CentimetersRadioButton.AutoSize = true;
            CentimetersRadioButton.Location = new Point(12, 152);
            CentimetersRadioButton.Name = "CentimetersRadioButton";
            CentimetersRadioButton.Size = new Size(116, 24);
            CentimetersRadioButton.TabIndex = 4;
            CentimetersRadioButton.TabStop = true;
            CentimetersRadioButton.Text = "Сантиметры";
            CentimetersRadioButton.UseVisualStyleBackColor = true;
            // 
            // FeetRadioButton
            // 
            FeetRadioButton.AutoSize = true;
            FeetRadioButton.Location = new Point(12, 182);
            FeetRadioButton.Name = "FeetRadioButton";
            FeetRadioButton.Size = new Size(65, 24);
            FeetRadioButton.TabIndex = 5;
            FeetRadioButton.TabStop = true;
            FeetRadioButton.Text = "Футы";
            FeetRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConversionButton
            // 
            ConversionButton.Location = new Point(12, 212);
            ConversionButton.Name = "ConversionButton";
            ConversionButton.Size = new Size(94, 29);
            ConversionButton.TabIndex = 6;
            ConversionButton.Text = "Перевести";
            ConversionButton.UseVisualStyleBackColor = true;
            ConversionButton.Click += ConversionButton_Click;
            // 
            // OutputLable
            // 
            OutputLable.AutoSize = true;
            OutputLable.Location = new Point(12, 270);
            OutputLable.Name = "OutputLable";
            OutputLable.Size = new Size(0, 20);
            OutputLable.TabIndex = 7;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(OutputLable);
            Controls.Add(ConversionButton);
            Controls.Add(FeetRadioButton);
            Controls.Add(CentimetersRadioButton);
            Controls.Add(KilometersRadioButton);
            Controls.Add(InchRadioButton);
            Controls.Add(InputTextBox);
            Controls.Add(InputLabel);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "Converter";
            Text = "Конвертор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputLabel;
        private TextBox InputTextBox;
        private RadioButton InchRadioButton;
        private RadioButton KilometersRadioButton;
        private RadioButton CentimetersRadioButton;
        private RadioButton FeetRadioButton;
        private Button ConversionButton;
        private Label OutputLable;
    }
}