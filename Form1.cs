namespace Factorial_Calculator
{
    public partial class Form1 : Form
    {
        public string nValuePlaceholderText = "Enter value for n";
        public string answerValuePlaceholderText = "n!";
        public Form1()
        {
            InitializeComponent();
        }

        public bool validate()
        {
            if (nValue.Text.Length <= 0)
            {
                return false;
            }
            if (nValue.Text == nValuePlaceholderText)
            {
                return false;
            }
            try
            {
                int n = Convert.ToInt32(nValue.Text);
                if (n <= 0)
                {
                    throw new Exception("Invalid number input !");
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public int factorial(int n)
        {
            // n! = n * n-1!
            if (n == 1 || n == 2)
            {
                return n;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public void resetComponents()
        {
            nValue.Text = nValuePlaceholderText;
            answerValue.Text = answerValuePlaceholderText;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int n = Convert.ToInt32(nValue.Text);

                int n_fact = factorial(n);

                answerValue.Text = Convert.ToString(n_fact);
            }
            else
            {
                nValue.Text = "Enter a whole number !";
                answerValue.Text = answerValuePlaceholderText;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetComponents();
        }
    }
}