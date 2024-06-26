﻿using Domain;
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

		// https://leetcode.com/problems/length-of-last-word/
		public int LengthOfLastWord(string s)
		{
			return s.Trim().Split(' ').Last().Length;

		}

		// https://leetcode.com/problems/plus-one/
		public int[] PlusOne(int[] digits)
		{
			List<int> result = new();
			var remainder = 1;
			for (var i = digits.Length - 1; i >= 0; --i)
			{
				var current = digits[i] + remainder;

				if (current == 10)
				{
					current = 0;
					remainder = 1;
				}
				else
				{
					remainder = 0;
				}

				result.Add(current);
			}
			if (remainder == 1)
			{
				result.Add(remainder);
			}

			result.Reverse();
			return result.ToArray();
		}

		// https://leetcode.com/problems/add-binary/
		public string AddBinary(string a, string b)
		{
			StringBuilder result = new StringBuilder();

			var max = Math.Max(a.Length, b.Length);

			a = a.PadLeft(max, '0');
			b = b.PadLeft(max, '0');

			int sum = 0;

			for (var i = max - 1; i >= 0; --i)
			{
				sum += int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());

				if (sum >= 2)
				{
					result.Insert(0, sum % 2);
					sum = 1;
				}
				else
				{
					result.Insert(0, sum);
					sum = 0;
				}
			}

			// For any remainder
			if (sum > 0)
			{
				result.Insert(0, sum);
			}

			return result.ToString();
		}

		// https://leetcode.com/problems/sqrtx/
		public int MySqrt(int x)
		{
			return (int)Math.Floor(Math.Sqrt(x));
		}

		// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
		public ListNode DeleteDuplicates(ListNode head)
		{

			if (head == null || head.next == null)
			{
				return head;
			}

			var current = head.val;
			var result = new ListNode(current);
			var temp = result;

			while (head.next != null)
			{
				if (head.next.val != current)
				{
					current = head.next.val;
					result.next = new ListNode(current);
					result = result.next;
				}
				head = head.next;

			}

			return temp;
		}

		// https://leetcode.com/problems/merge-sorted-array/description/
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			var x = nums1.Take(m);
			var y = nums2.Take(n);
			var z = x.Concat(y).OrderBy(x => x).ToArray();
			for (var i = 0; i < z.Length; i++)
			{
				nums1[i] = z[i];
			}
		}


		// https://leetcode.com/problems/merge-sorted-array/		
		public void MergeSortedArray(int[] num1, int m, int[] num2, int n)
		{
			var x = num1.Take(m);
			var y = num2.Take(n);
			var z = x.Concat(y).OrderBy(x => x).ToArray();
			for (var i = 0; i < z.Length; i++)
			{
				num1[i] = z[i];
			}
		}

		// https://leetcode.com/problems/maximum-depth-of-binary-tree/
		public int MaxDepth(TreeNode node)
		{
			return MaxDepthRecursion(node, 0);
		}

		private int MaxDepthRecursion(TreeNode node, int depth)
		{
			if (node == null)
			{
				return depth;
			}

			return Math.Max(MaxDepthRecursion(node.left, depth + 1), MaxDepthRecursion(node.right, depth + 1));
		}

		// https://leetcode.com/problems/symmetric-tree/
		public bool IsSymmetric(TreeNode root)
		{
			var left = IsSymmetricRecurse(root.left, true);
			var right = IsSymmetricRecurse(root.right, false);

			return left == right;
		}

		private string? IsSymmetricRecurse(TreeNode node, bool inverse)
		{
			if (node == null)
			{
				return "n";
			}
			return node.val.ToString() + (inverse ? (IsSymmetricRecurse(node.right, inverse) + IsSymmetricRecurse(node.left, inverse)) : (IsSymmetricRecurse(node.left, inverse) + IsSymmetricRecurse(node.right, inverse)));
		}
	}
}