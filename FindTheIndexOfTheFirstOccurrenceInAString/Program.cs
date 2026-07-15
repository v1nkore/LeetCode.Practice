Console.WriteLine(new Solution().StrStr("sadbutsad", "sad"));

public class Solution
{
	public int StrStr(string haystack, string needle)
	{
		for (int i = 0; i < haystack.Length; i++)
		{
			if (haystack[i] == needle[0] && haystack.Length - i - needle.Length >= 0)
			{
				if (haystack.Substring(i, needle.Length) == needle)
				{
					return i;
				}
			}
		}

		return -1;
	}
}