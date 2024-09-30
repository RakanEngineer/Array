using System.Globalization;
using static System.Console;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = new string[7];
            weekdays[0] = "Monday";
            weekdays[1] = "Tuesday";
            weekdays[2] = "Wednesday";
            weekdays[3] = "Thursday";
            weekdays[4] = "Friday";
            weekdays[5] = "Saturday";
            weekdays[6] = "Sunday";
            foreach (string weekday in weekdays)
            {
                WriteLine(weekday);
            }
           
        }
    }
}
