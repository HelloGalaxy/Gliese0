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
        public int Reverse(int x)
        {
            var reverse = 0;
            while (x != 0)
            {
                // 最大数字和置反数查个10倍的就要挂了
                if (reverse != 0 && (10 > int.MaxValue / reverse && 10 > -int.MaxValue / reverse))
                {
                    return 0;
                }

                reverse = x % 10 + reverse * 10;
                x = x / 10;
            }
            return reverse;
        }

        //public int Reverse(int x)
        //{
        //    var isNegative = x < 0;
        //    if (isNegative)
        //    {
        //        x = -x;
        //    }

        //    var reverse = 0;

        //    while (x > 0)
        //    {
        //        if (reverse != 0 && reverse * 10d > int.MaxValue)
        //        {
        //            return 0;
        //        }

        //        reverse = x % 10 + reverse * 10;
        //        x = x / 10;
        //    }

        //    if (isNegative)
        //    {
        //        reverse = -reverse;
        //    }

        //    return reverse;
        //}


        //private Stack<int> cache = new Stack<int>();

        //public int Reverse(int x)
        //{
        //    try
        //    {
        //        var tmp = Math.Abs(x);
        //        while (tmp > 0)
        //        {
        //            if (tmp > 10)
        //            {
        //                var carry = tmp % 10;
        //                tmp = tmp / 10;
        //                cache.Push(carry);
        //            }
        //            else
        //            {
        //                cache.Push(tmp);
        //            }

        //        }

        //        tmp = 0;
        //        var power = 0;
        //        while (cache.Count > 0)
        //        {
        //            var sum = cache.Pop() * Math.Pow(10, power);

        //            if (sum > int.MaxValue)
        //            {
        //                return 0;
        //            }
        //            else
        //            {
        //                tmp += (int)sum;
        //            }
        //            power++;
        //        }
        //        if (x < 0)
        //        {
        //            tmp *= -1;
        //        }
        //        return tmp;
        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
        //}
    }
}