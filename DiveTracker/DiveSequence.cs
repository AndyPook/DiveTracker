using System;
using System.Collections.Generic;
using System.Linq;

namespace DiveTracker
{
	public class DiveSequence
	{
		public DiveSequence(string sequence)
		{
			SetSequence(sequence);
		}

		private int pointsPerPage;
		private Random[] sequence;

		public List<Formation> points = new List<Formation>();

		public Random GetPoint(int point)
		{
			if (point == 0)
				return Random.Exit;
			var x = (point - 1) % pointsPerPage;
			return sequence[x];
		}

		public void SetSequence(string sequence)
		{
			var parts = sequence.Split(' ', '.', '-');
			foreach (var part in parts.Where(x => !string.IsNullOrWhiteSpace(x)))
				points.Add(GetPoint(part));
			pointsPerPage = points.Sum(x => x.Points);
			this.sequence = GetSequence().ToArray();
		}

		private IEnumerable<Random> GetSequence()
		{
			foreach (var f in points)
			{
				if (f is Random)
					yield return (Random)f;
				else
				{
					var b = (Block)f;
					yield return b.Formation1;
					yield return b.Formation2;
				}
			}
		}

		private Formation GetPoint(string id)
		{
			if (string.IsNullOrWhiteSpace(id))
				throw new ArgumentNullException(nameof(id));
			if (id.Length > 2)
				throw new ArgumentException("Too many characters", nameof(id));

			if (char.IsLetter(id[0]))
				return new Random(id);
			if (char.IsDigit(id[0]))
				return new Block(id);

			throw new ArgumentException("id not recognised", nameof(id));
		}

		public override string ToString()
		{
			return string.Join("-", points.Select(x => x.ID));
		}
	}

	public class Formation
	{
		public string ID { get; protected set; }
		public int Points { get; protected set; }

		public override string ToString()
		{
			return ID;
		}
	}

	public class Random : Formation
	{
		public static readonly Random Exit = new Random("Exit") { Points = 0 };

		private Random(string id)
		{
			ID = id;
			Name = id;
		}

		public Random(string id, string name = null)
		{
			Points = 1;
			if (string.IsNullOrWhiteSpace(id))
				throw new ArgumentNullException(nameof(id));
			id = id.Trim();
			if (id.Length == 2)
			{
				if (!char.IsDigit(id[0]) && id[1] != 'a' && id[1] != 'b')
					throw new ArgumentException("Invalid Block Random: " + id, nameof(id));
				ID = id;
			}
			else if (id.Length == 3)
			{
				if (!char.IsDigit(id[0]) && !char.IsDigit(id[1]) && id[2] != 'a' && id[2] != 'b')
					throw new ArgumentException("Invalid Block Random: " + id, nameof(id));
				ID = id;
			}
			else if (id.Length != 1)
				throw new ArgumentException("Invalid Random: " + id, nameof(id));
			else
				ID = id.ToUpperInvariant();

			if (ID[0] > 'Q' || ID == "I")
				throw new ArgumentException("Invalid Random: " + ID, nameof(id));
			Name = name ?? ID;
		}

		public string Name { get; }
	}

	public class Block : Formation
	{
		public Block(string id, string f1 = null, string f2 = null)
		{
			Points = 2;
			if (string.IsNullOrWhiteSpace(id))
				throw new ArgumentNullException(nameof(id));
			id = id.Trim();
			int x;
			if (!int.TryParse(id, out x) || x > 22)
				throw new ArgumentException("Invalid Block: " + ID, nameof(id));

			ID = id;
			Formation1 = new Random(ID + "a", f1);
			Formation2 = new Random(ID + "b", f2);
		}

		public Random Formation1 { get; }
		public Random Formation2 { get; }
	}
}