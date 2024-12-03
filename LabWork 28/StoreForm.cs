using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_28
{
    public partial class StoreForm : Form
    {
        private StringBuilder _shoppingCart = new StringBuilder();
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            StoreDataGridView.Rows.Add(1, "Машина", 1000, false);
            StoreDataGridView.Rows.Add(2, "Самолёт", 2000, false);
            StoreDataGridView.Rows.Add(3, "Танк", 1500, false);
            StoreDataGridView.Rows.Add(4, "Лодка", 10000, false);
            StoreDataGridView.Rows.Add(5, "Дверь", 100000, false);
            StoreDataGridView.Rows.Add(6, "Каска", 1001230, false);
            StoreDataGridView.Rows.Add(7, "Гараж", 10, false);
            StoreDataGridView.Rows.Add(8, "Дом", 20, false);
            StoreDataGridView.Rows.Add(9, "Матрас", 5000, false);
            StoreDataGridView.Rows.Add(10, "Потолок", 10, false);
            StoreDataGridView.RowsDefaultCellStyle.BackColor = Color.Blue;
            StoreDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Coral;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            StringBuilder buy = new StringBuilder();
            decimal sum = 0;
            foreach (DataGridViewRow row in StoreDataGridView.Rows) {
                if (row.Cells[3].Value != null && (bool)row.Cells[3].Value)
                {
                    buy.AppendLine($"{row.Cells[1].Value.ToString()} {row.Cells[2].Value.ToString()}");
                    sum += Decimal.Parse(row.Cells[2].Value.ToString());
                }
            }
            if (buy.Length > 0)
            {
                AllProductLable.Text = buy.ToString();
                PriceLabel.Text = sum.ToString();
                
            }
            else
            {
                AllProductLable.Text = "Необходимо добавить товары в корзину для создания заказа.";
                PriceLabel.Text = "";
            }

            
        }
    }
}
