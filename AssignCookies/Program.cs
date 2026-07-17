Console.WriteLine(new Solution().FindContentChildren(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }));

public class Solution
{
	public int FindContentChildren(int[] g, int[] s)
	{
		g.Sort();
		s.Sort();

		var j = 0;
		var result = 0;
		for (int i = 0; i < s.Length && j < g.Length; i++)
		{
			if (s[i] >= g[j])
			{
				j++;
				result++;
			}
		}

		return result;
	}
}