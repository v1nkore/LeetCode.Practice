using System.Numerics;

Console.WriteLine(string.Join(", ", new Solution().PlusOne(new int[] { 1, 2, 3 })));

public class Solution
{
	public int[] PlusOne(int[] digits)
	{
		var str = string.Join("", digits.Select(x => x.ToString()));
		var value = BigInteger.Parse(str);
		value++;

		return value
			.ToString()
			.ToArray()
			.Select(x => int.Parse(x.ToString()))
			.ToArray();
	}
}