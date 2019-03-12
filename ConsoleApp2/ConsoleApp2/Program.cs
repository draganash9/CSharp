using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
	class Program
	{
		static void Main(string[] args)
		{
			//DateTime aDate = DateTime.Now.AddDays(3);
			//DateTime bDate = DateTime.Now.AddMonths(1);
			//DateTime cDate = DateTime.Now.AddMonths(1).AddDays(3);
			//DateTime dDate = DateTime.Now.AddYears(-1).AddMonths(-2);
			//DateTime month = DateTime.Now;
			//DateTime year = DateTime.Now;
			//Console.WriteLine(year.Year);
			//Console.WriteLine(month.Month);
			//Console.WriteLine(month.ToString("MMMM"));
			//Console.WriteLine(dDate);
			//Console.ReadLine();
			//AgeCalculator();

			//Console.ReadLine();
			
			Console.WriteLine("Enter your birthdate in format: month-day-year");
			DateTime birthday = DateTime.Parse(Console.ReadLine());
			AgeCalculator(birthday);
			

		}
		
		static void AgeCalculator(DateTime birthdate)
		{
			DateTime currentTime = DateTime.Now;
			int age = currentTime.Year - birthdate.Year;
			if (birthdate.Month > currentTime.Month) age--;
			if (birthdate.Month == currentTime.Month && birthdate.Day > currentTime.Day) age--;
			Console.WriteLine($"Your age is: {age}");
			Console.ReadLine();
		}


		



	}
}
