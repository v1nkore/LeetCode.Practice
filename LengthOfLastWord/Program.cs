Console.WriteLine(new Solution().LengthOfLastWord("Hello World"));

public class Solution
{
	public int LengthOfLastWord(string s)
	{
		var wordStartIndex = -1;
		var current = 0;
		var isPreviousWhitespace = true;
		foreach (var item in s)
		{
			if (item != ' ')
			{
				if (wordStartIndex != current && isPreviousWhitespace)
				{
					wordStartIndex = current;
					isPreviousWhitespace = false;
				}
			}
			else
			{
				isPreviousWhitespace = true;
			}

			current++;
		}

		return s.Substring(wordStartIndex).TrimEnd().Length;
	}
}