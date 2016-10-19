using System;
using System.Linq;

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

            var element = A.First();

            for (int i = 1; i < A.Length; i++)
            {
                element ^= A[i];
            }

            return element;
        }
    }
}