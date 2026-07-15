using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var result = new Solution().MergeTwoLists(list1, list2);

Console.WriteLine();
Console.WriteLine($"ИТОГ: {Fmt.Chain(result)}");

public static class Fmt
{
	// Печатает цепочку узлов начиная с n: "1 → 2 → 4", для null — "∅"
	public static string Chain(ListNode n)
	{
		if (n is null) return "∅";
		var sb = new StringBuilder();
		while (n is not null)
		{
			sb.Append(n.val);
			if (n.next is not null) sb.Append(" → ");
			n = n.next;
		}
		return sb.ToString();
	}

	// Печатает только СШИТУЮ часть результата: от dummy.next до tail включительно.
	// Обычный Chain тут не годится: tail.next ещё указывает в исходный список,
	// и распечатался бы «лишний» хвост, который мы пока не пристёгивали.
	public static string Merged(ListNode dummy, ListNode tail)
	{
		if (dummy == tail) return "(пусто)";
		var sb = new StringBuilder("dummy → ");
		var n = dummy.next;
		while (true)
		{
			sb.Append(n.val);
			if (n == tail) break;
			sb.Append(" → ");
			n = n.next;
		}
		return sb.ToString();
	}
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}

public class Solution
{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		Console.WriteLine($"СТАРТ:  list1 = [{Fmt.Chain(list1)}]   list2 = [{Fmt.Chain(list2)}]");

		var dummy = new ListNode();
		var tail = dummy;
		Console.WriteLine("Создали dummy-вешалку; tail = dummy (tail всегда смотрит на последний сшитый узел)");

		string TailName() => tail == dummy ? "dummy" : $"узел({tail.val})";

		int step = 0;
		while (list1 is not null && list2 is not null)
		{
			step++;
			Console.WriteLine();
			Console.WriteLine($"─── Шаг {step}: сравниваем list1.val={list1.val} и list2.val={list2.val} ───");

			if (list1.val <= list2.val)
			{
				Console.WriteLine($"  {list1.val} <= {list2.val} → берём узел ({list1.val}) из list1");

				tail.next = list1;
				Console.WriteLine($"  tail.next = list1;    // {TailName()}.next теперь указывает на узел ({list1.val})");
				Console.WriteLine($"                        // сам list1 НЕ изменился: [{Fmt.Chain(list1)}]");

				list1 = list1.next;
				Console.WriteLine($"  list1 = list1.next;   // переменная list1 уехала вперёд: [{Fmt.Chain(list1)}]");
				Console.WriteLine($"                        // а tail.next как указывал на узел ({tail.next.val}), так и указывает");
			}
			else
			{
				Console.WriteLine($"  {list1.val} >  {list2.val} → берём узел ({list2.val}) из list2");

				tail.next = list2;
				Console.WriteLine($"  tail.next = list2;    // {TailName()}.next теперь указывает на узел ({list2.val})");
				Console.WriteLine($"                        // сам list2 НЕ изменился: [{Fmt.Chain(list2)}]");

				list2 = list2.next;
				Console.WriteLine($"  list2 = list2.next;   // переменная list2 уехала вперёд: [{Fmt.Chain(list2)}]");
				Console.WriteLine($"                        // а tail.next как указывал на узел ({tail.next.val}), так и указывает");
			}

			tail = tail.next;
			Console.WriteLine($"  tail = tail.next;     // tail сдвинулся на только что пристёгнутый узел ({tail.val})");

			Console.WriteLine($"  Сшито:      {Fmt.Merged(dummy, tail)}");
			Console.WriteLine($"  Осталось:   list1 = [{Fmt.Chain(list1)}]   list2 = [{Fmt.Chain(list2)}]");
			Console.WriteLine($"  (tail.next сейчас → [{Fmt.Chain(tail.next)}] — старый хвост исходного списка;");
			Console.WriteLine($"   он будет перезаписан на следующем шаге или строкой после цикла)");
		}

		Console.WriteLine();
		Console.WriteLine($"Цикл кончился: один из списков пуст. list1 = [{Fmt.Chain(list1)}], list2 = [{Fmt.Chain(list2)}]");

		tail.next = list1 ?? list2;
		Console.WriteLine($"tail.next = list1 ?? list2;   // пристегнули остаток целиком: [{Fmt.Chain(tail.next)}]");
		Console.WriteLine($"Возвращаем dummy.next — настоящую голову: [{Fmt.Chain(dummy.next)}]");

		return dummy.next;
	}
}