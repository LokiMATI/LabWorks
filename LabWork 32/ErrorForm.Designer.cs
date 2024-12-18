namespace LabWork_32
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            ATextBox = new TextBox();
            BTextBox = new TextBox();
            XTextBox = new TextBox();
            labelA = new Label();
            ZTextBox = new TextBox();
            labelB = new Label();
            labelX = new Label();
            labelZ = new Label();
            Formula = new PictureBox();
            Answer = new Label();
            AnswerY = new Label();
            AnswerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Formula).BeginInit();
            SuspendLayout();
            // 
            // ATextBox
            // 
            ATextBox.Location = new Point(57, 13);
            ATextBox.Margin = new Padding(3, 4, 3, 4);
            ATextBox.Name = "ATextBox";
            ATextBox.Size = new Size(75, 30);
            ATextBox.TabIndex = 0;
            // 
            // BTextBox
            // 
            BTextBox.Location = new Point(57, 51);
            BTextBox.Margin = new Padding(3, 4, 3, 4);
            BTextBox.Name = "BTextBox";
            BTextBox.Size = new Size(75, 30);
            BTextBox.TabIndex = 1;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(57, 89);
            XTextBox.Margin = new Padding(3, 4, 3, 4);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(75, 30);
            XTextBox.TabIndex = 2;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(23, 16);
            labelA.Name = "labelA";
            labelA.Size = new Size(33, 23);
            labelA.TabIndex = 3;
            labelA.Text = "A =";
            // 
            // ZTextBox
            // 
            ZTextBox.Location = new Point(57, 127);
            ZTextBox.Margin = new Padding(3, 4, 3, 4);
            ZTextBox.Name = "ZTextBox";
            ZTextBox.Size = new Size(75, 30);
            ZTextBox.TabIndex = 4;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(23, 54);
            labelB.Name = "labelB";
            labelB.Size = new Size(33, 23);
            labelB.TabIndex = 5;
            labelB.Text = "B =";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(23, 92);
            labelX.Name = "labelX";
            labelX.Size = new Size(33, 23);
            labelX.TabIndex = 6;
            labelX.Text = "X =";
            // 
            // labelZ
            // 
            labelZ.AutoSize = true;
            labelZ.Location = new Point(23, 130);
            labelZ.Name = "labelZ";
            labelZ.Size = new Size(33, 23);
            labelZ.TabIndex = 7;
            labelZ.Text = "Z =";
            // 
            // Formula
            // 
            Formula.ErrorImage = (Image)resources.GetObject("Formula.ErrorImage");
            Formula.Image = (Image)resources.GetObject("Formula.Image");
            Formula.Location = new Point(193, 34);
            Formula.Name = "Formula";
            Formula.Size = new Size(159, 47);
            Formula.TabIndex = 8;
            Formula.TabStop = false;
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Location = new Point(193, 108);
            Answer.Name = "Answer";
            Answer.Size = new Size(71, 23);
            Answer.TabIndex = 9;
            Answer.Text = "Ответ: ";
            // 
            // AnswerY
            // 
            AnswerY.AutoSize = true;
            AnswerY.Location = new Point(193, 130);
            AnswerY.Name = "AnswerY";
            AnswerY.Size = new Size(62, 23);
            AnswerY.TabIndex = 10;
            AnswerY.Text = "Ответ";
            // 
            // AnswerButton
            // 
            AnswerButton.Location = new Point(38, 178);
            AnswerButton.Name = "AnswerButton";
            AnswerButton.Size = new Size(94, 29);
            AnswerButton.TabIndex = 11;
            AnswerButton.Text = "Ответ";
            AnswerButton.UseVisualStyleBackColor = true;
            AnswerButton.Click += AnswerButton_Click;
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(AnswerButton);
            Controls.Add(AnswerY);
            Controls.Add(Answer);
            Controls.Add(Formula);
            Controls.Add(labelZ);
            Controls.Add(labelX);
            Controls.Add(labelB);
            Controls.Add(ZTextBox);
            Controls.Add(labelA);
            Controls.Add(XTextBox);
            Controls.Add(BTextBox);
            Controls.Add(ATextBox);
            Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "ErrorForm";
            Text = "Ошибка";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Formula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ATextBox;
        private TextBox BTextBox;
        private TextBox XTextBox;
        private Label labelA;
        private TextBox ZTextBox;
        private Label labelB;
        private Label labelX;
        private Label labelZ;
        private PictureBox Formula;
        private Label Answer;
        private Label AnswerY;
        private Button AnswerButton;
    }
}
