using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{


			////Task 1

			//Console.WriteLine("enter 20 numbers");
			//int[] numArray = new int[20];

			//for (var i = 0; i < numArray.Length; i++)
			//{
			//	numArray[i] = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("this is your array");



			////Task 2

			//for (int i = 0; i < numArray.Length; i++) 
			//{
			//	Console.WriteLine(numArray[i]);

			//	if (numArray[i] == 0)
			//	{
			//		Console.WriteLine("Skipped");
			//		continue;
			//	}

			//	if (Math.Abs(numArray[i]).ToString().Length == 3)
			//	{
			//		break;
			//	}
			//}
			//Console.ReadLine();


			////Task 3

			//int[] intArray = new int[5];
			//Console.WriteLine("Enter first array element:");
			//intArray[0] = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Enter second array element:");
			//intArray[1] = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Enter third array element:");
			//intArray[2] = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Enter fourth array element:");
			//intArray[3] = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Enter fifth array element:");
			//intArray[4] = Convert.ToInt32(Console.ReadLine());
			//int result = 0;
			//for (int i = 0; i < intArray.Length; i++)
			//{
			//	result += intArray[i];
			//}
			//Console.WriteLine("The sum is: ");
			//Console.WriteLine(result);


			//Task 6



			//string[] names = new string[0];
			//string answer;
			//do
			//{
			//	Console.WriteLine("Enter a name:");
			//	Array.Resize(ref names, names.Length + 1);
			//	names[names.Length - 1] = Console.ReadLine();
			//	Console.WriteLine("Do you want to enter another name? (Y/N");
			//	answer = Console.ReadLine();


			//} while (answer == "Y");
			//{
			//	Console.WriteLine("All names:");
			//	for (int i = 0; i < names.Length; i++)
			//	{
			//		Console.WriteLine(names[i]);
			//	}

			//};



			string[] names = new string[0];
			string answer;

			do
			{
				Console.WriteLine("Enter name:");
				Array.Resize(ref names, names.Length + 1);
				names[names.Length - 1] = Console.ReadLine();
				Console.WriteLine("Do you want to enter another name? (Y / N)");
				answer = Console.ReadLine();

			} while (answer == "Y" || answer=="y");
			Console.WriteLine("All names:");
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
			}
			Console.ReadLine();

		}
	}
}
