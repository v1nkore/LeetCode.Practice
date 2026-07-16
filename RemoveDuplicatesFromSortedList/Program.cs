Console.WriteLine(new Solution().DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2)))));

 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

public class Solution
{
	public ListNode DeleteDuplicates(ListNode head)
	{
		var dummy = new ListNode();
		var tail = dummy;
		var seen = new HashSet<int>();

		while (head is not null)
		{
			if (seen.Add(head.val))
			{
				tail.next = head;
				tail = head;
			}
			head = head.next;
		}

		tail.next = null;

		return dummy.next;
	}
}