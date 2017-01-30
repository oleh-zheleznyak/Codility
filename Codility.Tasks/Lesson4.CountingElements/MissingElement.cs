using System;
using System.Collections.Generic;

namespace Codility.Tasks.Lesson4.CountingElements
{
	public class MissingElement
	{
		public int solution(int[] A)
		{
			if (A == null) throw new ArgumentNullException(nameof(A));

			var spread = GetSpread(A);
			if (spread.Min > 1) return 1;

			if (spread.Max > byte.MaxValue)
				return FindSolutionUsingHashSet(A, spread);
			else
				return FindSolutionUsingArray(A, spread);
		}

		private static int FindSolutionUsingHashSet(int[] A, Spread spread)
		{
			var hash = new HashSet<int>();
			for (int i = 0; i < A.Length; i++)
			{
				if (!hash.Contains(A[i])) hash.Add(A[i]);
			}
			for (int i = 1; i <= spread.Max; i++)
			{
				if (!hash.Contains(i)) return i;
			}
			return spread.Max + 1;
		}


		private static int FindSolutionUsingArray(int[] A, Spread spread)
		{
			var flagArray = FillFlagArray(A, spread);

			for (int i = 0; i < flagArray.Length; i++)
			{
				if (!flagArray[i]) return i + spread.Min;
			}

			return spread.Max + 1;
		}

		private static bool[] FillFlagArray(int[] A, Spread spread)
		{
			var flagArray = new bool[spread.Range()];

			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > 0) flagArray[A[i] - spread.Min] = true;
			}

			return flagArray;
		}

		private Spread GetSpread(int[] A)
		{
			int min = int.MaxValue, max = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > max) max = A[i];
				if (A[i] > 0 && A[i] < min) min = A[i];
			}

			return new Spread(max, min);
		}

		private struct Spread
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
}
