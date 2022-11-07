using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> input=Enumerable.Range(1,30).ToList();
			Func<int, bool> func = n => n % 2 == 0;

			List<int> result=GetEvenItems(input,func);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}

		static public List<int> GetEvenItems(List<int> input, Func<int, bool> func)
		{
			var result = new List<int>();
			foreach (var item in input)
			{
				if (func(item)) result.Add(item);
			}
			return result;
		}
	}
}
