Console.WriteLine(new Solution().RemoveElement(new int[] { 3, 2, 2, 3 }, 3));

public class Solution
{
	public int RemoveElement(int[] nums, int val)
	{
		var k = 0;
		foreach (var item in nums)
		{
			if (item != val)
			{
				nums[k++] = item;
			}
		}

		return k;
	}
}