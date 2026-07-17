Console.WriteLine(new Solution().Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
Console.WriteLine(new Solution().Search(new int[] { -1, 0, 3, 5, 9, 12 }, -2));
Console.WriteLine(new Solution().Search(new int[] { -1, 0, 3, 5, 9, 12 }, 13));
Console.WriteLine(new Solution().Search(new int[] { -1, 0, 3, 5, 9, 12 }, 4));
Console.ReadLine();

public class Solution
{
	public int Search(int[] nums, int target)
	{
		var left = 0;
		var right = nums.Length - 1;
		while (left < right)
		{
			var mid = left + (right - left) / 2;
			if (nums[mid] == target) return mid;
			if (nums[mid] < target)
			{
				left = mid + 1;
			}
			else
			{
				right = mid;
			}
		}

		return nums[left] == target ? left : -1;
	}
}