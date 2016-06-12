using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace DiveTracker.Tests
{
	public class DiveTimingTests
	{
		[Fact]
		public void SequenceInOrder() {
			var sequence = new DiveSequence("a-1-b-2");
			var timing = new DiveTiming(sequence);

			timing.Point(1); // exit
			timing.Point(2);
			timing.Point(3);
			timing.Point(4);
			timing.Point(5);
			timing.Point(6);
			timing.Point(7);
			timing.Point(8); // point 7

			var timings = timing.ToList();
			Assert.Equal(8, timings.Count);
			Assert.Equal("Exit", timings[0].Formation.ID);
			Assert.Equal("A", timings[1].Formation.ID);
			Assert.Equal("1a", timings[2].Formation.ID);
			Assert.Equal("1b", timings[3].Formation.ID);
			Assert.Equal("B", timings[4].Formation.ID);
			Assert.Equal("2a", timings[5].Formation.ID);
			Assert.Equal("2b", timings[6].Formation.ID);
			Assert.Equal("A", timings[7].Formation.ID);
		}
	}
}
