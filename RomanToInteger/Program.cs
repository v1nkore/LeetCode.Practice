Console.WriteLine(new Solution().RomanToInt("MCMXCIV"));

public class Solution
{
	private static Dictionary<char, int> RomanNumerals = new Dictionary<char, int>
	{
		{ 'I', 1 },
		{ 'V', 5 },
		{ 'X', 10 },
		{ 'L', 50 },
		{ 'C', 100 },
		{ 'D', 500 },
		{ 'M', 1000 }
	};

	public int RomanToInt(string s)
	{
		if (s.Length == 0) return 0;
		if (s.Length == 1) return RomanNumerals[s[0]];

		var value = 0;
		for (int i = 0; i < s.Length - 1; i++)
		{
			var current = RomanNumerals[s[i]];
			var next = RomanNumerals[s[i + 1]];

			if (next <= current)
			{
				value += current;
			}
			else
			{
				value -= current;
			}
		}

		value += RomanNumerals[s[s.Length - 1]];

		return value;
	}
}