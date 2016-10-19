using System;

namespace Codility.Tasks.Lesson2.Arrays
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            if (K < 0) throw new ArgumentException(nameof(K));
            if (A == null) throw new ArgumentNullException(nameof(A));
            if (A.Length == 0) return A;
            if (K == 0 || K == A.Length) return A;

            K = K % A.Length;
            var result = new int[A.Length];

            Array.Copy(A, A.Length - K, result, 0, K);
            Array.Copy(A, 0, result, K, A.Length - K);

            return result;
        }
    }
}