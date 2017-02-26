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
            ListNode result = null;
            ListNode indicator = result;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var sum = 0;
                if (l1 != null && l2 == null)
                {
                    sum = l1.val + carry;
                }
                else if (l1 == null && l2 != null)
                {
                    sum = l2.val + carry;
                }
                else
                {
                    sum = l1.val + l2.val + carry;
                }

                if (sum > 9)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }
                else
                {
                    carry = 0;
                }

                var tmp = new ListNode(sum);
                if (result != null)
                {
                    indicator.next = tmp;
                    indicator = indicator.next;
                }
                else
                {
                    result = tmp;
                    indicator = result;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
            {
                var tmp = new ListNode(carry);
                if (result != null)
                {
                    indicator.next = tmp;
                }
                else
                {
                    result = tmp;
                }
            }

            return result;
        }

        //	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //	{
        //		ListNode result = RecusiveAddTwoNumbers(l1, l2);
        //		return result;

        //	}

        //	ListNode RecusiveAddTwoNumbers(ListNode l1, ListNode l2)
        //	{
        //		if (l1.next == null && l2.next == null)
        //		{
        //			var result = new ListNode(l1.val + l2.val);
        //			return result;
        //		}
        //		else
        //		{
        //			var current = new ListNode(l1.val + l2.val);
        //			var previous = RecusiveAddTwoNumbers(l1.next, l2.next);
        //			var last = GetLast(previous);
        //			if (last.val >= 10)
        //			{
        //				current.val += last.val / 10;
        //				last.val = last.val % 10;
        //			}
        //			last.next = current;
        //			return previous;
        //		}
        //	}

        //	ListNode GetLast(ListNode l)
        //	{
        //		var iterator = l;
        //		while (iterator.next != null) iterator = iterator.next;
        //		return iterator;
        //	}
        //}
    }
}
