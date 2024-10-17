namespace yearsToDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // years to days
            Console.WriteLine("welcome to years to days app ");

            //ask user to enter years
            Console.WriteLine("please enter number of years ");
            // read years from user 
            byte years = 0;
            bool convertYears = byte.TryParse(Console.ReadLine(), out years);

            // convert years

            int months = years * 12;
            int weeks = years * 52;
            int days = years * 365;
            int hours = years * days * 24;

            // print 

            Console.WriteLine($"months in year {months}");
            Console.WriteLine($"weeks in year {weeks}");
            Console.WriteLine($"days in year {days}");
            Console.WriteLine($"hours in year {hours}");


        }
    }
}
