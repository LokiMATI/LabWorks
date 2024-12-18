using System.Windows.Forms;

namespace LabWork_35
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void ToFirstFormMenuItem_Click(object sender, EventArgs e)
        {
            FirstForm form = new FirstForm();
            foreach (var item in MdiChildren)
            {
                if (item is FirstForm) {
                    item.Activate();
                    return;
                }
                    
            }
            form.MdiParent = this;
            form.Show();
        }

        private void ToSecondFormMenuItem_Click(object sender, EventArgs e)
        {
            SecondForm form = new SecondForm();
            foreach (var item in MdiChildren)
            {
                if (item is SecondForm)
                {
                    item.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void ToThirdFormMenuItem_Click(object sender, EventArgs e)
        {
            ThirdForm form = new ThirdForm();
            foreach (var item in MdiChildren)
            {
                if (item is ThirdForm)
                {
                    item.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void CloseAllMenuItem_Click(Object sender, EventArgs e)
        {
           foreach (Form child in MdiChildren)
            {
                child.Dispose();
                child.Close();
            }
        }
    }
}
