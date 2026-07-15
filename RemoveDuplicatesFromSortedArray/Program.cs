Console.WriteLine(new Solution().RemoveDuplicates(new int[] { 1, 1, 2 }));

public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		if (nums is null || nums.Length == 0) return 0;

		var k = 0;
		var hashSet = new HashSet<int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (!hashSet.Contains(nums[i]))
			{
				hashSet.Add(nums[i]);
				k++;
			}
		}

		var index = 0;
		foreach (var num in hashSet)
		{
			nums[index++] = num;
		}

		return k;
	}
}