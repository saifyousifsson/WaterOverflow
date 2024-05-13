using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
	public class Pyramid
	{
		private int rows;

		public Pyramid(int rows)
		{
			this.rows = rows;
		}

		public double CalculateTimeToOverflow(int glass)
		{
			int totalGlasses = (rows * (rows + 1)) / 2;
			double waterInGlass = 10.0 * (glass - 1);
			double levelInGlass = waterInGlass + 5.0 * (rows - 1);
			return (levelInGlass - 2.6667) / 2.0 * 10.0;
		}
	}
}
