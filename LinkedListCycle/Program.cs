// Список с циклом: 3 -> 2 -> 0 -> -4 -> (обратно на узел "2")
var node1 = new ListNode(3);
var node2 = new ListNode(2);
var node3 = new ListNode(0);
var node4 = new ListNode(-4);

node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node2; // цикл: последний узел указывает обратно на node2

Console.WriteLine(new Solution().HasCycle(node1)); // true

// Список без цикла: 1 -> 2 -> 3 -> null
var a = new ListNode(1);
var b = new ListNode(2);
var c = new ListNode(3);

a.next = b;
b.next = c;
c.next = null;

Console.WriteLine(new Solution().HasCycle(a)); // false

// Пустой список
Console.WriteLine(new Solution().HasCycle(null)); // false

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x)
	{
		val = x;
		next = null;
	}
}

public class Solution
{
	public bool HasCycle(ListNode head)
	{
		var hashSet = new HashSet<ListNode>();
		while (head is not null)
		{
			hashSet.Add(head);
			if (head.next is not null)
			{
				if (hashSet.Contains(head.next))
				{
					return true;
				}
			}

			head = head.next;
		}

		return false;
	}
}