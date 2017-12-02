using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCVI"));//1996
           
        }


        #region easy

        //Given a roman numeral, convert it to an integer.
        //Input is guaranteed to be within the range from 1 to 3999.
        public static int RomanToInt(string s)
        {
            //单字符
            int[] v1 = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
            String[] k1 = new String[] { "M", "D", "C", "L", "X", "V", "I" };

            //双字符数组  
            int[] v2 = new int[] { 900, 400, 90, 40, 9, 4 };
            String[] k2 = new String[] { "CM", "CD", "XC", "XL", "IX", "IV" };

            int res = 0;

            bool v2f = false;//判断双字符有没有匹配成功
            while (s.Length > 0) {
                if (s.Length > 1) {
                    string str1 = s.Substring(0, 2);
                    for (int i = 0; i < k2.Length; i++)
                    {
                        if (str1 == k2[i])
                        {
                            res += v2[i];
                            s = s.Substring(2);
                            v2f = true;
                            break;
                        }
                    }
                }
                if (!v2f) {
                    string str2 = s.Substring(0, 1);
                    for (int i = 0; i < k1.Length; i++)
                    {
                        if (str2 == k1[i])
                        {
                            res += v1[i];
                            s = s.Substring(1);
                            break;
                        }
                    }
                }
                v2f = false;
            }
            return res;
        }

        /// <summary>
        /// Determine whether an integer is a palindrome. Do this without extra space.
        /// 回文
        /// </summary>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int res = 0;
            int temp = x;
            while (temp != 0) {
                int last = temp % 10;
                int newRes = res * 10 + last;
                if ((newRes - last) / 10 != res)
                    return false;
                res = newRes;
                temp /= 10;
            }
            if (res == x)
                return true;
            return false;
        }

        /// <summary>
        /// 54321 - > 12345
        /// </summary>
        public static int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int last = x % 10;
                int newRes = res * 10 + last;
                //验证数据
                if ((newRes - last) / 10 != res)
                    return 0;
                res = newRes;
                x = x / 10;
            }
            return res;
        }

        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
                return nums;
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if(nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }
            return res;
        }
        #endregion

    }
}
