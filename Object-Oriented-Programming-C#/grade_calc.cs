namespace Juan_Diaz
{
    class Program
    {
        static void Main(string[] args)
        {
            double hw, quiz, project, exam, final, grade;
            Console.Write("Enter the homework grade: ");
            hw = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the quiz grade: ");
            quiz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the project grade: ");
            project = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the exam grade: ");
            exam = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the final exam grade: ");
            final= Convert.ToDouble(Console.ReadLine());

            grade = (hw * 0.1) + (quiz * 0.2) + (project * 0.25) + (exam * 0.2) + (final * 0.25);
            grade = Math.Round(grade, 2);

            Console.WriteLine("The total grade is " + grade);
        }
    }
}
