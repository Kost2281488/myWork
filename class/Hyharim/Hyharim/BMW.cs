using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyharim
{
	class BMW : Car
	{
		public override string Price => "5_000_000;";

		public override string Color => "Black";

		public override string MaxSpeed => "320км/ч";

		public override string CarModel => "BMW i4";

		public void BMWModels()
		{
			List<string> bmwModel = new List<string>();
			bmwModel.Add("BMV x5");
			bmwModel.Add("Еще хуйня какая-то");

			foreach (string bmw in bmwModel)
			{
				Console.WriteLine(bmw);
			}
		}
	}
	
}
