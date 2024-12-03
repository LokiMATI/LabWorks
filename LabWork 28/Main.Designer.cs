namespace LabWork_28
{
    partial class Main
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
            DataButton = new Button();
            ProductButton = new Button();
            StoreButton = new Button();
            SuspendLayout();
            // 
            // DataButton
            // 
            DataButton.Location = new Point(93, 64);
            DataButton.Name = "DataButton";
            DataButton.Size = new Size(191, 29);
            DataButton.TabIndex = 0;
            DataButton.Text = "Таблица умножения";
            DataButton.UseVisualStyleBackColor = true;
            DataButton.Click += DataButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(93, 118);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(191, 29);
            ProductButton.TabIndex = 1;
            ProductButton.Text = "Товары";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // StoreButton
            // 
            StoreButton.Location = new Point(93, 168);
            StoreButton.Name = "StoreButton";
            StoreButton.Size = new Size(191, 29);
            StoreButton.TabIndex = 2;
            StoreButton.Text = "Магазин";
            StoreButton.UseVisualStyleBackColor = true;
            StoreButton.Click += StoreButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(StoreButton);
            Controls.Add(ProductButton);
            Controls.Add(DataButton);
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 400);
            Name = "Main";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button DataButton;
        private Button ProductButton;
        private Button StoreButton;
    }
}
