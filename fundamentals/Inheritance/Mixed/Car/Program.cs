using System;
using System.Drawing;
using MyLibrary;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ICar[] cars = {
				new M3 { Color = Color.Silver},
				new Hooptie { Color = Color.Black},
			};
			
			foreach (ICar car in cars)
			{
				PrintCarInfo(car);
				car.Start();
				car.PressAccelerator(2);
				car.PressAccelerator(10);
				car.PressBrake(2);
				car.PressBrake(10);
			}
			
		}
		
		static void PrintCarInfo(ICar car)
		{
			Console.WriteLine("Here is a {0} {1} {3}",
				car.Color.Name, car.Year, car.Make, car.Model);
		}
	}
}