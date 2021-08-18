using System;

namespace Codility.Tasks.Lesson1.Iterations
{
    class Solution
    {
        public int solution(int N)
        {
            var n = Math.Abs(N);

            var tail = N & 1;
            var head = tail;
            var maxBinaryGap = 0;
            var currentBinaryGap = 0;

            while (n > 0)
            {
                n = n >> 1;
                head = n & 1;

                if (head == 0 && tail == 1) // binary gap found, advance head
                {
                    currentBinaryGap++;
                }
                else if (head == 0 && tail == 0) // advance head, tail will follow
                {
                }
                else if (head == 1 && tail == 0) // sequence start, advance tail
                {
                    tail = head;
                }
                else if (head == 1 && tail == 1) // sequence ended
                {
                    maxBinaryGap = Math.Max(maxBinaryGap, currentBinaryGap);
                    currentBinaryGap = 0;
                }

            }
            return maxBinaryGap;
        }
    }
}