using System;

namespace LeetCode
{
    /// <summary>
    /// 单链表训练
    /// </summary>
    class ListNodeTrain
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,4,3,2,1 };
            LinkList ll = new LinkList(arr);
            //ll.Insert(2, 6);
            ll.Reversal();
            ll.Print();
            //Console.WriteLine(ll.Get(2));
        }
        /// <summary>
        /// 链表操作类
        /// </summary>
        public class LinkList {
            private ListNode first;
            /// <summary>
            /// 建立只有头指针的单链表
            /// </summary>
            public LinkList() {
                first = null;
            }
            /// <summary>
            /// 顺序打印链表
            /// </summary>
            public void Print()
            {
                if (first == null)
                    return;
                ListNode t = first;
                while (t != null) {
                    Console.Write(t.val);
                    t = t.next;
                }
            }
            /// <summary>
            /// 将数组转换成单链表
            /// </summary>
            /// <param name="a"></param>
            public LinkList(int[] a) {
                if (a == null || a.Length <= 0)
                    return;
                first = new ListNode(a[0]);
                ListNode temp = first;
                for (int i = 1; i < a.Length; i++) {
                    temp.next = new ListNode(a[i]);
                    temp = temp.next;
                }
            }
            /// <summary>
            /// 求单链表的长度
            /// </summary>
            public int Length {
                get {
                    int len = 0;
                    ListNode t = first;
                    while (t != null) {
                        len++;
                        t = t.next;
                    }
                    return len;
                }
            }
            /// <summary>
            /// 获取链表中指定下标的值
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public int Get(int index){
                if (Length < index)
                    return -1;
                ListNode t = first;
                int count = 0;
                while (t != null) {
                    if (count == index)
                        return t.val;
                    t = t.next;
                    count++;
                }
                return -1;
            }
            /// <summary>
            /// 求值为val的节点的下标，返回第一个
            /// </summary>
            /// <param name="val"></param>
            /// <returns></returns>
            public int Locate(int val) {
                ListNode t = first;
                int count = 0;
                while (t != null) {
                    if (t.val == val)
                        return count;
                    t = t.next;
                    count++;
                }
                return -1;
            }
            /// <summary>
            /// 在链表的指定位置插入值为val的节点
            /// </summary>
            /// <param name="index"></param>
            /// <param name="val"></param>
            public bool Insert(int index,int val) {
                ListNode t = first;
                int count = 0;
                while (t != null) {
                    if (count == index) {
                        ListNode n = new ListNode(val);
                        n.next = t.next;
                        t.next = n;
                        return true;
                    }
                    t = t.next;
                    count++;
                }
                return false;
            }
            /// <summary>
            /// 删除下标为index的节点
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public bool Delete(int index) {
                int count = 1;
                ListNode t = first;
                while (t != null) {
                    if (count == index) {
                        ListNode curr = t;
                        t = t.next;
                        curr.next = t.next;
                        return true;
                    }
                    t = t.next;
                    count++;
                }
                return false;
            }
            /// <summary>
            /// 判断是否为空
            /// </summary>
            /// <returns></returns>
            public bool IsEmpty() {
                if (first == null)
                    return true;
                return false;
            }
            /// <summary>
            /// 将链表按照从小到大排序,值交换(冒泡排序)
            /// </summary>
            public void SortValue() {
                if (first == null || first.next == null)
                    return;
                ListNode t1 = first;//t1是first的替身
                while (t1 != null) {
                    ListNode t2 = t1.next;
                    while (t2 != null) {
                        if (t2.val < t1.val) {
                            int t = t1.val;
                            t1.val = t2.val;
                            t2.val = t;
                        }
                        t2 = t2.next;
                    }
                    t1 = t1.next;
                }
            }
            /// <summary>
            /// 将链表进行翻转,递归实现，节点翻转
            /// </summary>
            public void Reversal() {
                if (first == null || first.next == null)
                    return;
                first = reversal(first);
            }
            // 先回溯到最终值，反过来进行节点的翻转
            ListNode reversal(ListNode head) {
                if (head == null || head.next == null) {
                    return head;
                }
                ListNode reHead = reversal(head.next);//rehead始终为最后的节点
                head.next.next = head;
                head.next = null;
                return reHead;
            }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
