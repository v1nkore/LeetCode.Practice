Console.WriteLine(new Solution().IsValid("()"));

public class Solution
{
	private static Dictionary<char, char> Parentheses = new() {
		{'(', ')'},
		{'{', '}'},
		{'[', ']'}
	};

	public bool IsValid(string s)
	{
		var openingParentheses = new Stack<char>();
		for (int i = 0; i < s.Length; i++)
		{
			var current = s[i];
			if (Parentheses.ContainsKey(current))
			{
				openingParentheses.Push(current);
			}

			else
			{
				if (openingParentheses.Count == 0) return false;
				var lastOpeningBracket = openingParentheses.Pop();
				if (Parentheses.TryGetValue(lastOpeningBracket, out var closingBracket) && closingBracket.Equals(current))
				{
					continue;
				}

				return false;
			}
		}

		return openingParentheses.Count == 0;
	}
}