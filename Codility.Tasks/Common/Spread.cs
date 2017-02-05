namespace Codility.Tasks.Common
{
	internal struct Spread
	{
		public Spread(int max, int min)
		{
			Max = max;
			Min = min;
		}

		public int Max { get; }

		public int Min { get; }

		public int Range() => Max - Min + 1;

		public override string ToString() => $"[{Min};{Max}]";
	}
}
