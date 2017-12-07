using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 动态规划
    /// </summary>
    class DynamicProgramming
    {

        static void Main(string[] args)
        {
            int res = F2(10);
            Console.Write(res);
        }

        static int count = 0; //计算F(n)被调用了计次
        static int F(int n)
        {
            count++;
            if (n == 0) return 1;         //n等于0，恰好到达9层阶梯
            if (n < 0) return 0;
            return F(n - 3) + F(n - 4) + F(n - 6);  //深搜，走3级，4级，6级能到达目的地的次数相加
        }

        static int F2(int n)
        {
            if (n <= 1) return 1;
            int[] dp = new int[n];
            dp[0] = 1; dp[1] = 2;
            for (int i = 2; i < n; ++i)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n - 1];
        }

    }
}
