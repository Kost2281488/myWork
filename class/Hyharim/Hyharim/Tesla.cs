using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyharim
{
	class Tesla : Car
	{
		public override string Price => "10_000_000$";

		public override string Color => "Gray";

		public override string MaxSpeed => "300км/ч";

		public override string CarModel => "TeslaModelX";

		public void TeslaModels()
		{
			List<string> teslaModel = new List<string>();
			teslaModel.Add("TeslaModelX");
			teslaModel.Add("TeslaModel3");

			foreach (string tesla in teslaModel)
			{
				Console.WriteLine(tesla);
			}
		}

		public void TeslaColors()
		{
			List<string> teslaColors = new List<string>();
			teslaColors.Add("red");
			teslaColors.Add("green");
			teslaColors.Add("Blue");
			teslaColors.Add("Gray");

			foreach (string teslaColor in teslaColors)
			{
				Console.WriteLine(teslaColor);
			}
		}
	}
}
