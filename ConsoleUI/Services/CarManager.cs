using System;
using ConsoleUI.Models;

namespace ConsoleUI.Services
{
	public class CarManager
	{
		public void Start(Car car, int km)
		{

			// 100 - 12
			// 12 -  x
			double checkFuel = car.Fuel - (car.Kmpl * km / 100);
			if (checkFuel < 0)
			{
				Console.WriteLine("Zehmed olmasa YDM-ya gedin.");
			}
			else
			{
				car.Fuel = checkFuel;
				car.Mileage += km;
                Console.WriteLine(car.Fuel);
                Console.WriteLine(car.Mileage);

            }



        }
	}
}

