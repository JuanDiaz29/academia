namespace Juan_Diaz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

                       //Gets the base and exponent values as integers
            Console.Write("Please enter the base number : ");
            int base_int = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter the exponent integer : ");
            int exp_int = int.Parse(Console.ReadLine());

            int result;
            
            //The result will be run through a loop for all [0,exp]
            Console.Write("\nThe sum of all numbers from the range of [" + base_int + "^" + "0, " + base_int + "^" + exp_int + "] = ");
            int sum = 0;
            for(int i = 0; i <= exp_int; i++)
            {
                //Call the integerPower function to calculate base ^ n - 1
                result = integerPower(base_int, i);
                sum += result;
                //Write out the result in a line until it reaches the last exponent
                if (i != exp_int)
                    Console.Write(result + " + ");
                else
                    Console.Write(result);

            }

            //Display the sum of all numbers
            Console.WriteLine(" = " + sum);

            Console.Read();

            

        }

        static int integerPower(int base_num, int exponent)
        {
            int calc = 1;

            for (int i = 0; i < exponent; i++)
            {
                calc *= base_num;
            }

            return calc;
        }
    
    } 
}
