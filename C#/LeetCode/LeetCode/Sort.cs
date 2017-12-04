using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 各种排序算法
    /// </summary>
    class Sort
    {

        static void Main(string[] args) {
            int[] arr = { 5, 7, 1, 8, 4 };
            //maopao(arr);
            //xuanzhe(arr);
            //charu(arr);
            quick(arr,0,arr.Length-1);
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]);
            }
        }

        // 快速
        public static void quick(int[] arr,int left,int right) {
            if (left <= right) {
                int key = arr[left];
                int low = left;
                int high = right;
                while (low != high) {
                    //右扫描
                    while (high > low && arr[high] >= key)
                        high--;
                    arr[low] = arr[high];
                    //左扫描 
                    while (low < high && arr[low] <= key)
                        low ++;
                    arr[high] = arr[low];
                }
                arr[high] = key;
                quick(arr, left, low-1);
                quick(arr, high+1, right);
            }
        }

        //选择
        public static void xuanzhe(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[j] < arr[i])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
        }

        //插入
        public static void charu(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++) {
                int cur = i;
                for (int j = i-1; j > 0; j--) {
                    if (arr[cur] < arr[j])
                    {
                        int t = arr[cur];
                        arr[cur] = arr[j];
                        arr[j] = t;
                        cur--;
                    }
                    else break;
                }
            }
        }

        //冒泡
        public static void maopao(int[] arr) {
            for (int i = 0; i < arr.Length-1; i++) {
                for (int j = 0; j < arr.Length-1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        int t = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = t;
                    }
                }
            }
        }

    }
}
