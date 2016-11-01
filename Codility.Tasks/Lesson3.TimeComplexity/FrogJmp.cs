using System;

namespace Codility.Tasks.Lesson3.TimeComplexity
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((Y - X) / (double)D);
        }
    }
}
