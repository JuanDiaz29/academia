namespace Juan_Diaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            //Gets the number of students to initialize the size of the array
            Console.Write("Please enter the number of students: ");
            int num_of_students;
            bool valid1;
            //Check for valid input in order to initialize array
            do
            {
                valid1 = Int32.TryParse(Console.ReadLine(), out num_of_students);
                if (!valid1 || num_of_students <= 0)
                {
                    Console.Write("\nPlease enter an integer value > 0 : ");
                }
            } while (!valid1 || num_of_students < 0);
            
            int[] scores = new int[num_of_students];
            string[] names = new string[num_of_students];

            //Loop for the number of students
            for (int i = 0; i < scores.Length; i++)
            {
                //Declare a boolean for the score input

                bool valid2;
                int score_input;
                //Enter a name for each element of the array
                Console.Write("\nEnter the name for student #{0}, please : ", i + 1);
                string name_input = Console.ReadLine(); 
                names[i] = name_input;
                Console.Write("\nEnter score #{0}, please : ", i + 1);

                //Tests the score input for an integer value
                do
                {
                    //If anything other than an integer, then keeps asking to re enter.
                    valid2 = Int32.TryParse(Console.ReadLine(), out score_input);
                    if (!valid2 || score_input <= 0)
                    {
                        Console.Write("\nPlease enter a valid integer value > 0 : ");
                    }
                } while (!valid2 || score_input < 0);

                scores[i] = score_input;
                
            }

            //Lists the names and scores in separate lists
            Console.WriteLine("Name\tScore");

            //Loop for the number of elements in the array
            for (int j = 0; j < num_of_students; j++)
            {
                Console.WriteLine(names[j] + "\t" + scores[j]);
            }

            //Declare variables for the average and highest scores
            int ave = 0, high = scores[0], who = 0;

            //Loop to take the average and find the highest value in the array
            for (int i = 0; i < scores.Length; i++)
            {
                ave += scores[i];
                if (high < scores[i])
                {
                    high = scores[i];
                    who = i;
                }
            }

            //Finally writes out the average score and what # the highest score is in the list
            Console.WriteLine("The average score is {0}", ave / num_of_students);
            Console.WriteLine("Score #{0} has the highest score of {1}", who + 1, high);

            Console.ReadLine();
        
    }
    }
}
