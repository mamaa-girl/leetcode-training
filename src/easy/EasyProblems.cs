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
	}
}