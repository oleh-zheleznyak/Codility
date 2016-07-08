using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            var max = 0;
            var zeroCount = 0;
            var hadOne = false;

            while (N > 0)
            {
                if ((N & 1) == 1)
                {
                    max = Math.Max(max, zeroCount);
                    zeroCount = 0;
                    hadOne = true;
                }
                else
                {
                    if (hadOne) zeroCount++;
                }

                N >>= 1;
            }

            return max;
        }
    }
}