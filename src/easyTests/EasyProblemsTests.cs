
using easy;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit;
using NUnit.Framework;

namespace easyTests
{	
	[TestFixture]
	public class EasyProblemsTests
	{
		private EasyProblems _easyProblems = new();
		[OneTimeSetUp]
		public void Setup()
		{

		}
		[TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
		[TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
		[TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
		[TestCase(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 })]

		public void TwoSum_1Test(int[] nums, int target, int[] output)
		{
			Assert.That(_easyProblems.TwoSum_1(nums, target), Is.EquivalentTo(output));
		}

		[TestCase(121, true)]
		[TestCase(-121, false)]
		[TestCase(10, false)]
		[TestCase(1001, true)]
		public void IsPalindrome_9Test(int input, bool output)
		{
			Assert.That(_easyProblems.IsPalindrome_9(input), Is.EqualTo(output));
		}
	}
}