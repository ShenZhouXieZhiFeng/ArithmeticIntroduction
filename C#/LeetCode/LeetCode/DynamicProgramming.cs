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

            //int[] coins = { 1, 2, 3, 4, 5 };
            //int res = chooseCoins(coins);

            //int[] coins = { 1, 3, 4 };
            //int res = changeMaking(6, coins);

            //int[,] coins = new int[5, 6] {
            //    { 0, 0, 0, 0, 1, 0 },
            //    { 0, 1, 0, 1, 0, 0 },
            //    { 0, 0, 0, 1, 0, 1 },
            //    { 0, 0, 1, 0, 0, 1 },
            //    { 1, 0, 0, 0, 1, 0 }};
            //int res = coinsCollections(coins);

        //    int[] coins = { 1, 3, 5 };
        //    int res = changeMaking2(6, coins);

        //    Console.ReadLine();
        //}

        #region DP



        //硬币收集问题
        //再NxM的格子中放有一些硬币，再（0，0）处有一个机械手臂，该手臂可以收集当前格子的硬币
        //机器手臂每次只能向右或向下移动一格，求最后能收集到的最大硬币数是多少
        public static int coinsCollections(int[,] coins)
        {
            int row = coins.GetLength(0);//行
            int col = coins.GetLength(1);//列
            int[,] res = new int[row, col];//构建保存每一步最大情况的数组
            res[0, 0] = coins[0, 0];
            //第1列，没有左邻，下面的数值为上面的数值+当前数值
            for (int i = 1; i < col; i++)
            {
                res[1, i] = res[1, i - 1] + coins[1, i];
            }
            //从第1行开始遍历
            for (int i = 1; i < row; i++)
            {
                //针对第1行（没有右邻）
                res[i, 1] = res[i - 1, 1] + coins[i, 1];
                for (int j = 1; j < col; j++)
                {
                    res[i, j] = Math.Max(res[i - 1, j], res[i, j - 1]) + coins[i, j];
                }
            }
            return res[row-1,col-1];
        }

        //币值最大化问题，给定一排硬币，选择的硬币不能相邻，如何能使总值最大
        public static int chooseCoins(int[] coins)
        {
            int[] res = new int[coins.Length];
            res[0] = coins[0];
            res[1] = coins[1];
            for (int i = 2; i < coins.Length; i++)
            {
                //每次的结果都保存下来
                //在选择当前最大值的时候，需要参考之前的结果
                //可以选择 往前第2个硬币+当前硬币 或者 往前第1个硬币
                res[i] = Math.Max(coins[i] + res[i - 2], res[i - 1]);
            }
            return res.Last();
        }

        //找零问题，给定一个目标值和一组硬币的币值，最多又多少种方法
        public static int changeMaking2(int target, int[] coins)
        {
            int len = coins.Length;
            int[,] res = new int[len + 1, target + 1];

            for (int i = 0; i <= len; i++)
                res[i, 0] = 1;
            for (int i = 1; i <= target; i++)
                res[0, i] = 0;
            for (int i = 1; i <= len; i++)
            {
                for (int j = 1; j <= target; j++)
                {
                    if (j < coins[i - 1])
                    {
                        res[i, j] = res[i - 1, j];
                        continue;
                    }
                    res[i, j] = res[i - 1,j] + res[i, j - coins[i - 1]];
                }
            }
            return res[len,target];
        }

        //找零问题，给定一个目标值和一组硬币的币值，最少需要多少枚硬币可以满足目标值，返回最大的总值
        public static int changeMaking(int target,int[] coins)
        {
            int[] res = new int[target];
            res[0] = 0;
            //从1计算到n
            for (int i = 1; i < target; i++)
            {
                //根据之前的计算结果，计算当前n所能取得的最小值
                int temp = int.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    int coin = coins[j];
                    if (i >= coin)
                    {
                        //减去小于n的硬币面值，获得之前的最小值
                        //多个最小值做比较，得出最终的最小值
                        temp = Math.Min(res[i - coin], temp);
                    }
                }
                res[i] = temp + 1;
            }
            return res[target-1];
        }

        #endregion

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

        //递归
        static int count = 0; //计算F(n)被调用了计次
        static int F(int n)
        {
            count++;
            if (n == 0) return 1;         //n等于0，恰好到达9层阶梯
            if (n < 0) return 0;
            return F(n - 3) + F(n - 4) + F(n - 6);  //深搜，走3级，4级，6级能到达目的地的次数相加
        }

        #endregion
    }
}
