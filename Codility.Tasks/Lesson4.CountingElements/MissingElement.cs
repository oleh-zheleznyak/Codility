using System;
using System.Collections;

namespace Codility.Tasks.Lesson4.CountingElements
{
	public class MissingElement
	{
		public int solution(int[] A)
		{
			if (A == null) throw new ArgumentNullException(nameof(A));

			var spread = GetSpread(A);
			if (spread.Min > 1) return 1;

			var bitArray = FillBitArray(A, spread);

			for (int i = 0; i < bitArray.Length; i++)
			{
				if (!bitArray[i]) return i + spread.Min;
			}

			return spread.Max + 1;
		}

		private static BitArray FillBitArray(int[] A, Spread spread)
		{
			var flagArray = new BitArray(spread.Range());

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
