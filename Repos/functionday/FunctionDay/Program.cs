using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDay
{
	class Program
	{

		static void Main(string[] args)
		{
			DateTime day = new DateTime();
			Console.Write("Inser your end date (example: 04.04.2017): ");
			DateTime endDate = DateTime.Parse(Console.ReadLine());
			int numberOfDays = 0;
			for (day = DateTime.Now.Date; day.Date < endDate.Date; day = day.Date.AddDays(1))
			{
				string dayToString = Convert.ToString(day.DayOfWeek);
				if (dayToString != "Saturday" && dayToString != "Sunday") numberOfDays++;
			}
			Console.WriteLine("Number of working days (not including local holidays) between two dates is " + numberOfDays);
		}
	}
}