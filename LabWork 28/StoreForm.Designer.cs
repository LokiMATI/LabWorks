namespace LabWork_28
{
    partial class StoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            StoreDataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            IsInShoppingCart = new DataGridViewCheckBoxColumn();
            BuyButton = new Button();
            TotalLabel = new Label();
            AllProductLable = new Label();
            PriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)StoreDataGridView).BeginInit();
            SuspendLayout();
            // 
            // StoreDataGridView
            // 
            StoreDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StoreDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StoreDataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Price, IsInShoppingCart });
            StoreDataGridView.Location = new Point(12, 12);
            StoreDataGridView.Name = "StoreDataGridView";
            StoreDataGridView.RowHeadersWidth = 51;
            StoreDataGridView.Size = new Size(430, 268);
            StoreDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "Код";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Название";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Price
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle1;
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // IsInShoppingCart
            // 
            IsInShoppingCart.HeaderText = "В корзине";
            IsInShoppingCart.MinimumWidth = 6;
            IsInShoppingCart.Name = "IsInShoppingCart";
            IsInShoppingCart.Width = 125;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(12, 286);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(94, 29);
            BuyButton.TabIndex = 1;
            BuyButton.Text = "Заказать";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(12, 318);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(50, 20);
            TotalLabel.TabIndex = 2;
            TotalLabel.Text = "Итого";
            // 
            // AllProductLable
            // 
            AllProductLable.AutoSize = true;
            AllProductLable.Location = new Point(460, 12);
            AllProductLable.Name = "AllProductLable";
            AllProductLable.Size = new Size(0, 20);
            AllProductLable.TabIndex = 3;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(68, 318);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(0, 20);
            PriceLabel.TabIndex = 4;
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PriceLabel);
            Controls.Add(AllProductLable);
            Controls.Add(TotalLabel);
            Controls.Add(BuyButton);
            Controls.Add(StoreDataGridView);
            //Name = "StoreForm";
            Text = "Склад";
            Load += StoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)StoreDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StoreDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn IsInShoppingCart;
        private Button BuyButton;
        private Label TotalLabel;
        private Label AllProductLable;
        private Label PriceLabel;
    }
}