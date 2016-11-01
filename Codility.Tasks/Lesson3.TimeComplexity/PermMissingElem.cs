using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson3.TimeComplexity
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            if (A == null) throw new ArgumentNullException(nameof(A));
            if (A.Length == 0) return 1;

            long sum = A.Aggregate(0L, (x, y) => x + y);
            var arithProgressionSum = (long)(A.Length + 1) * (2 + A.Length) / 2;
            var missingElement = arithProgressionSum - sum;

            return (int)missingElement;
        }
    }
}
