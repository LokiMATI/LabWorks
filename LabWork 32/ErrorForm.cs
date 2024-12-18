namespace LabWork_32
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            double x = double.Parse(XTextBox.Text);
            double a = double.Parse(ATextBox.Text);
            double b = double.Parse(BTextBox.Text);
            double z = double.Parse(ZTextBox.Text);

            try
            {
                if (z == 0) throw new DivideByZeroException();
                if (x < -3) throw new ArgumentOutOfRangeException();
                if (a <= 0 || b <= 0 || a == 1) throw new ArgumentOutOfRangeException();
                AnswerY.Text = (Math.Sqrt(x + 3) / z + Math.Log(b, a)).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                AnswerY.Text = "Неверные входные данные";
            }
            catch (DivideByZeroException)
            {
                AnswerY.Text = "Нельзя делить на ноль";
            }
            
        }
    }
}
