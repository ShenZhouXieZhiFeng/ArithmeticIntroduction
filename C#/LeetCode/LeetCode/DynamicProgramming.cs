using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 递归和动态规划（带缓存的递归）
    /// </summary>
    class DynamicProgramming
    {
        static void Main(string[] args)
        {
            //hanoi(3,'a','b','c');
            //Console.WriteLine(fibonacci(7));

            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(getSum(arr, arr.Length - 1));

            //Console.WriteLine(getSum2(3));

            int[] arr = { 1, 2, 3 };
            pailie(arr,0,2);

            Console.ReadLine();
        }

        #region 递归练习



        //全排列数组
        public static void pailie(int[] arr,int p,int q) {
            if (p == q)
            {
                //触底的时候已经排列好一次了
                //打印
                for (int i = 0; i < arr.Length; i++) {
                    Console.Write(arr[i]);
                }
                Console.WriteLine("");
                return;
            }
            for (int i = p; i <= q; i++) {
                //swap 交换
                swap(arr, p, i);
                pailie(arr, p + 1, q);
                //swap 换回去
                swap(arr, p, i);
            }
        }
        public static void swap(int[] arr,int m,int n) {
            int t = arr[m];
            arr[m] = arr[n];
            arr[n] = t;
        }

        // 求 1 - n 的和
        //f(1) = 1
        //f(n) = f(n-1) + n
        public static int getSum2(int n) {
            if (n == 1)
                return 1;
            return n + getSum2(n - 1);
        }

        //递归求数组和
        //F(0) = arr[0];
        //F(n) = F(n - 1) + arr[n];
        public static int getSum(int[] arr,int n) {
            if (n == 0)
                return arr[0];
            return getSum(arr, n - 1) + arr[n];
        }

        //斐波那契数列 1 1 2 3 5 8 13 21
        public static int fibonacci(int n) {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        //汉诺塔问题
        public static void hanoi(int n,char a,char b,char c) {
            if (n == 1)
            {
                Console.WriteLine(a + "->" + c);
            }
            else {
                hanoi(n - 1, a, c, b);
                Console.WriteLine(a + "->" + c);
                hanoi(n - 1, b, a, c);
            }
        }

        #endregion

        //递归
        static int count = 0; //计算F(n)被调用了计次
        static int F(int n)
        {
            count++;
            if (n == 0) return 1;         //n等于0，恰好到达9层阶梯
            if (n < 0) return 0;
            return F(n - 3) + F(n - 4) + F(n - 6);  //深搜，走3级，4级，6级能到达目的地的次数相加
        }

    }
}
