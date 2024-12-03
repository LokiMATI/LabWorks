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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (CoursesCheckedListBox.CheckedItems.Count > 0)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Вы выбрали следующие курсы:");
                foreach (var course in CoursesCheckedListBox.CheckedItems)
                {
                    message.AppendLine($"- {course.ToString()};");
                }
                MessageBox.Show(message.ToString(), "Вы записаны на курсы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                message.Clear();
            }
            else MessageBox.Show("ВЫ ОБЯЗАНЫ ЗАПИСАТЬСЯ НА КУРСЫ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
