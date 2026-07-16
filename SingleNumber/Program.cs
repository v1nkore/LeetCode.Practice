Console.WriteLine(new Solution().SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

public class Solution
{
	public int SingleNumber(int[] nums)
	{
		var dictionary = new Dictionary<int, int>();
		foreach (var item in nums)
		{
			if (!dictionary.ContainsKey(item))
			{
				dictionary.Add(item, 1);
			}
			else
			{
				dictionary[item]++;
			}
		}

		return dictionary.FirstOrDefault(x => x.Value == 1).Key;
	}
}