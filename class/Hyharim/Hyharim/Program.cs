using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyharim
{
	class Program 
	{
		static void Main(string[] args)
		{
			Tesla teslaModelX = new Tesla();
			BMW bmw = new BMW();
			Console.WriteLine("Выберите машину из предложенный ниже:\n" +
							  "1 - Tesla\n" +
							  "2 - BMW\n");
			string choiseModel = Console.ReadLine();
			if (choiseModel == "1")
			{
				teslaModelX.TeslaModels();
			}
			if(choiseModel == "2")
			{
				bmw.BMWModels();
			}
			Console.ReadKey();
		
			//
			//teslaModelX.ShowCarInfo();
			//Console.WriteLine();
			//teslaModelX.TeslaModel();
			
		}
	}
}
