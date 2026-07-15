Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
public class Solution
{
	public int SearchInsert(int[] nums, int target)
	{
		int left = 0, right = nums.Length - 1;
		while (left <= right)
		{
			int mid = left + (right - left) / 2;
			if (nums[mid] == target) return mid;
			if (nums[mid] < target) left = mid + 1;
			else right = mid - 1;
		}
		return left;
	}
}