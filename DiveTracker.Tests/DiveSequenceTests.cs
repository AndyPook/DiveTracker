using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace DiveTracker.Tests
{
	public class DiveSequenceTests
	{
		[Fact]
		public void Create()
		{
			var sequence = new DiveSequence("A B 1 20");

			Assert.Equal("A-B-1-20", sequence.ToString());
		}

		[Theory]
		[InlineData("I")]
		[InlineData("R")]
		[InlineData("23")]
		public void Invalid(string sequence)
		{
			Assert.Throws<ArgumentException>(() => new DiveSequence(sequence));
		}

		[Fact]
		public void Sequence()
		{
			var sequence = new DiveSequence("A 1 B 2");
			int i = 0;
			Assert.Equal("Exit", sequence.GetPoint(i++).ID);
			Assert.Equal("A", sequence.GetPoint(i++).ID);
			Assert.Equal("1a", sequence.GetPoint(i++).ID);
			Assert.Equal("1b", sequence.GetPoint(i++).ID);
			Assert.Equal("B", sequence.GetPoint(i++).ID);
			Assert.Equal("2a", sequence.GetPoint(i++).ID);
			Assert.Equal("2b", sequence.GetPoint(i++).ID);
			Assert.Equal("A", sequence.GetPoint(i++).ID);
			Assert.Equal("1a", sequence.GetPoint(i++).ID);
			Assert.Equal("1b", sequence.GetPoint(i++).ID);
			Assert.Equal("B", sequence.GetPoint(i++).ID);
			Assert.Equal("2a", sequence.GetPoint(i++).ID);
			Assert.Equal("2b", sequence.GetPoint(i++).ID);
			Assert.Equal("A", sequence.GetPoint(i++).ID);
			Assert.Equal("1a", sequence.GetPoint(i++).ID);
			Assert.Equal("1b", sequence.GetPoint(i++).ID);
			Assert.Equal("B", sequence.GetPoint(i++).ID);
			Assert.Equal("2a", sequence.GetPoint(i++).ID);
			Assert.Equal("2b", sequence.GetPoint(i++).ID);
			Assert.Equal("A", sequence.GetPoint(i++).ID);
			Assert.Equal("1a", sequence.GetPoint(i++).ID);
			Assert.Equal("1b", sequence.GetPoint(i++).ID);
			Assert.Equal("B", sequence.GetPoint(i++).ID);
			Assert.Equal("2a", sequence.GetPoint(i++).ID);
			Assert.Equal("2b", sequence.GetPoint(i++).ID);
		}
	}
}