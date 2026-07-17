new Solution().Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

public class Solution
{
	public void Merge(int[] nums1, int m, int[] nums2, int n)
	{
		var k = 0;
		for (int i = m; i < nums1.Length; i++)
		{
			if (nums1[i] == 0)
			{
				nums1[i] = nums2[k++];
			}
		}

		Array.Sort(nums1);
	}
}