using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyharim
{
	public abstract class Car 
	{

		public abstract string Price { get; }
		public abstract string Color { get; }

		public abstract string MaxSpeed { get; }

		public abstract string CarModel { get; }

		public void ShowCarInfo()
		{
			Console.WriteLine($"Модель: {CarModel}\n Цена: {Price}\n Цвет: {Color}\n Макс. Скорость: {MaxSpeed}\n");
		}


	}
}
