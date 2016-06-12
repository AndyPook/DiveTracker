using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveTracker
{
	public class DivePoint
	{
		public DivePoint(int point, Random formation, double time)
		{
			Point = point;
			Formation = formation;
			Time = time;
		}

		public int Point { get; private set; }
		public Random Formation { get; private set; }
		public double Time { get; private set; }

		public override string ToString()
		{
			return $"{Point} {Formation.ID} ({Time})";
		}
	}
}