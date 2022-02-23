using System.Numerics;

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

            BigInteger n;
            BigInteger factorial = 1;

            try
            {
                n = BigInteger.Parse(nbrArea.Text);
                Console.WriteLine(n);
            }
            catch (FormatException)
            {

                MessageBox.Show(String.Format("Unable to convert the string '{0}' to a BigInteger value.",
                                  nbrArea.Text), "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

        private void nbrArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}