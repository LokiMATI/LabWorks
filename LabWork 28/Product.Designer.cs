namespace LabWork_28
{
    partial class Product
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
            ProductDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductDataGridView.BackgroundColor = Color.White;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.Size = new Size(800, 450);
            ProductDataGridView.TabIndex = 0;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductDataGridView);
            Name = "Product";
            Text = "Товар";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductDataGridView;
    }
}