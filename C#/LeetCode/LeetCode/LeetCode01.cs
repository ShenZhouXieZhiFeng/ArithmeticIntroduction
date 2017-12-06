using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LeetCode01
    {

        static void Main(string[] args)
        {
            //int[,] nums = { { 1, 2 }, { 3, 4 } };
            //MatrixReshape(nums,4,1);
            //Console.WriteLine(1);
            //string[] ops = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            //CalPoints(ops);
            int[,] can = { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            IslandPerimeter(can);
        }

        #region 20171206

        //463. Island Perimeter
        public static int IslandPerimeter(int[,] grid)
        {
            if (grid == null)
                return 0;
            int count = 0;
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (grid[i, j] == 1) {
                        count += 4;
                        if (i < row - 1) {
                            if (grid[i + 1, j] == 1)
                                count -= 1;
                        }
                        if (i > 0) {
                            if (grid[i - 1, j] == 1)
                                count -= 1;
                        }
                        if (j < col - 1) {
                            if (grid[i, j + 1] == 1)
                                count -= 1;
                        }
                        if (j > 0) {
                            if (grid[i, j - 1] == 1)
                                count -= 1;
                        }
                    }
                }
            }
            return count;
        }

        //***
        //Given an integer array with even length, where different numbers in this array represent different kinds of candies.
        //Each number means one candy of the corresponding kind. 
        //You need to distribute these candies equally in number to brother and sister.
        //Return the maximum number of kinds of candies the sister could gain.
        public static int DistributeCandies(int[] candies)
        {
            int[] arr = candies.OrderBy(x => x).ToArray();
            int count = 1;
            for (int i = 1; i < candies.Length; i++) {
                if (arr[i] != arr[i - 1])
                    count++;
            }
            return count > candies.Length / 2 ? candies.Length / 2 : count;
        }

        #endregion

        #region 20171205

        //You're now a baseball game point recorder.
        //Given a list of strings, each string can be one of the 4 following types:
        //Integer(one round's score): Directly represents the number of points you get in this round.
        //"+" (one round's score): Represents that the points you get in this round are the sum of the last two valid round's points.
        //"D" (one round's score): Represents that the points you get in this round are the doubled data of the last valid round's points.
        //"C" (an operation, which isn't a round's score): Represents the last valid round's points you get were invalid and should be removed.
        //Each round's operation is permanent and could have an impact on the round before and the round after.
        //You need to return the sum of the points you could get in all the rounds.
        public static int CalPoints(string[] ops)
        {
            if (ops == null)
                return 0;
            List<int> cList = new List<int>();
            int sum = 0;
            int curCount = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                string s = ops[i];
                switch (ops[i])
                {
                    case "+":
                        curCount = 0;
                        for (int j = cList.Count - 1; j > cList.Count - 3; j--)
                        {
                            curCount += cList[j];
                        }
                        sum += curCount;
                        cList.Add(curCount);
                        break;
                    case "D":
                        curCount = cList.Last() * 2;
                        sum += curCount;
                        cList.Add(curCount);
                        break;
                    case "C":
                        curCount = cList.Last();
                        sum -= curCount;
                        cList.RemoveAt(cList.Count - 1);
                        break;
                    default:
                        curCount = int.Parse(s);
                        cList.Add(curCount);
                        sum += curCount;
                        break;
                }
            }
            return sum;
        }

        //***
        //我们可以找一个有效位和所给的数相同，且每一位都是1的数与之做异或运算，即可得到答案。
        //Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.
        public static int FindComplement(int num)
        {
            int xorNum = 1;
            int n = num >> 1;
            while (n > 0) {
                xorNum = ((xorNum << 1) + 1);
                n = n >> 1;
            }
            return num ^ xorNum;
        }

        //***
        //搜索二叉树，将左树值中大于L的去掉，将右树中大于R的节点去掉
        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return root;
            if (root.val >= L && root.val <= R) {
                //该节点被存下来
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
                return root;
            }
            //该节点被去掉了
            if (root.val < L) return TrimBST(root.right, L, R);
            if (root.val > R) return TrimBST(root.left, L, R);
            return root;
        }

        //***
        //In MATLAB, there is a very useful function called 'reshape', which can reshape a matrix into a new one with different size but keep its original data.
        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            if (r * c != nums.Length)
                return nums;
            int[,] res = new int[r, c];
            int i = 0;
            foreach (int a in nums) {
                res[i / c, i % c] = a;
                i++;
            }
            return res;
        }

        #endregion

    }
}
