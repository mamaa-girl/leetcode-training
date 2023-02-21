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
	}
}