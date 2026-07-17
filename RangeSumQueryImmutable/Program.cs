Console.WriteLine(new NumArray(new int[] { 1, 3, 5, 7, 9 }).SumRange(0, 4));

public class NumArray
{
	private int[] _nums;

	public NumArray(int[] nums)
	{
		_nums = nums;
	}

	public int SumRange(int left, int right)
	{
		return _nums.Skip(left).Take(right - left + 1).Sum();
	}
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */