namespace LabWork_25
{
    partial class LabWork
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
            BirthDateTimePicker = new DateTimePicker();
            BirthDayLabel = new Label();
            AgeLabel = new Label();
            TemperatureTrackBar = new TrackBar();
            TemperatureTextBox = new TextBox();
            TemperatureLabel = new Label();
            RadiusLabel = new Label();
            RadiusNumericUpDown = new NumericUpDown();
            SquareSphereLabel = new Label();
            ResultSquareSphereLabel = new Label();
            VolumeSphereLabel = new Label();
            ResultVolumeSphereLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)TemperatureTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadiusNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(12, 32);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(183, 27);
            BirthDateTimePicker.TabIndex = 0;
            BirthDateTimePicker.ValueChanged += BirthDateTimePicker_ValueChanged;
            // 
            // BirthDayLabel
            // 
            BirthDayLabel.AutoSize = true;
            BirthDayLabel.Location = new Point(12, 9);
            BirthDayLabel.Name = "BirthDayLabel";
            BirthDayLabel.Size = new Size(119, 20);
            BirthDayLabel.TabIndex = 1;
            BirthDayLabel.Text = "День рождения";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(217, 35);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(0, 20);
            AgeLabel.TabIndex = 2;
            // 
            // TemperatureTrackBar
            // 
            TemperatureTrackBar.Location = new Point(12, 116);
            TemperatureTrackBar.Maximum = 50;
            TemperatureTrackBar.Minimum = 10;
            TemperatureTrackBar.Name = "TemperatureTrackBar";
            TemperatureTrackBar.Size = new Size(343, 56);
            TemperatureTrackBar.TabIndex = 3;
            TemperatureTrackBar.Value = 10;
            TemperatureTrackBar.ValueChanged += TemperatureTrackBar_ValueChanged;
            // 
            // TemperatureTextBox
            // 
            TemperatureTextBox.Location = new Point(361, 116);
            TemperatureTextBox.Name = "TemperatureTextBox";
            TemperatureTextBox.Size = new Size(26, 27);
            TemperatureTextBox.TabIndex = 4;
            TemperatureTextBox.Text = "10";
            TemperatureTextBox.TextChanged += TemperatureTextBox_TextChanged;
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Location = new Point(12, 93);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(200, 20);
            TemperatureLabel.TabIndex = 5;
            TemperatureLabel.Text = "Температура в помещении";
            // 
            // RadiusLabel
            // 
            RadiusLabel.AutoSize = true;
            RadiusLabel.Location = new Point(12, 201);
            RadiusLabel.Name = "RadiusLabel";
            RadiusLabel.Size = new Size(105, 20);
            RadiusLabel.TabIndex = 7;
            RadiusLabel.Text = "Радиус сферы";
            // 
            // RadiusNumericUpDown
            // 
            RadiusNumericUpDown.DecimalPlaces = 2;
            RadiusNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            RadiusNumericUpDown.Location = new Point(12, 224);
            RadiusNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            RadiusNumericUpDown.Size = new Size(150, 27);
            RadiusNumericUpDown.TabIndex = 8;
            RadiusNumericUpDown.ValueChanged += RadiusNumericUpDown_ValueChanged;
            // 
            // SquareSphereLabel
            // 
            SquareSphereLabel.AutoSize = true;
            SquareSphereLabel.Location = new Point(171, 201);
            SquareSphereLabel.Name = "SquareSphereLabel";
            SquareSphereLabel.Size = new Size(216, 20);
            SquareSphereLabel.TabIndex = 9;
            SquareSphereLabel.Text = "Площадь поверхности сферы";
            // 
            // ResultSquareSphereLabel
            // 
            ResultSquareSphereLabel.AutoSize = true;
            ResultSquareSphereLabel.FlatStyle = FlatStyle.Flat;
            ResultSquareSphereLabel.Location = new Point(171, 224);
            ResultSquareSphereLabel.Name = "ResultSquareSphereLabel";
            ResultSquareSphereLabel.Size = new Size(0, 20);
            ResultSquareSphereLabel.TabIndex = 10;
            // 
            // VolumeSphereLabel
            // 
            VolumeSphereLabel.AutoSize = true;
            VolumeSphereLabel.Location = new Point(426, 201);
            VolumeSphereLabel.Name = "VolumeSphereLabel";
            VolumeSphereLabel.Size = new Size(106, 20);
            VolumeSphereLabel.TabIndex = 11;
            VolumeSphereLabel.Text = "Объем сферы";
            // 
            // ResultVolumeSphereLabel
            // 
            ResultVolumeSphereLabel.AutoSize = true;
            ResultVolumeSphereLabel.Location = new Point(426, 231);
            ResultVolumeSphereLabel.Name = "ResultVolumeSphereLabel";
            ResultVolumeSphereLabel.Size = new Size(0, 20);
            ResultVolumeSphereLabel.TabIndex = 12;
            // 
            // LabWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultVolumeSphereLabel);
            Controls.Add(VolumeSphereLabel);
            Controls.Add(ResultSquareSphereLabel);
            Controls.Add(SquareSphereLabel);
            Controls.Add(RadiusNumericUpDown);
            Controls.Add(RadiusLabel);
            Controls.Add(TemperatureLabel);
            Controls.Add(TemperatureTextBox);
            Controls.Add(TemperatureTrackBar);
            Controls.Add(AgeLabel);
            Controls.Add(BirthDayLabel);
            Controls.Add(BirthDateTimePicker);
            Name = "LabWork";
            Text = "Лабораторная работа";
            ((System.ComponentModel.ISupportInitialize)TemperatureTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadiusNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker BirthDateTimePicker;
        private Label BirthDayLabel;
        private Label AgeLabel;
        private TrackBar TemperatureTrackBar;
        private TextBox TemperatureTextBox;
        private Label TemperatureLabel;
        private Label RadiusLabel;
        private NumericUpDown RadiusNumericUpDown;
        private Label SquareSphereLabel;
        private Label ResultSquareSphereLabel;
        private Label VolumeSphereLabel;
        private Label ResultVolumeSphereLabel;
    }
}
