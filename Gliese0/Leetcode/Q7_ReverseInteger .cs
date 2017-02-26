using System;
using System.Collections.Generic;

namespace Gliese0.Leetcode
{
    // Reverse digits of an integer.
    //   Example1: x = 123, return 321
    //   Example2: x = -123, return -321
    /// <summary>
    /// 7. Reverse Integer
    /// </summary>
    public class Q7_ReverseInteger
    {
        private Stack<int> cache = new Stack<int>();

        public int Reverse(int x)
        {
            try
            {
                var tmp = Math.Abs(x);
                while (tmp > 0)
                {
                    if (tmp > 10)
                    {
                        var carry = tmp % 10;
                        tmp = tmp / 10;
                        cache.Push(carry);
                    }
                    else
                    {
                        cache.Push(tmp);
                    }

                }

                tmp = 0;
                var power = 0;
                while (cache.Count > 0)
                {
                    var sum = cache.Pop() * Math.Pow(10, power);

                    if (sum > int.MaxValue)
                    {
                        return 0;
                    }
                    else
                    {
                        tmp += (int)sum;
                    }
                    power++;
                }
                if (x < 0)
                {
                    tmp *= -1;
                }
                return tmp;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}