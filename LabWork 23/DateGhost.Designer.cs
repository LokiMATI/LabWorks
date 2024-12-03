namespace LabWork_23
{
    partial class DateGhost
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 424);
            label1.Name = "label1";
            label1.Size = new Size(141, 17);
            label1.TabIndex = 1;
            label1.Text = "08.11.2024 15:45:19";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateGhost
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "DateGhost";
            Text = "DateGhost";
            TransparencyKey = Color.White;
            Load += DateGhost_Load;
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}