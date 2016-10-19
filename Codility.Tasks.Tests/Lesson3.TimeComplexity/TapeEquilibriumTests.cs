using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Tasks.Lesson3.TimeComplexity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson3.TimeComplexity.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        private TapeEquilibrium sut = new TapeEquilibrium();

        [TestMethod]
        public void solutionTest()
        {
            var input = new int[] { 3, 1, 2, 4, 3 };
            var expected = 1;
            var actual = sut.solution(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void solution_CanPickFirstElement()
        {
            var input = new int[] { 10, 3, 3, 3 };
            var expected = 1;
            var actual = sut.solution(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void solution_CanPickLastElement()
        {
            var input = new int[] { 3, 3, 3, 10 };
            var expected = 1;
            var actual = sut.solution(input);

            Assert.AreEqual(expected, actual);
        }
    }
}