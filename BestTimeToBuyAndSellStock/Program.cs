Console.WriteLine(new Solution().MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));

public class Solution
{
	public int MaxProfit(int[] prices)
	{
		int minPrice = int.MaxValue;
		int maxProfit = 0;

		foreach (int price in prices)
		{
			if (price < minPrice)
			{
				minPrice = price;
			}
			else if (price - minPrice > maxProfit)
			{
				maxProfit = price - minPrice;
			}
		}

		return maxProfit;
	}
}