using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_27
{
    public partial class ListBoxs : Form
    {
        public ListBoxs()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NewCityTextBox.Text)) OurListBox.Items.Add(NewCityTextBox.Text);
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            if (OurListBox.SelectedItems.Count > 0)
            {
                var items = OurListBox.SelectedItems.Cast<string>().ToList();
                foreach (var item in items)
                {
                    OurListBox.Items.Remove(item);
                    TheirListBox.Items.Add(item);
                }
            }
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OurListBox.Items.Count; i++)
                TheirListBox.Items.Add(OurListBox.Items[i].ToString());
            OurListBox.Items.Clear();
        }
    }
}
