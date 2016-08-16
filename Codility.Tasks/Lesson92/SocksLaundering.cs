using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson92
{
    public class SocksLaundering
    {
        public const int MaxColors = 50;

        public int solution(int K, int[] C, int[] D)
        {
            var Cs = CountSort(C);
            var Ds = CountSort(D);

            PairSocksByOne(ref K, Cs, Ds);
            TakeMaximumAmountOfPairs(ref K, Cs, Ds);

            var result = CountPairs(Cs);

            return result;
        }

        private int CountPairs(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i] / 2;
            }

            return sum;
        }

        private void PairSocksByOne(ref int K, int[] Cs, int[] Ds)
        {
            for (int i = 0; i < MaxColors && K > 0; i++)
            {
                if (Cs[i] % 2 == 1 && Ds[i] >= 1) // odd clean socks and at least one dirty exists
                {
                    Ds[i] -= 1;
                    Cs[i] += 1;
                    K -= 1;
                }
            }
        }

        private void TakeMaximumAmountOfPairs(ref int K, int[] Cs, int[] Ds)
        {
            for (int i = 0; i < MaxColors; i++)
            {
                var pairedSocks = (Ds[i] >> 1) << 1; // take max even part
                int take = 0;

                if (K >= pairedSocks)
                {
                    take = pairedSocks;
                }
                else
                {
                    take = (K >> 1) << 1;
                }

                Ds[i] -= take;
                Cs[i] += take;
                K -= take;
            }
        }

        private int[] CountSort(int[] array)
        {
            var result = new int[MaxColors];

            for (int i = 0; i < array.Length; i++)
                result[array[i] - 1]++;

            return result;
        }
    }
}
