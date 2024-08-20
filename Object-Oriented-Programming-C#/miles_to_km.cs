namespace Juan_Diaz
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile, kilometer;
            Console.WriteLine("Enter the distance in miles: ");
            mile = Convert.ToDouble(Console.ReadLine());
            kilometer = mile * 1.609;
            kilometer = Math.Round(kilometer, 2);
            Console.WriteLine("The distance is  " + kilometer + " km");
            Console.Read();
        }
    }
}
