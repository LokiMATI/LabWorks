using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_28
{
    public partial class Product : Form
    {
        private List<ProductClass> _products = new List<ProductClass> { };
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            _products.Add(new ProductClass ( "Электроника", "Ноутбук", "1000"));
            _products.Add(new ProductClass("Электроника", "Телевизор", "1000"));
            _products.Add(new ProductClass("Мебель", "Стол", "1000"));
            _products.Add(new ProductClass("Мебель", "Шкаф", "1000"));
            _products.Add(new ProductClass("Топливо", "Бензин", "1000"));
            ProductDataGridView.DataSource = _products;
            ProductDataGridView.Columns[0].HeaderText = "Тип";
            ProductDataGridView.Columns[1].HeaderText = "Наименование";
            ProductDataGridView.Columns[2].HeaderText = "Цена";
        }
    }
}
