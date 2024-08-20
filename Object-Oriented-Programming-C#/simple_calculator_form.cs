namespace Juan_Diaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void takehomebtn_Click(object sender, EventArgs e)
        {
            federaltaxtxt.Clear();
            retirementtxt.Clear();
            socialtxt.Clear();
            netpaytxt.Clear();

            const double federal_tax = 0.18;
            const double retirement_tax = 0.15;
            const double social_tax = 0.09;

            string test = weeklysalestxt.Text;

            if (Input(test) == false)
            {
                weeklysalestxt.Clear();
            }

            else
            {
                double weekly_pay_input = Double.Parse(weeklysalestxt.Text);
                double weekly_pay_commission = weekly_pay_input * 0.07;
                double federalcalc = Calc(weekly_pay_commission, federal_tax);
                double retirementcalc = Calc(weekly_pay_commission, retirement_tax);
                double socialcalc = Calc(weekly_pay_commission, social_tax);

                Disp(federalcalc, retirementcalc, socialcalc);
            }
        }

        private bool Input(string input)
        {
            double test;
            bool valid = Double.TryParse(input, out test);

            if (!valid)
            {
                MessageBox.Show("Invalid input for the total weekly sales. \nPlease re-enter.");
                return false;
            }

            else if (test < 0)
            {
                MessageBox.Show("Total weekly sales must be a positive dollar amount. \nPlease re-enter.");
                return false;
            }
            else
                return true;
        }

        private double Calc(double pay, double tax)
        {
            double calculation;
            calculation = Math.Round(pay * tax, 2);
            return calculation;
        }

        private void Disp(double fedtax, double retirementtax, double socialtax)
        {
            double takehomepay = Math.Round(Double.Parse(weeklysalestxt.Text) * 0.07, 2);
            double final_output = Math.Round(takehomepay - fedtax - retirementtax - socialtax, 2);
            federaltaxtxt.Text = fedtax.ToString();
            retirementtxt.Text = retirementtax.ToString();
            socialtxt.Text = socialtax.ToString();
            netpaytxt.Text = final_output.ToString();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            nametxt.Clear();
            weeklysalestxt.Clear();
            federaltaxtxt.Clear();
            retirementtxt.Clear();
            socialtxt.Clear();
            netpaytxt.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


