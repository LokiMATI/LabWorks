using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_34
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
        }

        private void LoadMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                int lineCount = 0;
                using (StreamReader sr = new StreamReader(OpenFileDialog.FileName))
                {
                    string line;
                    int wight = 20;
                    int height = 20;
                    while ((line = sr.ReadLine()) != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] != ' ')
                            {
                                Panel panel = new Panel();
                                panel.Location = new Point(i * wight, lineCount * height);
                                panel.Size = new Size(wight, height);
                                panel.BackColor = Color.Green;
                                FonPanel.Controls.Add(panel);
                                
                            }
                        }
                        lineCount++;
                    }
                }
            }
        }
    }
}
