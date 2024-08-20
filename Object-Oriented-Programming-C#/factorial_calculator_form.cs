namespace Juan_Diaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void factorialbtn_Click(object sender, EventArgs e)
        {

            factorial.Items.Clear();
            exponential.Items.Clear();

            int input;
            bool valid = int.TryParse(factorialtxt.Text, out input);
            //For input that is not a number
            if (!valid)
            {
                MessageBox.Show("Invalid input. Re-enter using integers");
            }
            else if(input < 0)
            {
                //Negative number input is invalid
                MessageBox.Show("Please enter a positive integer.");
                factorialtxt.Clear();
            }

            else
            {
                //For the factorial derivation listbox, follow n! = n · (n – 1) · (n – 2) · … · 1
                int n = 1;
                factorial.Items.Add("0! = " + 1);
                exponential.Items.Add("e = 2");
                for (int i = 1; i <= input; i++)
                {
                    n *= i;
                    factorial.Items.Add(i + "! = " + n);
                }

                //Declare exponential
                double exp = 1;
                int x = 1;

                //Performs the factorial calculation again but estimates the value of e instead
                for (int j = 1; j <= input; j++)
                {
                    x *= j;
                    exp += 1.0 / x;
                    exponential.Items.Add("e = " + exp);
                }

            }



        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Added clear button
            factorial.Items.Clear();
            exponential.Items.Clear();
            factorialtxt.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Added exit button
            Close();
        }
    }
}

