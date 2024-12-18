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
    public partial class TheWORLDOfCapibaraForm : Form
    {
        private int imageId = 0;
        public TheWORLDOfCapibaraForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Capibara.BackgroundImage = ImageList.Images[imageId++];
            if (imageId == 7) imageId = 0;
        }
    }
}
