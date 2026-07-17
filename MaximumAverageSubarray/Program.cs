Console.WriteLine(new Solution().FindMaxAverage(new int[] { 1, 2, 3, 4, 5 }, 2));

public class Solution
{
	public double FindMaxAverage(int[] nums, int k)
	{
		var sum = 0;
		for (int i = 0; i < k; i++)
		{
			sum += nums[i];
		}

		var maxSum = sum;
		for (int i = k; i < nums.Length; i++)
		{
			sum += nums[i] - nums[i - k];
			if (sum > maxSum)
			{
				maxSum = sum;
			}
		}

		return maxSum;
	}
}