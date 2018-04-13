using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Date:(MM-DD-YYYY) ");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Second Date:(MM-DD-YYYY) ");
            DateTime date2 = Convert.ToDateTime(Console.ReadLine());
            TimeSpan span = date1.Subtract(date2);
			//Subtract dates to get outcome
            Console.WriteLine("Difference in Seconds: " + span.TotalSeconds);
            Console.WriteLine("Difference in Minutes: " + span.TotalMinutes);
            Console.WriteLine("Difference in Hours: " + span.TotalHours);
            Console.WriteLine("Difference in Days: " + span.TotalDays);

            string output = string.Format("Total Difference: {0} days, {1} hours, {2} minues, {3} seconds", span.Days, span.Hours, span.Minutes, span.Seconds);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
