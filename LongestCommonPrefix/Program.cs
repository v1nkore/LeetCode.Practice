using System.Text;
Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{
		if (strs.Length == 0) return string.Empty;
		if (strs.Length == 1) return strs[0];

		var minLength = strs.MinBy(x => x.Length).Length;
		var stringBuilder = new StringBuilder();
		for (int i = 0; i < minLength; i++)
		{
			var currentChar = strs[0][i];
			if (strs.All(x => x[i] == currentChar))
			{
				stringBuilder.Append(strs[0][i]);
			}
			else break;
		}

		return stringBuilder.ToString();
	}
}