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
    public class OddOccurrencesInArrayTests
    {
        private OddOccurrencesInArray sut = new OddOccurrencesInArray();

        [TestMethod]
        public void solutionTest()
        {
            var A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            var expected = 7;
            var actual = sut.solution(A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void solution_ShouldFindCorrectElement_WhenItIsTheMaximum()
        {
            var A = new int[] { 1, 3, 1, 3, 5 };
            var expected = 5;
            var actual = sut.solution(A);

            Assert.AreEqual(expected, actual);
        }
    }
}