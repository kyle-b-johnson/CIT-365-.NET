using System;


namespace MyFirstConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();

            Console.ReadKey();
            return;
        }
        private static void GetUserNameAndLocation()
        {
            Person person = new Person();

            Console.WriteLine("What is your name?");

            person.name = Console.ReadLine();
            
            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            
            Console.WriteLine($"I have never been to {person.location} "+
                "I bet it is nice.\nPress any key to continue...");

            Console.ReadKey();

            return;
        }

        private static void ChristmasCountdown(DateTime date)
        {
            Console.WriteLine($"Today's date is: {date.Date}");
            int year = date.Year;
            DateTime christmas = new DateTime(year, 12, 25, 00, 00, 00);
            TimeSpan christmasDaysSpan = christmas.Subtract(date);
            int christmasDays = (int) Math.Round(christmasDaysSpan.TotalDays);
            Console.WriteLine($"There are {christmasDays} days until Christmas!" +
                $"\nPress any key to continue..");

            Console.ReadKey();

            return;
        }

    
    }

   
}
