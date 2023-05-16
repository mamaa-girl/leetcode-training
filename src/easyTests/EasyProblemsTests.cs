
using Domain;
using easy;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit;
using NUnit.Framework;
using System;
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

		// Arrange
		[TestCase("sadbutsad", "sad", 0)]
		[TestCase("leetcode", "leeto", -1)]
		public void StrStrTest(string haystack, string needle, int index)
		{
			// Act
			var result = _easyProblems.StrStr(haystack, needle);

			// Assert
			Assert.That(result, Is.EqualTo(index));
		}

		[TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
		[TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
		[TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
		[TestCase(new int[] { 1, 3, 5, 6 }, 0, 0)]
		public void SearchInsertTest(int[] nums, int target, int output)
		{
			var result = _easyProblems.SearchInsert(nums, target);

			Assert.That(result, Is.EqualTo(output));
		}

		[TestCase("Hello World", 5)]
		[TestCase("   fly me   to   the moon  ", 4)]
		public void LengthOfLastWordTest(string input, int output)
		{
			var result = _easyProblems.LengthOfLastWord(input);

			Assert.That(result, Is.EqualTo(output));
		}

		[TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
		[TestCase(new int[] { 9 }, new int[] { 1, 0 })]
		[TestCase(new int[] { 9, 9, 9, 9 }, new int[] { 1, 0, 0, 0, 0 })]
		[TestCase(new int[] { 0 }, new int[] { 1 })]
		public void PlustOneTest(int[] input, int[] output)
		{
			var result = _easyProblems.PlusOne(input);

			Assert.AreEqual(result, output);
		}

		[TestCase("11", "1", "100")]
		[TestCase("1010", "1011", "10101")]
		[TestCase("1111", "1111", "11110")]
		public void AddBinaryTest(string input1, string input2, string output)
		{
			var result = _easyProblems.AddBinary(input1, input2);

			Assert.That(result, Is.EqualTo(output));
		}

		[TestCase(4, 2)]
		[TestCase(8, 2)]
		[TestCase(49, 7)]
		[TestCase(51, 7)]
		public void MySqrtTest(int x, int output)
		{
			var result = _easyProblems.MySqrt(x);

			Assert.That(result, Is.EqualTo(output));
		}

		[Test]
		public void DeleteDuplicatesTest()
		{
			var head1 = new ListNode(1);
			head1.next = new ListNode(1);
			head1.next.next = new ListNode(2);
			var result2 = _easyProblems.DeleteDuplicates(head1);

			var head2 = new ListNode(1);
			head2.next = new ListNode(2);
			head2.next.next = new ListNode(2);
			head2.next.next.next = new ListNode(3);
			head2.next.next.next = new ListNode(3);

			var result3 = _easyProblems.DeleteDuplicates(head2);

			Assert.That(true, Is.EqualTo(true));
		}
	}
}