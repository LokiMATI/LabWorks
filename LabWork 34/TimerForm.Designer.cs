namespace LabWork_34
{
    partial class TimerForm
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
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            PauseButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            TimerLabel = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(88, 41);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "Страт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // PauseButton
            // 
            PauseButton.Location = new Point(88, 96);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(94, 29);
            PauseButton.TabIndex = 1;
            PauseButton.Text = "Пауза";
            PauseButton.UseVisualStyleBackColor = true;
            PauseButton.Click += PauseButton_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Location = new Point(88, 157);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(42, 20);
            TimerLabel.TabIndex = 2;
            TimerLabel.Text = "Time";
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(TimerLabel);
            Controls.Add(PauseButton);
            Controls.Add(StartButton);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "TimerForm";
            Text = "Таймер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button PauseButton;
        private System.Windows.Forms.Timer Timer;
        private Label TimerLabel;
    }
}