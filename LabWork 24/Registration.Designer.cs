namespace LabWork_24
{
    partial class Registration
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
            LoginTextBox = new TextBox();
            InformationTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PasswordConfirmTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLable = new Label();
            PasswordLable = new Label();
            PasswordConfirmationLable = new Label();
            CountryLable = new Label();
            InformationLable = new Label();
            RegistrationButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(65, 43);
            LoginTextBox.MaximumSize = new Size(150, 30);
            LoginTextBox.MaxLength = 32;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(150, 27);
            LoginTextBox.TabIndex = 0;
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // InformationTextBox
            // 
            InformationTextBox.Location = new Point(65, 255);
            InformationTextBox.MaximumSize = new Size(296, 84);
            InformationTextBox.MaxLength = 10000;
            InformationTextBox.Multiline = true;
            InformationTextBox.Name = "InformationTextBox";
            InformationTextBox.Size = new Size(296, 84);
            InformationTextBox.TabIndex = 3;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(65, 202);
            CountryTextBox.MaximumSize = new Size(150, 30);
            CountryTextBox.MaxLength = 6;
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(150, 27);
            CountryTextBox.TabIndex = 4;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            CountryTextBox.KeyPress += CountryTextBox_KeyPress;
            // 
            // PasswordConfirmTextBox
            // 
            PasswordConfirmTextBox.Location = new Point(65, 149);
            PasswordConfirmTextBox.MaximumSize = new Size(150, 30);
            PasswordConfirmTextBox.MaxLength = 10;
            PasswordConfirmTextBox.Name = "PasswordConfirmTextBox";
            PasswordConfirmTextBox.Size = new Size(150, 27);
            PasswordConfirmTextBox.TabIndex = 5;
            PasswordConfirmTextBox.UseSystemPasswordChar = true;
            PasswordConfirmTextBox.TextChanged += PasswordConfirmTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(65, 96);
            PasswordTextBox.MaximumSize = new Size(150, 30);
            PasswordTextBox.MaxLength = 10;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(150, 27);
            PasswordTextBox.TabIndex = 6;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLable
            // 
            LoginLable.AutoSize = true;
            LoginLable.Location = new Point(65, 20);
            LoginLable.Name = "LoginLable";
            LoginLable.Size = new Size(52, 20);
            LoginLable.TabIndex = 7;
            LoginLable.Text = "Логин";
            // 
            // PasswordLable
            // 
            PasswordLable.AutoSize = true;
            PasswordLable.Location = new Point(65, 73);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(62, 20);
            PasswordLable.TabIndex = 8;
            PasswordLable.Text = "Пароль";
            // 
            // PasswordConfirmationLable
            // 
            PasswordConfirmationLable.AutoSize = true;
            PasswordConfirmationLable.Location = new Point(65, 126);
            PasswordConfirmationLable.Name = "PasswordConfirmationLable";
            PasswordConfirmationLable.Size = new Size(176, 20);
            PasswordConfirmationLable.TabIndex = 9;
            PasswordConfirmationLable.Text = "Подтверждение пароля";
            // 
            // CountryLable
            // 
            CountryLable.AutoSize = true;
            CountryLable.Location = new Point(65, 179);
            CountryLable.Name = "CountryLable";
            CountryLable.Size = new Size(58, 20);
            CountryLable.TabIndex = 10;
            CountryLable.Text = "Страна";
            // 
            // InformationLable
            // 
            InformationLable.AutoSize = true;
            InformationLable.Location = new Point(65, 232);
            InformationLable.Name = "InformationLable";
            InformationLable.Size = new Size(151, 20);
            InformationLable.TabIndex = 11;
            InformationLable.Text = "Информация о себе";
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(65, 373);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(176, 29);
            RegistrationButton.TabIndex = 12;
            RegistrationButton.Text = "Зарегистрироваться";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(267, 373);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "Отмена";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseClick;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(RegistrationButton);
            Controls.Add(InformationLable);
            Controls.Add(CountryLable);
            Controls.Add(PasswordConfirmationLable);
            Controls.Add(PasswordLable);
            Controls.Add(LoginLable);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordConfirmTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(InformationTextBox);
            Controls.Add(LoginTextBox);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox InformationTextBox;
        private TextBox CountryTextBox;
        private TextBox PasswordConfirmTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLable;
        private Label PasswordLable;
        private Label PasswordConfirmationLable;
        private Label CountryLable;
        private Label InformationLable;
        private Button RegistrationButton;
        private Button CloseButton;
    }
}
