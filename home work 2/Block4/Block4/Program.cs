using System;

namespace Block4
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b;
			Console.Write("Введите a: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите b: ");
			b = Convert.ToInt32(Console.ReadLine());

			double Z;
			if (a < b)
			{
				Z = Math.Pow(b, 3) - Math.Sqrt(Math.Pow(b, 2) + Math.Pow(Math.Sin(2), a));
				Console.WriteLine("Z = " + Z);
			}
			else if (a == b)
			{
				Z = 3 * Math.Log(Math.Pow(a, 2), Math.E);
				Console.WriteLine("Z = " + Z);
			}
			else if (a > b)
			{
				Z = 4 * a + Math.Pow(b, 2) - Math.Sin(a * b);
				Console.WriteLine("Z = " + Z);
			}
			Console.ReadLine();
		}
	}
}
