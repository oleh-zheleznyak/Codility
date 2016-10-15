using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson2.Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            if (A == null) throw new ArgumentNullException(nameof(A));
            if (A.Length % 2 == 0) throw new ArgumentException("Array A should be non empty and with odd number of elements");
            if (A.Length == 1) return A.First();

            // cheat - this makes the time complexity O(NlgN) instead of O(N), but keeps space complexity at O(1)
            // however, if we use counting sort, we will have O(N) time complexity, but also O(N) space complexiy
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i += 2)
            {
                if (A[i] != A[i + 1]) return A[i];
            }

            return A.Last();
        }
    }
}
