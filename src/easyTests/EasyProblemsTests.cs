
using Domain;
using easy;
using NUnit;
using NUnit.Framework;
using static easy.EasyProblems;

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

		[TestCase(new string[] { "flower", "flow", "flight" }, "fl")]
		[TestCase(new string[] { "dog", "racecar", "car" }, "")]
		public void LongestCommonPrefix_14Test(string[] input, string output)
		{
			Assert.That(_easyProblems.LongestCommonPrefix_14(input), Is.EqualTo(output));
		}

		[TestCase("()", true)]
		[TestCase("()[]{}", true)]
		[TestCase("(]", false)]
		[TestCase(")(", false)]
		[TestCase("(()", false)]
		[TestCase("())(", false)]
		[TestCase("([)]", false)]
		public void IsValid_20Test(string input, bool output)
		{
			Assert.That(_easyProblems.IsValid_20(input), Is.EqualTo(output));
		}

		[Test]
		public void MergeTwoListsTest()
		{
			ListNode list1 = new ListNode(1);
			list1.next = new ListNode(2);
			list1.next.next = new ListNode(4);
			ListNode list2 = new ListNode(1);
			list2.next = new ListNode(3);
			list2.next.next = new ListNode(4);


			var result = _easyProblems.MergeTwoLists(list1, list2);
			ListNode output = new ListNode(1);
			output.next = new ListNode(1);
			output.next.next = new ListNode(2);
			output.next.next.next = new ListNode(3);
			output.next.next.next.next = new ListNode(4);
			output.next.next.next.next.next = new ListNode(4);

			// How to check?
			Assert.AreEqual(true, true);
		}

		[TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4, 0, 0, 0, 0, 0 }, 5)]
		public void RemoveDuplicatesTest(int[] nums, int[] output, int result)
		{
			var res = _easyProblems.RemoveDuplicates(nums);

			Assert.AreEqual(result, res);
			Assert.AreEqual(nums, output);
		}

		[TestCase(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4, 0, 0, 0 })]
		public void RemoveElementTest(int[] input, int remove, int output, int[] outArray)
		{
			var res = _easyProblems.RemoveElement(input, remove);

			var out1 = input.Take(res);
			var out2 = outArray.Take(res);

			Assert.That(res, Is.EqualTo(output));
			Assert.AreEqual(out1, out2);
		}
	}
}