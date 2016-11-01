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
    public class PermMissingElemTests
    {
        PermMissingElem sut = new PermMissingElem();

        [TestMethod]
        public void solutionTest()
        {
            var input = new int[] { 2, 3, 1, 5 };
            var actual = sut.solution(input);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void solution_SingleElement_Test()
        {
            var input = new int[] { 2 };
            var actual = sut.solution(input);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void solution_MaximumN_Test()
        {
            var input = Enumerable.Range(2, 100000 - 1).ToArray();
            var actual = sut.solution(input);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}