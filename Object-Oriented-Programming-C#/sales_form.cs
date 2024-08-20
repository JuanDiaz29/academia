namespace Juan_Diaz
{
	public partial class Form1 : Form
	{
    	public Form1()
    	{
        	InitializeComponent();
    	}
 
    	private void ProfitBtn_Click(object sender, EventArgs e)
    	{
        	double sales;
        	bool valid = Double.TryParse(SalesIn.Text, out sales);
        	if (!valid)
        	{
            	MessageBox.Show("Invalid num1. Re-enter.");
        	}
        	else if (sales > 0 && sales <= 1000)
        	{
            	SalesTxt.Text = "$" + sales.ToString();
            	RatioTxt.Text = "3%";
            	ProfitTxt.Text = "$" + Math.Round((sales * .03), 2).ToString();
        	}
 	       else if (sales > 1000 && sales <= 5000)
        	{
            	SalesTxt.Text = "$" + sales.ToString();
            	RatioTxt.Text = "3.5%";
            	ProfitTxt.Text = "$" + Math.Round((sales * .035), 2).ToString();
        	}
	        else if (sales > 5000 && sales <= 10000)
        	{
            	SalesTxt.Text = "$" + sales.ToString();
            	RatioTxt.Text = "4%";
            	ProfitTxt.Text = "$" + Math.Round((sales * .04), 2).ToString();
        	}
 	       else if (sales > 10000)
        	{
            	SalesTxt.Text = "$" + sales.ToString();
            	RatioTxt.Text = "4.5%";
            	ProfitTxt.Text = "$" + Math.Round((sales * .045), 2).ToString();
        	}
    	}
	}
}


