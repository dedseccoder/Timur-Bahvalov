using System;

namespace Block3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Ввод а: ");
			var a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ввод b: ");
			var b = Convert.ToInt32(Console.ReadLine());

			var x = ((Math.E + Math.Pow(Math.E, -b)) / 2) * Math.Cos(Math.PI * b);
			var y = Math.Sin(a + b) * Math.Log(Math.Pow(a, 2) / 2, Math.E);
			Console.WriteLine("x = " + x + "\nY = " + y);
			Console.ReadLine();
		}
	}
}
