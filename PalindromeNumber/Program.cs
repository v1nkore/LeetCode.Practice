Console.WriteLine(new Solution().IsPalindrome(121));

public class Solution
{
	public bool IsPalindrome(int x)
	{
		var numAsStr = x.ToString();
		if (numAsStr.Length == 1) return true;

		var left = 0;
		var right = numAsStr.Length - 1;
		while (left < right)
		{
			if (numAsStr[left] != numAsStr[right])
			{
				return false;
			}

			left++;
			right--;
		}

		return true;
	}
}