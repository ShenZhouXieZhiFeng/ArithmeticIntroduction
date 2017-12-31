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
        //static void Main(string[] args)
        //{
            //hanoi(3,'a','b','c');
            //Console.WriteLine(fibonacci(7));

            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(getSum(arr, arr.Length - 1));

            //Console.WriteLine(getSum2(3));

            //int[] arr = { 1, 2, 3 };
            //pailie(arr,0,2);

            //Console.Write(taozi(10));

            //Console.Write(getSum3(3333));

            //getCount(22);
            //Console.Write(count2);

        //    louti(4);
        //    Console.Write(count3);

        //    Console.ReadLine();
        //}

        #region 递归练习

        //爬楼梯问题
        //F(N) = F(N-1) + 1 或 F(N) = F(N-2) + 2;
        public static int count3 = 0;
        public static void louti(int n) {
            if (n < 0)
                return;
            if (n == 0) {
                count3++;
                return;
            }
            louti(n - 1);
            louti(n - 2);
        }

        //角谷定理。输入一个自然数，若为偶数，则把它除以2，若为奇数，则把它乘以3加1。
        //经过如此有限次运算后，总可以得到自然数值1。求经过多少次可得到自然数1。
        public static int count2 = 0;
        public static void getCount(int n) {
            count2++;
            if (n == 1)
                return;
            if (n % 2 == 0)
            {
                getCount(n / 2);
            }
            else {
                getCount(n * 3 + 1);
            }
        }

        //求一个数的各位之和
        public static int getSum3(int n) {
            if (n < 10)
                return n;
            return getSum3(n / 10) + n % 10;
        }


        //小猴子第一天摘下若干桃子,当即吃掉一半,又多吃一个.
        //第二天早上又将剩下的桃子吃一半,又多吃一个.
        //以后每天早上吃前一天剩下的一半另一个.
        //到第10天早上猴子想再吃时发现只剩下一个桃子了问第一天猴子共摘多少个桃子
        //f(1) = 1
        //f(n) = (f(n-1) + 1) * 2
        public static int taozi(int n) {
            if (n == 1)
                return 1;
            return (taozi(n - 1) + 1) * 2;
        }

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
            //前面是f（1） 和 f（2）
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            //将前面的到的结论加上去
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
