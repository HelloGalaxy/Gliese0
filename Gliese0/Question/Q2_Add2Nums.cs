using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gliese0.Question
{

	//Definition for singly-linked list.
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}


	/*
	 * You are given two linked lists representing two non-negative numbers.
	 * The digits are stored in reverse order and each of their nodes contain a single digit. 
	 * Add the two numbers and return it as a linked list.
	 * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
	 * Output: 7 -> 0 -> 8
	 */
	public class Q2_Add2Nums
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode result = RecusiveAddTwoNumbers(l1, l2);
			return result;

		}

		ListNode RecusiveAddTwoNumbers(ListNode l1, ListNode l2)
		{
			if (l1.next == null && l2.next == null)
			{
				var result = new ListNode(l1.val + l2.val);
				return result;
			}
			else
			{
				var current = new ListNode(l1.val + l2.val);
				var previous = RecusiveAddTwoNumbers(l1.next, l2.next);
				var last = GetLast(previous);
				if (last.val >= 10)
				{
					current.val += last.val / 10;
					last.val = last.val % 10;
				}
				last.next = current;
				return previous;
			}
		}

		ListNode GetLast(ListNode l)
		{
			var iterator = l;
			while (iterator.next != null) iterator = iterator.next;
			return iterator;
		}
	}
}
