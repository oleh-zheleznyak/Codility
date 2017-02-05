using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Tasks.Lesson4.CountingElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tasks.Lesson4.CountingElements.Tests
{
	[TestClass]
	public class FrogRiverOneTests
	{
		private FrogRiverOne frogRiverOne = new FrogRiverOne();

		[TestMethod]
		public void solutionTest()
		{
			var timePositionArray = new[] { 1, 3, 1, 4, 2, 3, 5, 4 };
			var expected = 6;
			var distance = 5;
			var actual = frogRiverOne.solution(distance, timePositionArray);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ShouldReturn_MinusOne_WhenTimeArrayIsShorterThanDistance()
		{
			var timePositionArray = new[] { 1 };
			var distance = 2;
			var actual = frogRiverOne.solution(distance, timePositionArray);

			Assert.AreEqual(FrogRiverOne.No_Solution, actual);
		}

		[TestMethod]
		public void ShouldReturn_MinusOne_WhenAPositionInArrayWasNotCovered()
		{
			var timePositionArray = new[] { 1, 1, 1, 1 };
			var distance = 2;
			var actual = frogRiverOne.solution(distance, timePositionArray);

			Assert.AreEqual(FrogRiverOne.No_Solution, actual);
		}

		[TestMethod]
		public void ShouldReturn_EarliestTime_WhenPositionsAreCoveredSeveralTimes()
		{
			var timePositionArray = new[] { 1, 2, 1, 2 };
			var distance = 2;
			var earliestMoment = 1;
			var actual = frogRiverOne.solution(distance, timePositionArray);

			Assert.AreEqual(earliestMoment, actual);
		}

		[TestMethod]
		public void ShouldReturn_EarliestTime_GivenMaximumSequence()
		{
			var distance = 100000;
			var timePositionArray = Enumerable.Range(1, distance).ToArray();

			var earliestMoment = distance;
			var actual = frogRiverOne.solution(distance, timePositionArray);

			Assert.AreEqual(distance - 1, actual);
		}
	}
}