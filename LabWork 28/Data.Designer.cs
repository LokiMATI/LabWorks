namespace LabWork_28
{
    partial class Data
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
            DataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView.BackgroundColor = Color.White;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 12);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(402, 246);
            DataGridView.TabIndex = 0;
            DataGridView.CellClick += DataGridView_CellClick;
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(DataGridView);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "Data";
            Text = "Таблица умножения";
            Load += Data_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
    }
}