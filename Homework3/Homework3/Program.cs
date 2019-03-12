using System;
using Homework3.classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
	class Classes
	{
		static void Main(string[] args)
		{
			Student[] Students = new Student[5];
			Students[0] = new Student("Martin", "SEDC", "G2");
			Students[1] = new Student("Dario", "SEDC", "G2");
			Students[2] = new Student("Petar", "SEDC", "G2");
			Students[3] = new Student("Vanco", "Semos", "A");
			Students[4] = new Student("Riste", "Codecademy", "A");

			var Dragana = true;
			Console.WriteLine("Enter a name");
			string name = Console.ReadLine();
			foreach (var item in Students)
			{
				if (name==item.Name)
				{
					Dragana = false;
					Console.WriteLine($"{item.Name} {item.Academy} {item.Group}");
					break;
				}
				

			}
			if (Dragana)
			{
				Console.WriteLine("There is not a student with that name");
			}

			Console.ReadLine();

		}

		

	}
}
