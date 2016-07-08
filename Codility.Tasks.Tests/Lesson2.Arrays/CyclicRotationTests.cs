using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Tasks.Lesson2.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson2.Arrays.Tests
{
    [TestClass]
    public class RotationTests
    {
        [TestMethod]
        public void solutionTest()
        {
            var sut = new CyclicRotation();
            var input = new int[] { 3, 8, 9, 7, 6 };
            var expected = new int[] { 9, 7, 6, 3, 8 };
            var actual = sut.solution(input, 3);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}