namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(nbrArea.Text);
            long factorial = 1;

            while (n > 1)
            {
                factorial = factorial * n;
                n--;
            }
            rsltBox.Text = factorial.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}