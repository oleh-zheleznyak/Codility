using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson3.TimeComplexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            if (A == null) throw new ArgumentNullException(nameof(A));
            if (A.Length < 2) throw new ArgumentException($"Array {nameof(A)} does not have enough elements");

            var totalSum = A.Sum();
            var leadingSum = 0;
            var trailingSum = totalSum;
            var minDiff = int.MaxValue;
            var index = 0;

            for (int i = 1; i < A.Length; i++)
            {
                leadingSum += A[i - 1];
                trailingSum -= A[i - 1];
                var diff = Math.Abs(leadingSum - trailingSum);

                if (diff < minDiff)
                {
                    minDiff = diff;
                    index = i;
                }
            }

            return minDiff;
        }
    }
}
