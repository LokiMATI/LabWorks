namespace LabWork_26
{
    partial class Mailing
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
            LoginTextBox = new TextBox();
            EmailTextBox = new TextBox();
            LoginLabel = new Label();
            EmaliLabel = new Label();
            ConfirmCheckBox = new CheckBox();
            SubscribeButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(22, 51);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(180, 27);
            LoginTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(22, 123);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(180, 27);
            EmailTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(22, 28);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(52, 20);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Логин";
            // 
            // EmaliLabel
            // 
            EmaliLabel.AutoSize = true;
            EmaliLabel.Location = new Point(22, 100);
            EmaliLabel.Name = "EmaliLabel";
            EmaliLabel.Size = new Size(46, 20);
            EmaliLabel.TabIndex = 3;
            EmaliLabel.Text = "Email";
            // 
            // ConfirmCheckBox
            // 
            ConfirmCheckBox.AutoSize = true;
            ConfirmCheckBox.Location = new Point(22, 185);
            ConfirmCheckBox.Name = "ConfirmCheckBox";
            ConfirmCheckBox.Size = new Size(276, 24);
            ConfirmCheckBox.TabIndex = 4;
            ConfirmCheckBox.Text = "Я согласен на получение рассылки";
            ConfirmCheckBox.UseVisualStyleBackColor = true;
            ConfirmCheckBox.CheckedChanged += ConfirmCheckBox_CheckedChanged;
            // 
            // SubscribeButton
            // 
            SubscribeButton.Enabled = false;
            SubscribeButton.Location = new Point(22, 240);
            SubscribeButton.Name = "SubscribeButton";
            SubscribeButton.Size = new Size(115, 29);
            SubscribeButton.TabIndex = 5;
            SubscribeButton.Text = "Подписаться";
            SubscribeButton.UseVisualStyleBackColor = true;
            SubscribeButton.Click += SubscribeButton_Click;
            // 
            // Mailing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 303);
            Controls.Add(SubscribeButton);
            Controls.Add(ConfirmCheckBox);
            Controls.Add(EmaliLabel);
            Controls.Add(LoginLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(LoginTextBox);
            MaximumSize = new Size(350, 350);
            MinimumSize = new Size(350, 350);
            Name = "Mailing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рассылка";
            Load += Mailing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private Label LoginLabel;
        private Label EmaliLabel;
        private CheckBox ConfirmCheckBox;
        private Button SubscribeButton;
    }
}