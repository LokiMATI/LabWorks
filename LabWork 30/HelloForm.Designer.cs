namespace LabWork_30
{
    partial class HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            HelloButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.BackgroundImage = (Image)resources.GetObject("HelloButton.BackgroundImage");
            HelloButton.BackgroundImageLayout = ImageLayout.Zoom;
            HelloButton.Location = new Point(12, 12);
            HelloButton.Name = "HelloButton";
            HelloButton.Size = new Size(94, 29);
            HelloButton.TabIndex = 0;
            HelloButton.Text = "Привет";
            HelloButton.UseVisualStyleBackColor = true;
            HelloButton.Click += HelloButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(109, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Закрыть";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // HelloForm
            // 
            AcceptButton = HelloButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseButton;
            ClientSize = new Size(215, 47);
            Controls.Add(CloseButton);
            Controls.Add(HelloButton);
            MaximumSize = new Size(233, 94);
            MinimumSize = new Size(233, 94);
            Name = "HelloForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приветствие";
            ResumeLayout(false);
        }

        #endregion

        private Button HelloButton;
        private Button CloseButton;
    }
}