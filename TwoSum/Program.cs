var nums = new int[] { 2, 7, 11, 15 };
var target = 9;
Console.WriteLine(string.Join(", ", new Solution().TwoSum(nums, target)));

public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		if (nums.Length < 2)
		{
			return [];
		}
		var previous = new Dictionary<int, int>();
		previous.Add(nums[0], 0);
		for (int i = 1; i < nums.Length; i++)
		{
			if (previous.TryGetValue(target - nums[i], out int j))
			{
				return [j, i];
			}

			previous.TryAdd(nums[i], i);
		}

		return [];
	}
}