using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveTracker
{
	public class DiveTiming : IEnumerable<DivePoint>
	{
		public DiveTiming(DiveSequence sequence)
		{
			this.sequence = sequence;
		}
		public DiveTiming(string sequence)
		{
			this.sequence = new DiveSequence(sequence);
		}

		private readonly DiveSequence sequence;

		private readonly List<DivePoint> points = new List<DivePoint>();
		private int point = 0;

		public double Exit { get; private set; }
		public int Points => point;

		public void Point(double time)
		{
			if (point == 0)
			{
				Exit = time;
				points.Add(new DivePoint(0, Random.Exit, time));
			}
			else
				points.Add(new DivePoint(point, sequence.GetPoint(point), time));
			point++;
		}

		public IEnumerator<DivePoint> GetEnumerator()
		{
			return points.GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}