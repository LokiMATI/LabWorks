namespace LabWork_23
{
    partial class Authorization
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
            PasswordTextBox = new TextBox();
            AuthorizationButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(145, 106);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(125, 25);
            LoginTextBox.TabIndex = 2;
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(145, 137);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 25);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // AuthorizationButton
            // 
            AuthorizationButton.Location = new Point(12, 168);
            AuthorizationButton.Name = "AuthorizationButton";
            AuthorizationButton.Size = new Size(149, 29);
            AuthorizationButton.TabIndex = 4;
            AuthorizationButton.Text = "Авторизоваться";
            AuthorizationButton.UseVisualStyleBackColor = true;
            AuthorizationButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 5;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 203);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AuthorizationButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            MaximumSize = new Size(300, 250);
            MinimumSize = new Size(300, 0);
            Name = "Authorization";
            Text = "Authorization";
            Load += Authorization_Load;
            Controls.SetChildIndex(LoginTextBox, 0);
            Controls.SetChildIndex(PasswordTextBox, 0);
            Controls.SetChildIndex(AuthorizationButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button AuthorizationButton;
        private Label label1;
        private Label label2;
    }
}