namespace LabWork_26
{
    partial class Menu
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
            MallingButton = new Button();
            ConverterButton = new Button();
            TicketButton = new Button();
            SuspendLayout();
            // 
            // MallingButton
            // 
            MallingButton.Location = new Point(85, 62);
            MallingButton.Name = "MallingButton";
            MallingButton.Size = new Size(103, 29);
            MallingButton.TabIndex = 0;
            MallingButton.Text = "Рассылка";
            MallingButton.UseVisualStyleBackColor = true;
            MallingButton.Click += MallingButton_Click;
            // 
            // ConverterButton
            // 
            ConverterButton.Location = new Point(85, 119);
            ConverterButton.Name = "ConverterButton";
            ConverterButton.Size = new Size(103, 29);
            ConverterButton.TabIndex = 1;
            ConverterButton.Text = "Переводчик";
            ConverterButton.UseVisualStyleBackColor = true;
            ConverterButton.Click += ConverterButton_Click;
            // 
            // TicketButton
            // 
            TicketButton.Location = new Point(85, 171);
            TicketButton.Name = "TicketButton";
            TicketButton.Size = new Size(103, 29);
            TicketButton.TabIndex = 2;
            TicketButton.Text = "Заказать";
            TicketButton.UseVisualStyleBackColor = true;
            TicketButton.Click += TicketButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(TicketButton);
            Controls.Add(ConverterButton);
            Controls.Add(MallingButton);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button MallingButton;
        private Button ConverterButton;
        private Button TicketButton;
    }
}
