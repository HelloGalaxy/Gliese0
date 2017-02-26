using System;
using System.Text;
using Gliese0.Leetcode;

namespace Gliese0
{
    class Program
    {
        static void Main(string[] args)
        {
            var q7 = new Q7_ReverseInteger();
            var input = 1563847412;
            Console.Write(string.Format("input {0} the get  {1}", input, q7.Reverse(input)));
            //var question = new Q2_Add2Nums();

            //var l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //PrintArray(question.AddTwoNumbers(l1, l2));
            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
        }

        static void PrintArray(ListNode node)
        {
            var builder = new StringBuilder();
            while (node != null)
            {
                builder.Append(node.val + " ");
                node = node.next;
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
