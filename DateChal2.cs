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
			//Subtract to get date
            Console.WriteLine("Difference in Seconds: " + span.TotalSeconds);
            Console.WriteLine("Difference in Minutes: " + span.TotalMinutes);
            Console.WriteLine("Difference in Hours: " + span.TotalHours);
            Console.WriteLine("Difference in Days: " + span.TotalDays);
            int years = Convert.ToInt32(span.TotalDays / 365);
            int months = Convert.ToInt32((span.TotalDays % 365)/30);
			//Divide by 30 for months
            int days = Convert.ToInt32((span.TotalDays % 365) % 30);
			//Multiply 1440(minutes in days)
            int minutes = Convert.ToInt32((span.TotalDays % 365) % 30) * 1440;
            string output = string.Format("Total Difference: {0} days, {1} hours, {2} minues, {3} seconds", span.Days, span.Hours, span.Minutes, span.Seconds);
            Console.WriteLine(output);
            output = string.Format("Total Difference: {0} Years, {1} Months, {2} Days, {3} Minutes", years.ToString(), months.ToString(), days.ToString(), span.Seconds);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
