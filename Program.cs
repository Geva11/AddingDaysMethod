using System;

namespace Adding_Days
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Invalid input. Day number should be between 1 and 7.");
                return;
            }

            string day = GetDayOfWeek(dayNumber);
            Console.WriteLine("The day is " + day);

            Console.Write("Enter number of days to add: ");
            int addDay = Convert.ToInt32(Console.ReadLine());

            int newDayNumber = (dayNumber + addDay - 1) % 7 + 1;
            string newDay = GetDayOfWeek(newDayNumber);

            Console.WriteLine("The new day is " + newDay);
        }

        public static string GetDayOfWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Invalid Day";
            }
        }
    }
}