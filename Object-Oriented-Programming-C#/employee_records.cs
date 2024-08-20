namespace Juan_Diaz
{
    internal class Program
    {
        

        class Employee
        {
            private string employee_num;
            private string employee_firstname;
            private string employee_lastname;
            private double employee_salary;

            //default constructor
            public Employee()
            {
                employee_firstname = string.Empty;
                employee_lastname = string.Empty;
                employee_num = "unknown";
                employee_salary = 0;

            }

            //overloading constructor
            public Employee(string num, string fn, string ln, double pay)
            {
                employee_num = num;
                employee_firstname = fn;
                employee_lastname = ln;
                employee_salary = SalaryCalc(pay);
            }

            public double SalaryCalc(double pay)
            {
                double salary_calc = pay * 12;
                
                return salary_calc;
            }

            public void DispInfo(double monthlypay)
            {
                Console.WriteLine($"\nNumber: {employee_num}");
                Console.WriteLine($"Name: {employee_firstname} {employee_lastname}");
                Console.WriteLine($"Monthly pay: {monthlypay}");  
                Console.WriteLine($"Annual pay: {employee_salary}");
                
            }

        }

        class Test
        {

            static void Main(string[] args)
            {
                string emp_fname, emp_lname, emp_num;
                double monthly1, monthly2;

                //1st Employee Object
                Console.Write("Enter the first name of employee #1: ");
                emp_fname = Console.ReadLine();
                Console.Write("Enter the last name of employee #1: ");
                emp_lname = Console.ReadLine();
                Console.Write("Enter the ID number of employee #1: ");
                emp_num = Console.ReadLine();
                Console.Write("Enter the monthly salary of employee #1: $");
                monthly1 = double.Parse(Console.ReadLine());
                

                Employee emp1 = new Employee(emp_num, emp_fname, emp_lname, monthly1);

                //2nd Employee Object
                Console.Write("Enter the first name of employee #2: ");
                emp_fname = Console.ReadLine();
                Console.Write("Enter the last name of employee #2: ");
                emp_lname = Console.ReadLine();
                Console.Write("Enter the ID number of employee #2: ");
                emp_num = Console.ReadLine();
                Console.Write("Enter the monthly salary of employee #2: $");
                monthly2 = double.Parse(Console.ReadLine());

                Employee emp2 = new Employee(emp_num, emp_fname, emp_lname, monthly2);

                Console.Write("\nEmployee #1 --------------------");
                emp1.DispInfo(monthly1);
                Console.Write("\nEmployee #2 --------------------");
                emp2.DispInfo(monthly2);
            }

        }
    }
}
