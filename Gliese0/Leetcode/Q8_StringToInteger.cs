using System;
using System.Collections.Generic;

namespace Gliese0.Leetcode
{
    /*
    Implement atoi to convert a string to an integer.

    Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.

    Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.
    */

    internal class Q8_StringToInteger
    {
        private char[] headChars = { ' ', '+', '-' };
        private char[] numChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private Queue<char> nums;

        public int MyAtoi(string str)
        {
            nums = new Queue<char>();
            FindoutAvailbeChars(str);
            return GenerateNum();
        }

        private void FindoutAvailbeChars(string str)
        {
            foreach (var c in str)
            {
                if (nums.Count == 0 && IsHeadChar(c))
                {
                    if (c == '-' || c == '+')
                        nums.Enqueue(c);
                }
                else if (IsNumChar(c))
                    nums.Enqueue(c);
                else
                    break;
            }
        }

        private int GenerateNum()
        {
            if (nums.Count == 0 ||
                (nums.Count == 1 && (nums.Peek() == '+' || nums.Peek() == '-')))
                return 0;

            var num = 0;
            var added = 0;
            var factor = 1;
            var sum = 0;

            while (nums.Count > 0)
            {
                var c = nums.Dequeue();
                switch (c)
                {
                    case '+':
                        factor = 1;
                        break;

                    case '-':
                        factor = -1;
                        break;

                    default:
                        num = int.Parse(c + "");
                        break;
                }

                if (factor > 0 && int.MaxValue < num * Math.Pow(10, nums.Count))
                    return int.MaxValue;
                else if (factor < 0 && int.MinValue > -1 * num * Math.Pow(10, nums.Count))
                    return int.MinValue;

                added = factor * num * (int)Math.Pow(10, nums.Count);

                if (factor > 0 && IsTopOverFlow(sum, added))
                    return int.MaxValue;
                else if (factor < 0 && IsBottomOverFlow(sum, added))
                    return int.MinValue;
                sum += added;
            }

            return sum;
        }

        private bool IsTopOverFlow(int num, int added)
        {
            return int.MaxValue - num < added;
        }

        private bool IsBottomOverFlow(int num, int added)
        {
            return int.MinValue - num > added;
        }

        private bool IsHeadChar(char c)
        {
            foreach (var h in headChars)
            {
                if (h == c)
                    return true;
            }
            return false;
        }

        private bool IsNumChar(char c)
        {
            foreach (var h in numChars)
            {
                if (h == c)
                    return true;
            }
            return false;
        }
    }
}