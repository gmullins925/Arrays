using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
	class Program
	{
		static void Main(string[] args)
		{
			string [] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			Console.WriteLine(days.Length.ToString());


			for (int i = 0; i < days.Length; i++)
			{
				Console.WriteLine(days[i]);
			}

			foreach (string varName in days)
			{
				Console.WriteLine("The day is : " + varName);
			}
			Console.ReadLine();


		}
	}
}
