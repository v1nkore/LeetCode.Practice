Console.WriteLine(new Solution().ContainsDuplicate(new int[] { 1, 2, 3, 4, 5 }));

public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		var hashSet = new HashSet<int>();
		foreach (var item in nums)
		{
			if (!hashSet.Contains(item))
			{
				hashSet.Add(item);
			}
			else return true;
		}

		return false;
	}
}