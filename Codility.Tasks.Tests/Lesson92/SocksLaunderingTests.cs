using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Tasks.Lesson92;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson92.Tests
{
    [TestClass]
    public class SocksLaunderingTests
    {
        private SocksLaundering sut = new SocksLaundering();

        [TestMethod]
        public void ShouldReturnCountOfClean_GivenNoSpaceInLaundry()
        {
            Scenario(new int[] { 1, 1, 2 }, new int[] { 2 }, 0, 1);
        }

        [TestMethod]
        public void ShouldPairCleanWithDirty_GivenValidPairs()
        {
            Scenario(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 }, 2, 2);
        }

        [TestMethod]
        public void ShouldReturnSum_GivenLotsOfSpaceInLaundry()
        {
            Scenario(new int[] { 1, 1, 2, 3, 4, 4 }, new int[] { 2, 3, 5, 5 }, 100, 5);
        }

        [TestMethod]
        public void ShouldReturnCorrectNumber_GivenAllEvenPairsAndSufficientCapacity()
        {
            Scenario(new int[] { 1, 1, 2, 2 }, new int[] { 2, 2, 3, 3 }, 4, 4);
        }

        [TestMethod]
        public void ShouldReturnCorrectNumber_GivenAllEvenPairsAndInSufficientCapacity()
        {
            Scenario(new int[] { 1, 1, 2, 2 }, new int[] { 2, 2, 3, 3 }, 3, 3);
        }

        [TestMethod]
        public void ShouldNotCrash_GivenMaxColor()
        {
            Scenario(new int[] { SocksLaundering.MaxColors }, new int[] { SocksLaundering.MaxColors }, 1, 1);
        }

        [TestMethod]
        public void ShouldFillAllLaundryCapacity_GivenHugeCapacity()
        {
            Scenario(new int[] { 1 }, new int[] { 1, 2, 2, 3, 3, 3, 3 }, int.MaxValue, 4);
        }

        private void Scenario(int[] cleanSocks, int[] dirtySocks, int laundryCapacity, int expected)
        {
            var actual = sut.solution(laundryCapacity, cleanSocks, dirtySocks);

            Assert.AreEqual(expected, actual);
        }
    }
}