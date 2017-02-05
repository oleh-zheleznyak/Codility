using System;
using Codility.Tasks.Common;

namespace Codility.Tasks.Lesson4.CountingElements
{
	public class FrogRiverOne
	{
		public const int No_Solution = -1;

		public int solution(int X, int[] A)
		{
			if (A == null) throw new ArgumentNullException(nameof(A));
			if (A.Length == 0) throw new ArgumentException($"no elements in the array {nameof(A)}");
			if (X <= 0) throw new ArgumentException($"{nameof(X)} must be greater than zero");

			if (A.Length < X) return No_Solution;

			return CalculateEarliestTimeToCross(X, A);
		}

		private int CalculateEarliestTimeToCross(int X, int[] A)
		{
			var counter = RecordFirstOccurrencesAtEachPosition(X, A);
			var spread = GetSpread(counter);

			if (spread.Min == int.MinValue)
				return No_Solution;
			else
				return spread.Max;
		}

		private int[] RecordFirstOccurrencesAtEachPosition(int X, int[] A)
		{
			var defaultValue = int.MinValue;
			var counter = CreateWithDefault(X, defaultValue);
			for (int i = 0; i < A.Length; i++)
			{
				if (counter[A[i] - 1] == defaultValue)
					counter[A[i] - 1] = i;
			}

			return counter;
		}

		private int[] CreateWithDefault(int size, int defaultValue)
		{
			var array = new int[size];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = defaultValue;
			}

			return array;
		}

		private Spread GetSpread(int[] A)
		{
			int min = int.MaxValue, max = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > max) max = A[i];
				if (A[i] < min) min = A[i];
			}

			return new Spread(max, min);
		}
	}
}
