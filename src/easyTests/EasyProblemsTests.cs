using easy;
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
	}
}