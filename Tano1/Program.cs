using System;
using System.Linq;
using System.Collections.Generic;
namespace Tano1
{
	class Program
	{

		static void Main(string[] args)
		{
            List<int> numbers = new List<int>();
            Console.Write("Input : ");
            int[] input = new int[int.Parse(Console.ReadLine())];
            int mid = input.Length / 2;
            Console.Write("First Elimination Remains : ");
            for (int x = 1; x <= input.Length; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write("\t" + x);
                }
            }
            Console.WriteLine();
            Console.Write("Winner : ");
            for (int x = 1; x <= input.Length; x++)
            {
                if (x % 2 == 0)
                {
                    numbers.Add(x);
                }
            }
            var length = numbers.Count();
            Console.Write(numbers[length / 2]);
		}
    }
}
