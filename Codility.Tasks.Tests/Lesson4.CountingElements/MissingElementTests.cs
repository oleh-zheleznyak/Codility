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
	public class MissingElementTests
	{
		private readonly MissingElement sut = new MissingElement();

		[TestMethod]
		public void solutionTest()
		{
			Scenario(new int[] { 1, 3, 6, 4, 1, 2 }, 5);
		}

		[TestMethod]
		public void solution_intMaxValue()
		{
			Scenario(new int[] { int.MaxValue }, 1);
		}

		[TestMethod]
		public void solution_intMinValue()
		{
			Scenario(new int[] { int.MinValue }, 1);
		}

		[TestMethod]
		public void solution_intMiniMax()
		{
			Scenario(new int[] { int.MinValue, int.MaxValue }, 1);
		}

		[TestMethod]
		public void solution_Zero()
		{
			Scenario(new int[] { 0 }, 1);
		}

		[TestMethod]
		public void solution_ZeroAndMax()
		{
			Scenario(new int[] { 0, int.MaxValue }, 1);
		}


		[TestMethod]
		public void solution_OneAndMax()
		{
			Scenario(new int[] { 1, int.MaxValue }, 2);
		}

		[TestMethod]
		public void solution_SomeNumbersBiggerThanOne()
		{
			Scenario(new int[] { 2, 3, 4, 5, 6 }, 1);
		}

		[TestMethod]
		public void solution_SingleRepeatedNumber()
		{
			Scenario(Enumerable.Repeat(42, 10).ToArray(), 1);
		}

		[TestMethod]
		public void solution_RangeOfNumbers_ShouldReturnNextNumber()
		{
			Scenario(Enumerable.Range(-100, 200).ToArray(), 100);
		}

		[TestMethod]
		public void solution_RangeWithGap_ShouldDetectGap()
		{
			Scenario(Enumerable.Range(-100, 200).Except(new[] { 42 }).ToArray(), 42);
		}

		private void Scenario(int[] input, int expected)
		{
			var actual = sut.solution(input);
			Assert.AreEqual(expected, actual);
		}
	}
}