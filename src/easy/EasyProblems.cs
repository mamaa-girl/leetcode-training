using Domain;
using System.Text;

namespace easy
{
	public class EasyProblems
	{
		// https://leetcode.com/problems/two-sum/
		public int[] TwoSum_1(int[] nums, int target)
		{
			for (var i = 0; i < nums.Length - 1; i++)
			{
				for (var j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return new int[] { i, j };
					}
				}
			}
			return new int[] { 0, 0 };
		}

		// https://leetcode.com/problems/palindrome-number/
		public bool IsPalindrome_9(int x)
		{
			if (x < 0)
			{
				return false;
			}

			var number = x.ToString();

			var length = number.Length - 1;
			for (var i = 0; i < length / 2.0; i++)
			{
				if (number[i] != number[length - i])
				{
					return false;
				}
			}
			return true;
		}

		// https://leetcode.com/problems/longest-common-prefix/
		public string LongestCommonPrefix_14(string[] strs)
		{
			StringBuilder ss = new StringBuilder();

			var shortest = strs.Min(x => x.Length);

			for (var i = 0; i < shortest; i++)
			{
				var current = strs[0][i];
				foreach (var str in strs)
				{
					if (str[i] != current)
					{
						return ss.ToString();
					}
				}
				ss.Append(current);
			}

			return ss.ToString();

		}

		// https://leetcode.com/problems/valid-parentheses/
		public bool IsValid_20(string s)
		{
			Stack<char> stack = new Stack<char>();

			foreach (var c in s)
			{
				if (stack.Any())
				{
					var top = stack.Pop();
					if (top is '(')
					{
						if (c == ')')
						{

						}
						else if (c == ']' || c == '}')
						{
							return false;
						}
						else
						{
							stack.Push(top);
							stack.Push(c);
						}
					}
					else if (top is '[')
					{
						if (c == ']')
						{

						}
						else if (c == ')' || c == '}')
						{
							return false;
						}
						else
						{
							stack.Push(top);
							stack.Push(c);
						}
					}
					else if (top is '{')
					{
						if (c == '}')
						{

						}
						else if (c == ']' || c == ')')
						{
							return false;
						}
						else
						{
							stack.Push(top);
							stack.Push(c);
						}
					}
					else
					{
						stack.Push(top);
					}
				}
				else
				{
					stack.Push(c);
				}
			}

			return !stack.Any();

		}

		// https://leetcode.com/problems/merge-two-sorted-lists/
		public ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			var temp = new ListNode(0);
			var result = temp;

			while (list1 != null && list2 != null)
			{
				if (list1 != null && list2 != null)
				{
					if (list1.val <= list2.val)
					{
						temp.next = new ListNode(list1.val);
						list1 = list1.next;
					}
					else
					{
						temp.next = new ListNode(list2.val);
						list2 = list2.next;
					}
				}
				else if (list1 != null)
				{
					temp.next = new ListNode(list1.val);
					list1 = list1.next;
				}
				else if (list2 != null)
				{

					temp.next = new ListNode(list2.val);
					list2 = list2.next;
				}
				temp = temp.next;
			}
			return result.next;
		}

		// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
		public int RemoveDuplicates(int[] nums)
		{
			var unique = nums.Distinct().ToArray();
			var count = unique.Count();

			for (var i = 0; i < nums.Length; i++)
			{
				if (i < count)
				{
					nums[i] = unique[i];
				}
				else
				{
					nums[i] = 0;
				}
			}

			return count;
		}

		// https://leetcode.com/problems/remove-element/
		public int RemoveElement(int[] nums, int val)
		{
			var result = 0;
			var currentLocation = 0;

			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] == val)
				{
					continue;
				}
				result++;
				nums[currentLocation] = nums[i];
				currentLocation++;
			}

			return result;
		}


		// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
		public int StrStr(string haystack, string needle)
		{
			var result = haystack.IndexOf(needle);

			return result;
		}

		// https://leetcode.com/problems/search-insert-position/
		/// <summary>
		///		Not O(log n) should be using bubble search to find ...
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public int SearchInsert(int[] nums, int target)
		{
			if (nums.Length == 0)
			{
				return 0;
			}
			if (nums[0] > target)
			{
				return 0;
			}
			for (var i = 0; i < nums.Length; ++i)
			{
				if (nums[i] == target)
					return i;
				else if ((i - 1) >= 0 && nums[i - 1] < target && target < nums[i])
				{
					return i;
				}
			}
			return nums.Length;
		}
	}
}