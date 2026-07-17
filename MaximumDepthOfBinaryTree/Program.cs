using System.Xml;
using System.Xml.Linq;

var result = new Solution().MaxDepth(new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5)),
    new TreeNode(3)));
Console.WriteLine(result);

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
	public int MaxDepth(TreeNode node)
	{
		if (node is null) return 0;

		int leftDepth = MaxDepth(node.left);
		int rightDepth = MaxDepth(node.right);

		return 1 + Math.Max(leftDepth, rightDepth);
	}
}