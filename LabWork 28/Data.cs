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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            DataGridView.ColumnCount = 8;
            DataGridView.RowCount = 8;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
            {
                DataGridView.Columns[i].HeaderText = (i + 2).ToString();
                DataGridView.Rows[i].HeaderCell.Value = (i + 2).ToString();
            }
            for (int i = 0; i < DataGridView.RowCount; i++)
            {
                for (int j = 0; j < DataGridView.ColumnCount; j++)
                {
                    DataGridView.Rows[i].Cells[j].Value = ((j + 2) * (i + 2)).ToString();
                }
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{e.ColumnIndex + 2}x{e.RowIndex + 2} = {(e.ColumnIndex + 2) * (e.RowIndex + 2)}");
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
